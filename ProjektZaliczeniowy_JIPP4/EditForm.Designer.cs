
namespace ProjektZaliczeniowy_JIPP4
{
    partial class EditForm
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
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektJIPP4_DanielMarkiewiczDataSet = new ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSet();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurnameSearch = new System.Windows.Forms.TextBox();
            this.textBoxNameSearch = new System.Windows.Forms.TextBox();
            this.toolTipSex = new System.Windows.Forms.ToolTip(this.components);
            this.ManSexRadioButton = new System.Windows.Forms.RadioButton();
            this.WomanSexRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyKobietaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osobaTableAdapter = new ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OsobaTableAdapter();
            this.eclipseButtonSaveChanges = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseButtonSearchFormExit = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4_DanielMarkiewiczDataSet)).BeginInit();
            this.groupBoxEdit.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTipButton
            // 
            this.toolTipButton.AutomaticDelay = 100;
            // 
            // toolTipTextBox
            // 
            this.toolTipTextBox.AutomaticDelay = 100;
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "Pesel", true));
            this.textBoxPESEL.Location = new System.Drawing.Point(6, 149);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(482, 20);
            this.textBoxPESEL.TabIndex = 28;
            this.toolTipTextBox.SetToolTip(this.textBoxPESEL, "Tutaj możesz edytować PESEL wyszukanej osoby");
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
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "DataUrodzenia", true));
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(6, 110);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(482, 20);
            this.textBoxDateOfBirth.TabIndex = 27;
            this.toolTipTextBox.SetToolTip(this.textBoxDateOfBirth, "Tutaj możesz edytować datę urodzenia wyszukanej osoby");
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "Nazwisko", true));
            this.textBoxSurname.Location = new System.Drawing.Point(6, 71);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(482, 20);
            this.textBoxSurname.TabIndex = 24;
            this.toolTipTextBox.SetToolTip(this.textBoxSurname, "Tutaj możesz edytować nazwisko wyszukanej osoby");
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "Imie", true));
            this.textBoxName.Location = new System.Drawing.Point(6, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(482, 20);
            this.textBoxName.TabIndex = 23;
            this.toolTipTextBox.SetToolTip(this.textBoxName, "Tutaj możesz edytować imię wyszukanej osoby");
            // 
            // textBoxSurnameSearch
            // 
            this.textBoxSurnameSearch.Location = new System.Drawing.Point(4, 97);
            this.textBoxSurnameSearch.Name = "textBoxSurnameSearch";
            this.textBoxSurnameSearch.Size = new System.Drawing.Size(482, 20);
            this.textBoxSurnameSearch.TabIndex = 24;
            this.toolTipTextBox.SetToolTip(this.textBoxSurnameSearch, "Wpisz nazwisko wyszukiwanej osoby, którą chcesz edytować");
            this.textBoxSurnameSearch.TextChanged += new System.EventHandler(this.textBoxSurnameEdit_TextChanged);
            // 
            // textBoxNameSearch
            // 
            this.textBoxNameSearch.Location = new System.Drawing.Point(4, 58);
            this.textBoxNameSearch.Name = "textBoxNameSearch";
            this.textBoxNameSearch.Size = new System.Drawing.Size(482, 20);
            this.textBoxNameSearch.TabIndex = 23;
            this.toolTipTextBox.SetToolTip(this.textBoxNameSearch, "Wpisz imię wyszukiwanej osoby, którą chcesz edytować");
            this.textBoxNameSearch.TextChanged += new System.EventHandler(this.textBoxNameSearch_TextChanged);
            // 
            // toolTipSex
            // 
            this.toolTipSex.AutomaticDelay = 100;
            // 
            // ManSexRadioButton
            // 
            this.ManSexRadioButton.AutoSize = true;
            this.ManSexRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.osobaBindingSource, "CzyKobieta", true));
            this.ManSexRadioButton.Location = new System.Drawing.Point(74, 183);
            this.ManSexRadioButton.Name = "ManSexRadioButton";
            this.ManSexRadioButton.Size = new System.Drawing.Size(78, 17);
            this.ManSexRadioButton.TabIndex = 32;
            this.ManSexRadioButton.TabStop = true;
            this.ManSexRadioButton.Text = "Mężczyzna";
            this.toolTipSex.SetToolTip(this.ManSexRadioButton, "Zaznacz jeżeli chcesz zmienić płeć wyszukanej osoby ");
            this.ManSexRadioButton.UseVisualStyleBackColor = true;
            // 
            // WomanSexRadioButton
            // 
            this.WomanSexRadioButton.AutoSize = true;
            this.WomanSexRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.osobaBindingSource, "CzyKobieta", true));
            this.WomanSexRadioButton.Location = new System.Drawing.Point(7, 183);
            this.WomanSexRadioButton.Name = "WomanSexRadioButton";
            this.WomanSexRadioButton.Size = new System.Drawing.Size(61, 17);
            this.WomanSexRadioButton.TabIndex = 31;
            this.WomanSexRadioButton.TabStop = true;
            this.WomanSexRadioButton.Text = "Kobieta";
            this.toolTipSex.SetToolTip(this.WomanSexRadioButton, "Zaznacz jeżeli chcesz zmienić płeć wyszukanej osoby ");
            this.WomanSexRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxEdit.Controls.Add(this.ManSexRadioButton);
            this.groupBoxEdit.Controls.Add(this.WomanSexRadioButton);
            this.groupBoxEdit.Controls.Add(this.label1);
            this.groupBoxEdit.Controls.Add(this.labelDateOfBirth);
            this.groupBoxEdit.Controls.Add(this.textBoxPESEL);
            this.groupBoxEdit.Controls.Add(this.textBoxDateOfBirth);
            this.groupBoxEdit.Controls.Add(this.labelSurname);
            this.groupBoxEdit.Controls.Add(this.labelName);
            this.groupBoxEdit.Controls.Add(this.textBoxSurname);
            this.groupBoxEdit.Controls.Add(this.textBoxName);
            this.groupBoxEdit.Location = new System.Drawing.Point(12, 389);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(494, 213);
            this.groupBoxEdit.TabIndex = 22;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edycja danych";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Wpisz pesel";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(6, 94);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(109, 13);
            this.labelDateOfBirth.TabIndex = 29;
            this.labelDateOfBirth.Text = "Wpisz datę urodzenia";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(6, 55);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(85, 13);
            this.labelSurname.TabIndex = 26;
            this.labelSurname.Text = "Wpisz Nazwisko";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 13);
            this.labelName.TabIndex = 25;
            this.labelName.Text = "Wpisz Imię";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSearch.Controls.Add(this.labelID);
            this.groupBoxSearch.Controls.Add(this.textBoxID);
            this.groupBoxSearch.Controls.Add(this.label2);
            this.groupBoxSearch.Controls.Add(this.label3);
            this.groupBoxSearch.Controls.Add(this.textBoxSurnameSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxNameSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 256);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(494, 127);
            this.groupBoxSearch.TabIndex = 25;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Wyszukiwanie";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(6, 22);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 27;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.osobaBindingSource, "Id", true));
            this.textBoxID.Location = new System.Drawing.Point(30, 19);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(43, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Wpisz Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Wpisz Imię";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.dataUrodzeniaDataGridViewTextBoxColumn,
            this.czyKobietaDataGridViewCheckBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.plecDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.osobaBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 8);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(789, 241);
            this.dataGridView.TabIndex = 26;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            // osobaTableAdapter
            // 
            this.osobaTableAdapter.ClearBeforeFill = true;
            // 
            // eclipseButtonSaveChanges
            // 
            this.eclipseButtonSaveChanges.BackColor = System.Drawing.Color.Lime;
            this.eclipseButtonSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseButtonSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseButtonSaveChanges.Location = new System.Drawing.Point(548, 376);
            this.eclipseButtonSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseButtonSaveChanges.Name = "eclipseButtonSaveChanges";
            this.eclipseButtonSaveChanges.Size = new System.Drawing.Size(252, 90);
            this.eclipseButtonSaveChanges.TabIndex = 24;
            this.eclipseButtonSaveChanges.Text = "Zapisz zmiany";
            this.toolTipButton.SetToolTip(this.eclipseButtonSaveChanges, "W celu zapisania danych wybierz tą opcję");
            this.eclipseButtonSaveChanges.UseVisualStyleBackColor = false;
            this.eclipseButtonSaveChanges.Click += new System.EventHandler(this.eclipseButtonSaveChanges_Click);
            // 
            // eclipseButtonSearchFormExit
            // 
            this.eclipseButtonSearchFormExit.BackColor = System.Drawing.Color.Red;
            this.eclipseButtonSearchFormExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseButtonSearchFormExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseButtonSearchFormExit.Location = new System.Drawing.Point(549, 486);
            this.eclipseButtonSearchFormExit.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseButtonSearchFormExit.Name = "eclipseButtonSearchFormExit";
            this.eclipseButtonSearchFormExit.Size = new System.Drawing.Size(252, 90);
            this.eclipseButtonSearchFormExit.TabIndex = 23;
            this.eclipseButtonSearchFormExit.Text = "Zakończ edycję";
            this.toolTipButton.SetToolTip(this.eclipseButtonSearchFormExit, "Aby zakończyć wybierz tą opcję");
            this.eclipseButtonSearchFormExit.UseVisualStyleBackColor = false;
            this.eclipseButtonSearchFormExit.Click += new System.EventHandler(this.eclipseButtonSearchFormExit_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(813, 608);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.eclipseButtonSaveChanges);
            this.Controls.Add(this.eclipseButtonSearchFormExit);
            this.Controls.Add(this.groupBoxEdit);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4_DanielMarkiewiczDataSet)).EndInit();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipButton;
        private EclipseButton eclipseButtonSaveChanges;
        private EclipseButton eclipseButtonSearchFormExit;
        private System.Windows.Forms.ToolTip toolTipTextBox;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ToolTip toolTipSex;
        private System.Windows.Forms.RadioButton ManSexRadioButton;
        private System.Windows.Forms.RadioButton WomanSexRadioButton;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private ProjektJIPP4_DanielMarkiewiczDataSet projektJIPP4_DanielMarkiewiczDataSet;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OsobaTableAdapter osobaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn czyKobietaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSurnameSearch;
        private System.Windows.Forms.TextBox textBoxNameSearch;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
    }
}