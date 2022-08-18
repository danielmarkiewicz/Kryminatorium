
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataWyrokuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czasOdsiadkiMiesiaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyPrawomocnyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.zakladKarnyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyAktualnieWykonywanyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataZakonczeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skazanyIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerSprawyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajPrzestepstwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odbywaneWyrokiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektJIPP4DanielMarkiewiczDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektJIPP4_DanielMarkiewiczDataSet = new ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSet();
            this.odbywaneWyrokiTableAdapter = new ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OdbywaneWyrokiTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyKobietaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobaTableAdapter = new ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OsobaTableAdapter();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.eclipseExitSearchFormButton = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbywaneWyrokiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4DanielMarkiewiczDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4_DanielMarkiewiczDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataWyrokuDataGridViewTextBoxColumn,
            this.czasOdsiadkiMiesiaceDataGridViewTextBoxColumn,
            this.czyPrawomocnyDataGridViewCheckBoxColumn,
            this.zakladKarnyDataGridViewTextBoxColumn,
            this.czyAktualnieWykonywanyDataGridViewCheckBoxColumn,
            this.dataZakonczeniaDataGridViewTextBoxColumn,
            this.skazanyIdDataGridViewTextBoxColumn,
            this.numerSprawyDataGridViewTextBoxColumn,
            this.rodzajPrzestepstwaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odbywaneWyrokiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(952, 211);
            this.dataGridView1.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataWyrokuDataGridViewTextBoxColumn
            // 
            this.dataWyrokuDataGridViewTextBoxColumn.DataPropertyName = "DataWyroku";
            this.dataWyrokuDataGridViewTextBoxColumn.HeaderText = "DataWyroku";
            this.dataWyrokuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataWyrokuDataGridViewTextBoxColumn.Name = "dataWyrokuDataGridViewTextBoxColumn";
            this.dataWyrokuDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataWyrokuDataGridViewTextBoxColumn.Width = 125;
            // 
            // czasOdsiadkiMiesiaceDataGridViewTextBoxColumn
            // 
            this.czasOdsiadkiMiesiaceDataGridViewTextBoxColumn.DataPropertyName = "CzasOdsiadkiMiesiace";
            this.czasOdsiadkiMiesiaceDataGridViewTextBoxColumn.HeaderText = "CzasOdsiadkiMiesiace";
            this.czasOdsiadkiMiesiaceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.czasOdsiadkiMiesiaceDataGridViewTextBoxColumn.Name = "czasOdsiadkiMiesiaceDataGridViewTextBoxColumn";
            this.czasOdsiadkiMiesiaceDataGridViewTextBoxColumn.ReadOnly = true;
            this.czasOdsiadkiMiesiaceDataGridViewTextBoxColumn.Width = 125;
            // 
            // czyPrawomocnyDataGridViewCheckBoxColumn
            // 
            this.czyPrawomocnyDataGridViewCheckBoxColumn.DataPropertyName = "CzyPrawomocny";
            this.czyPrawomocnyDataGridViewCheckBoxColumn.HeaderText = "CzyPrawomocny";
            this.czyPrawomocnyDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.czyPrawomocnyDataGridViewCheckBoxColumn.Name = "czyPrawomocnyDataGridViewCheckBoxColumn";
            this.czyPrawomocnyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.czyPrawomocnyDataGridViewCheckBoxColumn.Width = 125;
            // 
            // zakladKarnyDataGridViewTextBoxColumn
            // 
            this.zakladKarnyDataGridViewTextBoxColumn.DataPropertyName = "ZakladKarny";
            this.zakladKarnyDataGridViewTextBoxColumn.HeaderText = "ZakladKarny";
            this.zakladKarnyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zakladKarnyDataGridViewTextBoxColumn.Name = "zakladKarnyDataGridViewTextBoxColumn";
            this.zakladKarnyDataGridViewTextBoxColumn.ReadOnly = true;
            this.zakladKarnyDataGridViewTextBoxColumn.Width = 125;
            // 
            // czyAktualnieWykonywanyDataGridViewCheckBoxColumn
            // 
            this.czyAktualnieWykonywanyDataGridViewCheckBoxColumn.DataPropertyName = "CzyAktualnieWykonywany";
            this.czyAktualnieWykonywanyDataGridViewCheckBoxColumn.HeaderText = "CzyAktualnieWykonywany";
            this.czyAktualnieWykonywanyDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.czyAktualnieWykonywanyDataGridViewCheckBoxColumn.Name = "czyAktualnieWykonywanyDataGridViewCheckBoxColumn";
            this.czyAktualnieWykonywanyDataGridViewCheckBoxColumn.ReadOnly = true;
            this.czyAktualnieWykonywanyDataGridViewCheckBoxColumn.Width = 125;
            // 
            // dataZakonczeniaDataGridViewTextBoxColumn
            // 
            this.dataZakonczeniaDataGridViewTextBoxColumn.DataPropertyName = "DataZakonczenia";
            this.dataZakonczeniaDataGridViewTextBoxColumn.HeaderText = "DataZakonczenia";
            this.dataZakonczeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataZakonczeniaDataGridViewTextBoxColumn.Name = "dataZakonczeniaDataGridViewTextBoxColumn";
            this.dataZakonczeniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataZakonczeniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // skazanyIdDataGridViewTextBoxColumn
            // 
            this.skazanyIdDataGridViewTextBoxColumn.DataPropertyName = "SkazanyId";
            this.skazanyIdDataGridViewTextBoxColumn.HeaderText = "SkazanyId";
            this.skazanyIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.skazanyIdDataGridViewTextBoxColumn.Name = "skazanyIdDataGridViewTextBoxColumn";
            this.skazanyIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.skazanyIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // numerSprawyDataGridViewTextBoxColumn
            // 
            this.numerSprawyDataGridViewTextBoxColumn.DataPropertyName = "NumerSprawy";
            this.numerSprawyDataGridViewTextBoxColumn.HeaderText = "NumerSprawy";
            this.numerSprawyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numerSprawyDataGridViewTextBoxColumn.Name = "numerSprawyDataGridViewTextBoxColumn";
            this.numerSprawyDataGridViewTextBoxColumn.ReadOnly = true;
            this.numerSprawyDataGridViewTextBoxColumn.Width = 125;
            // 
            // rodzajPrzestepstwaDataGridViewTextBoxColumn
            // 
            this.rodzajPrzestepstwaDataGridViewTextBoxColumn.DataPropertyName = "RodzajPrzestepstwa";
            this.rodzajPrzestepstwaDataGridViewTextBoxColumn.HeaderText = "RodzajPrzestepstwa";
            this.rodzajPrzestepstwaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rodzajPrzestepstwaDataGridViewTextBoxColumn.Name = "rodzajPrzestepstwaDataGridViewTextBoxColumn";
            this.rodzajPrzestepstwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.rodzajPrzestepstwaDataGridViewTextBoxColumn.Width = 125;
            // 
            // odbywaneWyrokiBindingSource
            // 
            this.odbywaneWyrokiBindingSource.DataMember = "OdbywaneWyroki";
            this.odbywaneWyrokiBindingSource.DataSource = this.projektJIPP4DanielMarkiewiczDataSetBindingSource;
            // 
            // projektJIPP4DanielMarkiewiczDataSetBindingSource
            // 
            this.projektJIPP4DanielMarkiewiczDataSetBindingSource.DataSource = this.projektJIPP4_DanielMarkiewiczDataSet;
            this.projektJIPP4DanielMarkiewiczDataSetBindingSource.Position = 0;
            // 
            // projektJIPP4_DanielMarkiewiczDataSet
            // 
            this.projektJIPP4_DanielMarkiewiczDataSet.DataSetName = "ProjektJIPP4_DanielMarkiewiczDataSet";
            this.projektJIPP4_DanielMarkiewiczDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odbywaneWyrokiTableAdapter
            // 
            this.odbywaneWyrokiTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn,
            this.czyKobietaDataGridViewCheckBoxColumn});
            this.dataGridView2.DataSource = this.osobaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(952, 184);
            this.dataGridView2.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            this.nazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwiskoDataGridViewTextBoxColumn.Width = 125;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            this.imieDataGridViewTextBoxColumn.ReadOnly = true;
            this.imieDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataUrodzeniaDataGridViewTextBoxColumn
            // 
            this.dataUrodzeniaDataGridViewTextBoxColumn.DataPropertyName = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.HeaderText = "DataUrodzenia";
            this.dataUrodzeniaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataUrodzeniaDataGridViewTextBoxColumn.Name = "dataUrodzeniaDataGridViewTextBoxColumn";
            this.dataUrodzeniaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataUrodzeniaDataGridViewTextBoxColumn.Width = 125;
            // 
            // czyKobietaDataGridViewCheckBoxColumn
            // 
            this.czyKobietaDataGridViewCheckBoxColumn.DataPropertyName = "CzyKobieta";
            this.czyKobietaDataGridViewCheckBoxColumn.HeaderText = "CzyKobieta";
            this.czyKobietaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.czyKobietaDataGridViewCheckBoxColumn.Name = "czyKobietaDataGridViewCheckBoxColumn";
            this.czyKobietaDataGridViewCheckBoxColumn.ReadOnly = true;
            this.czyKobietaDataGridViewCheckBoxColumn.Width = 125;
            // 
            // osobaBindingSource
            // 
            this.osobaBindingSource.DataMember = "Osoba";
            this.osobaBindingSource.DataSource = this.projektJIPP4DanielMarkiewiczDataSetBindingSource;
            // 
            // osobaTableAdapter
            // 
            this.osobaTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 467);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(399, 22);
            this.textBoxName.TabIndex = 17;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(12, 528);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(399, 22);
            this.textBoxSurname.TabIndex = 18;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 447);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(33, 17);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Imie";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(12, 508);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(67, 17);
            this.labelSurname.TabIndex = 20;
            this.labelSurname.Text = "Nazwisko";
            // 
            // eclipseExitSearchFormButton
            // 
            this.eclipseExitSearchFormButton.BackColor = System.Drawing.Color.Red;
            this.eclipseExitSearchFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseExitSearchFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseExitSearchFormButton.Location = new System.Drawing.Point(703, 559);
            this.eclipseExitSearchFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseExitSearchFormButton.Name = "eclipseExitSearchFormButton";
            this.eclipseExitSearchFormButton.Size = new System.Drawing.Size(252, 90);
            this.eclipseExitSearchFormButton.TabIndex = 14;
            this.eclipseExitSearchFormButton.Text = "Zakończ wyszukiwanie";
            this.eclipseExitSearchFormButton.UseVisualStyleBackColor = false;
            this.eclipseExitSearchFormButton.Click += new System.EventHandler(this.eclipseExitSearchFormButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(968, 662);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.eclipseExitSearchFormButton);
            this.Name = "SearchForm";
            this.Text = "Wyszukaj";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odbywaneWyrokiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4DanielMarkiewiczDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4_DanielMarkiewiczDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EclipseButton eclipseExitSearchFormButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource projektJIPP4DanielMarkiewiczDataSetBindingSource;
        private ProjektJIPP4_DanielMarkiewiczDataSet projektJIPP4_DanielMarkiewiczDataSet;
        private System.Windows.Forms.BindingSource odbywaneWyrokiBindingSource;
        private ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OdbywaneWyrokiTableAdapter odbywaneWyrokiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataWyrokuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn czasOdsiadkiMiesiaceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn czyPrawomocnyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakladKarnyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn czyAktualnieWykonywanyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZakonczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skazanyIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerSprawyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajPrzestepstwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OsobaTableAdapter osobaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn czyKobietaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
    }
}