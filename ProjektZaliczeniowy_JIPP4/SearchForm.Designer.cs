
namespace ProjektZaliczeniowy_JIPP4
{
    partial class SearchForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyKobietaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektJIPP4_DanielMarkiewiczDataSet = new ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSet();
            this.osobaTableAdapter = new ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OsobaTableAdapter();
            this.eclipseButtonSearchFormExit = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4_DanielMarkiewiczDataSet)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(487, 20);
            this.textBoxName.TabIndex = 16;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(6, 71);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(487, 20);
            this.textBoxSurname.TabIndex = 17;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 13);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Wpisz Imię";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(6, 55);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(85, 13);
            this.labelSurname.TabIndex = 22;
            this.labelSurname.Text = "Wpisz Nazwisko";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn,
            this.czyKobietaDataGridViewCheckBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.plecDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.osobaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 309);
            this.dataGridView1.TabIndex = 24;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            this.dataUrodzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // czyKobietaDataGridViewCheckBoxColumn
            // 
            this.czyKobietaDataGridViewCheckBoxColumn.DataPropertyName = "CzyKobieta";
            this.czyKobietaDataGridViewCheckBoxColumn.HeaderText = "CzyKobieta";
            this.czyKobietaDataGridViewCheckBoxColumn.Name = "czyKobietaDataGridViewCheckBoxColumn";
            this.czyKobietaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "Pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            this.peselDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plecDataGridViewTextBoxColumn
            // 
            this.plecDataGridViewTextBoxColumn.DataPropertyName = "Plec";
            this.plecDataGridViewTextBoxColumn.HeaderText = "Plec";
            this.plecDataGridViewTextBoxColumn.Name = "plecDataGridViewTextBoxColumn";
            this.plecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // osobaBindingSource
            // 
            this.osobaBindingSource.DataMember = "Osoba";
            this.osobaBindingSource.DataSource = this.projektJIPP4_DanielMarkiewiczDataSet;
            // 
            // projektJIPP4_DanielMarkiewiczDataSet
            // 
            this.projektJIPP4_DanielMarkiewiczDataSet.DataSetName = "ProjektJIPP4_DanielMarkiewiczDataSet";
            this.projektJIPP4_DanielMarkiewiczDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osobaTableAdapter
            // 
            this.osobaTableAdapter.ClearBeforeFill = true;
            // 
            // eclipseButtonSearchFormExit
            // 
            this.eclipseButtonSearchFormExit.BackColor = System.Drawing.Color.Red;
            this.eclipseButtonSearchFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseButtonSearchFormExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseButtonSearchFormExit.Location = new System.Drawing.Point(535, 337);
            this.eclipseButtonSearchFormExit.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseButtonSearchFormExit.Name = "eclipseButtonSearchFormExit";
            this.eclipseButtonSearchFormExit.Size = new System.Drawing.Size(252, 90);
            this.eclipseButtonSearchFormExit.TabIndex = 18;
            this.eclipseButtonSearchFormExit.Text = "Zakończ wyszukiwanie";
            this.eclipseButtonSearchFormExit.UseVisualStyleBackColor = false;
            this.eclipseButtonSearchFormExit.Click += new System.EventHandler(this.eclipseButtonSearchFormExit_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSearch.Controls.Add(this.labelSurname);
            this.groupBoxSearch.Controls.Add(this.labelName);
            this.groupBoxSearch.Controls.Add(this.textBoxSurname);
            this.groupBoxSearch.Controls.Add(this.textBoxName);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 328);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(499, 99);
            this.groupBoxSearch.TabIndex = 25;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Wyszukiwanie";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 445);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.eclipseButtonSearchFormExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4_DanielMarkiewiczDataSet)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private EclipseButton eclipseButtonSearchFormExit;
        private ProjektJIPP4_DanielMarkiewiczDataSet projektJIPP4_DanielMarkiewiczDataSet;
        private ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OsobaTableAdapter osobaTableAdapter;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn czyKobietaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private System.Windows.Forms.GroupBox groupBoxSearch;
    }
}