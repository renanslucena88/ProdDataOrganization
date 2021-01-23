
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
            this.dataGridViewField1 = new System.Windows.Forms.DataGridView();
            this.IdFieldFile1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFieldFile2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLoadFields = new System.Windows.Forms.Button();
            this.ProdDataChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBarProdAnal = new System.Windows.Forms.ProgressBar();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerateChart = new System.Windows.Forms.Button();
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
            this.btnUpload.Location = new System.Drawing.Point(12, 12);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(153, 65);
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
            this.btnLoadAll.Location = new System.Drawing.Point(12, 83);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(153, 46);
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
            this.label1.Location = new System.Drawing.Point(21, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Files";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(976, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
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
            this.dataGridViewFile1.Location = new System.Drawing.Point(12, 160);
            this.dataGridViewFile1.Name = "dataGridViewFile1";
            this.dataGridViewFile1.ReadOnly = true;
            this.dataGridViewFile1.RowHeadersWidth = 51;
            this.dataGridViewFile1.RowTemplate.Height = 24;
            this.dataGridViewFile1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFile1.Size = new System.Drawing.Size(355, 360);
            this.dataGridViewFile1.TabIndex = 6;
            this.dataGridViewFile1.SelectionChanged += new System.EventHandler(this.dataGridViewProdAnal1_SelectionChanged);
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
            this.dataGridViewField1.Location = new System.Drawing.Point(636, 160);
            this.dataGridViewField1.Name = "dataGridViewField1";
            this.dataGridViewField1.ReadOnly = true;
            this.dataGridViewField1.RowHeadersWidth = 51;
            this.dataGridViewField1.RowTemplate.Height = 24;
            this.dataGridViewField1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewField1.Size = new System.Drawing.Size(614, 360);
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
            this.btnLoadFields.Location = new System.Drawing.Point(470, 319);
            this.btnLoadFields.Name = "btnLoadFields";
            this.btnLoadFields.Size = new System.Drawing.Size(64, 89);
            this.btnLoadFields.TabIndex = 8;
            this.btnLoadFields.Text = ">>";
            this.btnLoadFields.UseVisualStyleBackColor = true;
            this.btnLoadFields.Click += new System.EventHandler(this.btnLoadFields_Click);
            // 
            // ProdDataChart1
            // 
            chartArea1.Name = "ChartArea1";
            this.ProdDataChart1.ChartAreas.Add(chartArea1);
            this.ProdDataChart1.Location = new System.Drawing.Point(45, 526);
            this.ProdDataChart1.Name = "ProdDataChart1";
            this.ProdDataChart1.Size = new System.Drawing.Size(1139, 269);
            this.ProdDataChart1.TabIndex = 9;
            this.ProdDataChart1.Text = "Production Analysis";
            // 
            // progressBarProdAnal
            // 
            this.progressBarProdAnal.Location = new System.Drawing.Point(592, 37);
            this.progressBarProdAnal.Name = "progressBarProdAnal";
            this.progressBarProdAnal.Size = new System.Drawing.Size(453, 40);
            this.progressBarProdAnal.Step = 1;
            this.progressBarProdAnal.TabIndex = 10;
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
            // 
            // btnGenerateChart
            // 
            this.btnGenerateChart.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
            this.btnGenerateChart.Image = ((System.Drawing.Image)(resources.GetObject("btnGenerateChart.Image")));
            this.btnGenerateChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateChart.Location = new System.Drawing.Point(404, 464);
            this.btnGenerateChart.Name = "btnGenerateChart";
            this.btnGenerateChart.Size = new System.Drawing.Size(204, 56);
            this.btnGenerateChart.TabIndex = 11;
            this.btnGenerateChart.Text = "Generate Chart";
            this.btnGenerateChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerateChart.UseVisualStyleBackColor = true;
            this.btnGenerateChart.Click += new System.EventHandler(this.btnGenerateChart_Click);
            // 
            // FormProdAnal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1752, 1055);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFieldFile1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFieldFile2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProdDataChart1;
        private System.Windows.Forms.ProgressBar progressBarProdAnal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.Button btnGenerateChart;
    }
}

