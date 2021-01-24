namespace DataOrganization
{
    using DataOrganization.Core.Business;
    using DataOrganization.Core.Infrastructure.DB;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    /// <summary>
    /// Defines the <see cref="FormProdAnal1" />.
    /// </summary>
    public partial class FormProdAnal1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormProdAnal1"/> class.
        /// </summary>
        public FormProdAnal1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The CheckIfFolderExist.
        /// </summary>
        /// <param name="path">The path<see cref="string"/>.</param>
        private void CheckIfFolderExist(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private void DeleteFile(string path, string allPath)
        {
            if (Directory.Exists(path))
            {
                System.IO.File.Delete(allPath);
            }
        }

        /// <summary>
        /// The btnUpload_Click.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="EventArgs"/>.</param>
        private void btnUpload_Click(object sender, EventArgs e)
        {
            ProdAnalBusiness business = new ProdAnalBusiness();

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                try
                {
                    string file = openFileDialog1.FileName;
                    string[] f = file.Split('\\');
                    string fn = f[(f.Length) - 1];
                    string tmpPath = Path.GetTempPath();

                    //Create Folder and save the file
                    CheckIfFolderExist(tmpPath);
                    string dest = @tmpPath + @"\" + fn;
                    System.IO.File.Copy(file, dest, true);

                    //Read CSV
                    var lines = System.IO.File.ReadAllLines(dest);

                    //Good pratices to clear the cache before use a database transaction
                    business.SaveChanges();

                    //Delete the file upload after save and read the lines
                    DeleteFile(tmpPath, dest);

                    //Get Id File uploaded
                    int tmpIdFile = business.InsertFile(fn);

                    //Configuration of the progress bar while is updating the CSV to the DB
                    progressBarProdAnal.Visible = true;
                    progressBarProdAnal.Value = 0;
                    progressBarProdAnal.Maximum = lines.Length;

                    //If is the 1st line, save in Field Table. If not the first line, save the content of each field
                    int firstTime = 0;

                    foreach (var item in lines)
                    {
                        if (progressBarProdAnal.Value >= lines.Length)
                        {
                            progressBarProdAnal.Value = 0;
                        }
                        progressBarProdAnal.Value++;

                        if (firstTime == 0)
                        {
                            foreach (var itemField in item.Split(','))
                            {
                                business.InsertField(tmpIdFile, itemField);
                            }
                            business.SaveChanges();
                        }
                        else
                        {
                            var tmpIdFields = business.GetIdFieldsByFile(tmpIdFile);
                            var arrContent = item.Split(',');
                            for (int i = 0; i < arrContent.Length; i++)
                            {
                                business.InsertContent(tmpIdFields[i], arrContent[i], firstTime);
                            }
                        }
                        firstTime++;
                    }
                    business.SaveChanges();
                    RefreshGrids();
                    progressBarProdAnal.Visible = false;
                }
                catch (Exception ex)
                {
                    progressBarProdAnal.Visible = false;
                    throw;
                }
                MessageBox.Show("Uploaded");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBarProdAnal.Visible = false;
            RefreshGrids();
        }

        public void RefreshGrids()
        {
            dataGridViewFile1.Rows.Clear();
            dataGridViewField1.Rows.Clear();
            ProdAnalBusiness business = new ProdAnalBusiness();
            var lstFiles = business.GetAllFields();
            dataGridViewFile1.Rows.Clear();
            foreach (var item in lstFiles)
            {
                dataGridViewFile1.Rows.Add(item.Id.ToString(), item.Name);

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ClearListViewFields();
            RefreshGrids();

        }


        public void ClearListViewFields()
        {
            dataGridViewField1.Rows.Clear();
        }

        private void dataGridViewProdAnal1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewFile1.SelectedRows.Count > 2)
            {
                for (int i = 2; i < dataGridViewFile1.SelectedRows.Count; i++)
                {
                    dataGridViewFile1.SelectedRows[i].Selected = false;

                }
            }
        }

        private void btnLoadFields_Click(object sender, EventArgs e)
        {
            List<int> lstIdsSelected = new List<int>();
            var selectedRow = dataGridViewFile1.SelectedRows;
            if (selectedRow.Count > 0)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRow.Count; i++)
                {
                    lstIdsSelected.Add(Convert.ToInt32(selectedRow[i].Cells[0].Value));
                }
            }
            LoadCompativeFields(lstIdsSelected);
        }

        public void LoadCompativeFields(List<int> lstIdsSelected)
        {
            ProdAnalBusiness business = new ProdAnalBusiness();
            Dictionary<int, string> dicFieds1 = new Dictionary<int, string>();
            Dictionary<int, string> dicFieds2 = new Dictionary<int, string>();
            List<string> lstFiedsResult = new List<string>();


            for (int i = 0; i < lstIdsSelected.Count; i++)
            {
                var tmpFieldsList = business.GetFieldsByFile(lstIdsSelected[i]);
                if (i == 0)
                {
                    foreach (var itemFields in tmpFieldsList)
                    {
                        dicFieds1.Add(itemFields.Id, itemFields.Field1);
                    }
                }
                else
                {
                    foreach (var itemFields in tmpFieldsList)
                    {
                        dicFieds2.Add(itemFields.Id, itemFields.Field1);
                    }
                }
            }
            lstFiedsResult.AddRange(dicFieds2.Select(x => x.Value).Intersect(dicFieds1.Select(x => x.Value)));

            foreach (var item in lstFiedsResult)
            {
                var tmpId1 = dicFieds1.FirstOrDefault(x => x.Value == item).Key;
                var tmpId2 = dicFieds2.FirstOrDefault(x => x.Value == item).Key;
                dataGridViewField1.Rows.Add(tmpId1, tmpId2, item);
            }

        }

        private void btnGenerateChart_Click(object sender, EventArgs e)
        {
            ProdAnalBusiness business = new ProdAnalBusiness();
            Dictionary<int, string> dicValueFieldsFile1 = new Dictionary<int, string>();
            Dictionary<int, string> dicValueFieldsFile2 = new Dictionary<int, string>();
            List<Content> lstValueFile1 = new List<Content>();
            List<Content> lstValueFile2 = new List<Content>();

            ProdDataChart1.Series.Clear();
            var selectedRow = dataGridViewField1.SelectedRows;

            if (selectedRow.Count > 0)
            {
                StringBuilder sb = new StringBuilder();

                //Get selected fields. There are 2 Id columns in Field Grid. 1 ID column for each file selected.
                for (int i = 0; i < selectedRow.Count; i++)
                {
                    dicValueFieldsFile1.Add(Convert.ToInt32(selectedRow[i].Cells[0].Value), selectedRow[i].Cells[2].Value.ToString());
                    dicValueFieldsFile2.Add(Convert.ToInt32(selectedRow[i].Cells[1].Value), selectedRow[i].Cells[2].Value.ToString());
                }

                //
                foreach (var item in dicValueFieldsFile1)
                {
                    var tmpField = business.GetContentByIdField(item.Key);
                    lstValueFile1.Add(tmpField);
                }

                foreach (var item in dicValueFieldsFile2)
                {
                    var tmpField = business.GetContentByIdField(item.Key);
                    lstValueFile2.Add(tmpField);
                }

                if (lstValueFile1.Count > 0)
                {
                    ProdDataChart1.Series.Add(lstValueFile1[0].Field.File.Name);
                    foreach (var item in lstValueFile1)
                    {
                        if (double.TryParse(item.FieldContent, out double tmpContent))
                        {
                            ProdDataChart1.Series[0].Points.Add(tmpContent);
                        }
                    }
                }

                if (lstValueFile2.Count > 0)
                {
                    ProdDataChart1.Series.Add(lstValueFile2[0].Field.File.Name);
                    foreach (var item in lstValueFile2)
                    {
                        if (double.TryParse(item.FieldContent, out double tmpContent))
                        {
                            ProdDataChart1.Series[1].Points.Add(tmpContent);
                        }

                    }
                }

            }
        }

        public void DeleteAllRegisters()
        {
            ProdAnalBusiness business = new ProdAnalBusiness();
            business.DeleteAllRegisters();
            MessageBox.Show("All Registers deleted");
        }
    }
}
