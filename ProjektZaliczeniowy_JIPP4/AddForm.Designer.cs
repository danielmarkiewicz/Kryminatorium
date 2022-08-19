
namespace ProjektZaliczeniowy_JIPP4
{
    partial class AddForm
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
            this.osobaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projektJIPP4_DanielMarkiewiczDataSet = new ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSet();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.ManSexRadioButton = new System.Windows.Forms.RadioButton();
            this.WomanSexRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.projektJIPP4DanielMarkiewiczDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.osobaTableAdapter = new ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OsobaTableAdapter();
            this.eclipseButtonSaveChanges = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseButtonSearchFormExit = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.toolTipTextBox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSex = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUrodzeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.czyKobietaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4_DanielMarkiewiczDataSet)).BeginInit();
            this.groupBoxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4DanielMarkiewiczDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(789, 237);
            this.dataGridView1.TabIndex = 0;
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
            // groupBoxAdd
            // 
            this.groupBoxAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxAdd.Controls.Add(this.ManSexRadioButton);
            this.groupBoxAdd.Controls.Add(this.WomanSexRadioButton);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Controls.Add(this.labelDateOfBirth);
            this.groupBoxAdd.Controls.Add(this.textBoxPESEL);
            this.groupBoxAdd.Controls.Add(this.textBoxDateOfBirth);
            this.groupBoxAdd.Controls.Add(this.labelSurname);
            this.groupBoxAdd.Controls.Add(this.labelName);
            this.groupBoxAdd.Controls.Add(this.textBoxSurname);
            this.groupBoxAdd.Controls.Add(this.textBoxName);
            this.groupBoxAdd.Location = new System.Drawing.Point(12, 264);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(494, 213);
            this.groupBoxAdd.TabIndex = 1;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Dodawanie ";
            // 
            // ManSexRadioButton
            // 
            this.ManSexRadioButton.AutoSize = true;
            this.ManSexRadioButton.Location = new System.Drawing.Point(74, 183);
            this.ManSexRadioButton.Name = "ManSexRadioButton";
            this.ManSexRadioButton.Size = new System.Drawing.Size(78, 17);
            this.ManSexRadioButton.TabIndex = 32;
            this.ManSexRadioButton.TabStop = true;
            this.ManSexRadioButton.Text = "Mężczyzna";
            this.toolTipSex.SetToolTip(this.ManSexRadioButton, "Zaznacz płeć dodawanej osoby");
            this.ManSexRadioButton.UseVisualStyleBackColor = true;
            this.ManSexRadioButton.CheckedChanged += new System.EventHandler(this.ManSexRadioButton_CheckedChanged);
            // 
            // WomanSexRadioButton
            // 
            this.WomanSexRadioButton.AutoSize = true;
            this.WomanSexRadioButton.Location = new System.Drawing.Point(7, 183);
            this.WomanSexRadioButton.Name = "WomanSexRadioButton";
            this.WomanSexRadioButton.Size = new System.Drawing.Size(61, 17);
            this.WomanSexRadioButton.TabIndex = 31;
            this.WomanSexRadioButton.TabStop = true;
            this.WomanSexRadioButton.Text = "Kobieta";
            this.toolTipSex.SetToolTip(this.WomanSexRadioButton, "Zaznacz płeć dodawanej osoby");
            this.WomanSexRadioButton.UseVisualStyleBackColor = true;
            this.WomanSexRadioButton.CheckedChanged += new System.EventHandler(this.WomanSexRadioButton_CheckedChanged);
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
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(6, 149);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(482, 20);
            this.textBoxPESEL.TabIndex = 28;
            this.toolTipTextBox.SetToolTip(this.textBoxPESEL, "Wpisz numer PESEL osoby, którą chcesz dodać");
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(6, 110);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(482, 20);
            this.textBoxDateOfBirth.TabIndex = 27;
            this.toolTipTextBox.SetToolTip(this.textBoxDateOfBirth, "Wpisz datę urodzenia osoby (format: DD.MM.RRRR)");
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
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(6, 71);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(482, 20);
            this.textBoxSurname.TabIndex = 24;
            this.toolTipTextBox.SetToolTip(this.textBoxSurname, "Wpisz nazwisko osoby, którą chcesz dodać");
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(482, 20);
            this.textBoxName.TabIndex = 23;
            this.toolTipTextBox.SetToolTip(this.textBoxName, "Wpisz imię osoby, którą chcesz dodać");
            // 
            // projektJIPP4DanielMarkiewiczDataSetBindingSource
            // 
            this.projektJIPP4DanielMarkiewiczDataSetBindingSource.DataSource = this.projektJIPP4_DanielMarkiewiczDataSet;
            this.projektJIPP4DanielMarkiewiczDataSetBindingSource.Position = 0;
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
            this.eclipseButtonSaveChanges.Location = new System.Drawing.Point(548, 264);
            this.eclipseButtonSaveChanges.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseButtonSaveChanges.Name = "eclipseButtonSaveChanges";
            this.eclipseButtonSaveChanges.Size = new System.Drawing.Size(252, 90);
            this.eclipseButtonSaveChanges.TabIndex = 20;
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
            this.eclipseButtonSearchFormExit.Location = new System.Drawing.Point(549, 374);
            this.eclipseButtonSearchFormExit.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseButtonSearchFormExit.Name = "eclipseButtonSearchFormExit";
            this.eclipseButtonSearchFormExit.Size = new System.Drawing.Size(252, 90);
            this.eclipseButtonSearchFormExit.TabIndex = 19;
            this.eclipseButtonSearchFormExit.Text = "Zakończ dodawanie";
            this.toolTipButton.SetToolTip(this.eclipseButtonSearchFormExit, "Aby zakończyć wybierz tą opcję");
            this.eclipseButtonSearchFormExit.UseVisualStyleBackColor = false;
            this.eclipseButtonSearchFormExit.Click += new System.EventHandler(this.eclipseButtonSearchFormExit_Click);
            // 
            // toolTipTextBox
            // 
            this.toolTipTextBox.AutomaticDelay = 100;
            // 
            // toolTipSex
            // 
            this.toolTipSex.AutomaticDelay = 100;
            // 
            // toolTipButton
            // 
            this.toolTipButton.AutomaticDelay = 100;
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
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(813, 488);
            this.ControlBox = false;
            this.Controls.Add(this.eclipseButtonSaveChanges);
            this.Controls.Add(this.eclipseButtonSearchFormExit);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osobaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4_DanielMarkiewiczDataSet)).EndInit();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projektJIPP4DanielMarkiewiczDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource projektJIPP4DanielMarkiewiczDataSetBindingSource;
        private ProjektJIPP4_DanielMarkiewiczDataSet projektJIPP4_DanielMarkiewiczDataSet;
        private System.Windows.Forms.BindingSource osobaBindingSource;
        private ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters.OsobaTableAdapter osobaTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.RadioButton ManSexRadioButton;
        private System.Windows.Forms.RadioButton WomanSexRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private EclipseButton eclipseButtonSearchFormExit;
        private EclipseButton eclipseButtonSaveChanges;
        private System.Windows.Forms.ToolTip toolTipSex;
        private System.Windows.Forms.ToolTip toolTipTextBox;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUrodzeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn czyKobietaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plecDataGridViewTextBoxColumn;
    }
}