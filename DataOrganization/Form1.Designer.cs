
namespace DataOrganization
{
    partial class FormProdAnal1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdAnal1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewFile1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewField1 = new System.Windows.Forms.DataGridView();
            this.IdFieldFile1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFieldFile2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadFields = new System.Windows.Forms.Button();
            this.ProdDataChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBarProdAnal = new System.Windows.Forms.ProgressBar();
            this.btnGenerateChart = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.cbWithoutZero = new System.Windows.Forms.CheckBox();
            this.rbOrderCres = new System.Windows.Forms.RadioButton();
            this.rbOrderDec = new System.Windows.Forms.RadioButton();
            this.btnLogo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDataChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(9, 80);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(101, 53);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadAll.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadAll.Image")));
            this.btnLoadAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadAll.Location = new System.Drawing.Point(328, 213);
            this.btnLoadAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(106, 37);
            this.btnLoadAll.TabIndex = 2;
            this.btnLoadAll.Text = "Refresh";
            this.btnLoadAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(732, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fields";
            // 
            // dataGridViewFile1
            // 
            this.dataGridViewFile1.AllowUserToAddRows = false;
            this.dataGridViewFile1.AllowUserToDeleteRows = false;
            this.dataGridViewFile1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFile1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FileName});
            this.dataGridViewFile1.Location = new System.Drawing.Point(9, 159);
            this.dataGridViewFile1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewFile1.Name = "dataGridViewFile1";
            this.dataGridViewFile1.ReadOnly = true;
            this.dataGridViewFile1.RowHeadersWidth = 51;
            this.dataGridViewFile1.RowTemplate.Height = 24;
            this.dataGridViewFile1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFile1.Size = new System.Drawing.Size(266, 292);
            this.dataGridViewFile1.TabIndex = 6;
            this.dataGridViewFile1.SelectionChanged += new System.EventHandler(this.dataGridViewProdAnal1_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FileName.HeaderText = "File Name";
            this.FileName.MinimumWidth = 6;
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            this.FileName.Width = 79;
            // 
            // dataGridViewField1
            // 
            this.dataGridViewField1.AllowUserToAddRows = false;
            this.dataGridViewField1.AllowUserToDeleteRows = false;
            this.dataGridViewField1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewField1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFieldFile1,
            this.IdFieldFile2,
            this.FieldName});
            this.dataGridViewField1.Location = new System.Drawing.Point(477, 159);
            this.dataGridViewField1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewField1.Name = "dataGridViewField1";
            this.dataGridViewField1.ReadOnly = true;
            this.dataGridViewField1.RowHeadersWidth = 51;
            this.dataGridViewField1.RowTemplate.Height = 24;
            this.dataGridViewField1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewField1.Size = new System.Drawing.Size(460, 292);
            this.dataGridViewField1.TabIndex = 7;
            // 
            // IdFieldFile1
            // 
            this.IdFieldFile1.HeaderText = "Id1";
            this.IdFieldFile1.MinimumWidth = 6;
            this.IdFieldFile1.Name = "IdFieldFile1";
            this.IdFieldFile1.ReadOnly = true;
            this.IdFieldFile1.Width = 125;
            // 
            // IdFieldFile2
            // 
            this.IdFieldFile2.HeaderText = "id2";
            this.IdFieldFile2.MinimumWidth = 6;
            this.IdFieldFile2.Name = "IdFieldFile2";
            this.IdFieldFile2.ReadOnly = true;
            this.IdFieldFile2.Width = 125;
            // 
            // FieldName
            // 
            this.FieldName.HeaderText = "Field";
            this.FieldName.MinimumWidth = 6;
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            this.FieldName.Width = 125;
            // 
            // btnLoadFields
            // 
            this.btnLoadFields.Location = new System.Drawing.Point(352, 288);
            this.btnLoadFields.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadFields.Name = "btnLoadFields";
            this.btnLoadFields.Size = new System.Drawing.Size(48, 72);
            this.btnLoadFields.TabIndex = 8;
            this.btnLoadFields.Text = ">>";
            this.btnLoadFields.UseVisualStyleBackColor = true;
            this.btnLoadFields.Click += new System.EventHandler(this.btnLoadFields_Click);
            // 
            // ProdDataChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.ProdDataChart1.ChartAreas.Add(chartArea1);
            this.ProdDataChart1.Location = new System.Drawing.Point(34, 456);
            this.ProdDataChart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProdDataChart1.Name = "ProdDataChart1";
            this.ProdDataChart1.Size = new System.Drawing.Size(854, 219);
            this.ProdDataChart1.TabIndex = 9;
            this.ProdDataChart1.Text = "Production Analysis";
            // 
            // progressBarProdAnal
            // 
            this.progressBarProdAnal.Location = new System.Drawing.Point(311, 101);
            this.progressBarProdAnal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBarProdAnal.Name = "progressBarProdAnal";
            this.progressBarProdAnal.Size = new System.Drawing.Size(340, 32);
            this.progressBarProdAnal.Step = 1;
            this.progressBarProdAnal.TabIndex = 10;
            // 
            // btnGenerateChart
            // 
            this.btnGenerateChart.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.btnGenerateChart.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateChart.Image")));
            this.btnGenerateChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateChart.Location = new System.Drawing.Point(303, 406);
            this.btnGenerateChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateChart.Name = "btnGenerateChart";
            this.btnGenerateChart.Size = new System.Drawing.Size(153, 46);
            this.btnGenerateChart.TabIndex = 11;
            this.btnGenerateChart.Text = "Generate Chart";
            this.btnGenerateChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateChart.UseVisualStyleBackColor = true;
            this.btnGenerateChart.Click += new System.EventHandler(this.btnGenerateChart_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.btnDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAll.Image")));
            this.btnDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAll.Location = new System.Drawing.Point(114, 80);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(117, 53);
            this.btnDeleteAll.TabIndex = 12;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // cbWithoutZero
            // 
            this.cbWithoutZero.AutoSize = true;
            this.cbWithoutZero.Location = new System.Drawing.Point(961, 180);
            this.cbWithoutZero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbWithoutZero.Name = "cbWithoutZero";
            this.cbWithoutZero.Size = new System.Drawing.Size(70, 17);
            this.cbWithoutZero.TabIndex = 13;
            this.cbWithoutZero.Text = "Sem zero";
            this.cbWithoutZero.UseVisualStyleBackColor = true;
            // 
            // rbOrderCres
            // 
            this.rbOrderCres.AutoSize = true;
            this.rbOrderCres.Location = new System.Drawing.Point(961, 245);
            this.rbOrderCres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbOrderCres.Name = "rbOrderCres";
            this.rbOrderCres.Size = new System.Drawing.Size(73, 17);
            this.rbOrderCres.TabIndex = 14;
            this.rbOrderCres.TabStop = true;
            this.rbOrderCres.Text = "Crescente";
            this.rbOrderCres.UseVisualStyleBackColor = true;
            // 
            // rbOrderDec
            // 
            this.rbOrderDec.AutoSize = true;
            this.rbOrderDec.Location = new System.Drawing.Point(961, 268);
            this.rbOrderDec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbOrderDec.Name = "rbOrderDec";
            this.rbOrderDec.Size = new System.Drawing.Size(86, 17);
            this.rbOrderDec.TabIndex = 15;
            this.rbOrderDec.TabStop = true;
            this.rbOrderDec.Text = "Decrescente";
            this.rbOrderDec.UseVisualStyleBackColor = true;
            // 
            // btnLogo
            // 
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(9, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(222, 63);
            this.btnLogo.TabIndex = 16;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // FormProdAnal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 609);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.rbOrderDec);
            this.Controls.Add(this.rbOrderCres);
            this.Controls.Add(this.cbWithoutZero);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnGenerateChart);
            this.Controls.Add(this.progressBarProdAnal);
            this.Controls.Add(this.ProdDataChart1);
            this.Controls.Add(this.btnLoadFields);
            this.Controls.Add(this.dataGridViewField1);
            this.Controls.Add(this.dataGridViewFile1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.btnUpload);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormProdAnal1";
            this.Text = "Análise de Produção";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewField1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDataChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewFile1;
        private System.Windows.Forms.DataGridView dataGridViewField1;
        private System.Windows.Forms.Button btnLoadFields;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProdDataChart1;
        private System.Windows.Forms.ProgressBar progressBarProdAnal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.Button btnGenerateChart;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFieldFile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFieldFile2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.CheckBox cbWithoutZero;
        private System.Windows.Forms.RadioButton rbOrderCres;
        private System.Windows.Forms.RadioButton rbOrderDec;
        private System.Windows.Forms.Button btnLogo;
    }
}

