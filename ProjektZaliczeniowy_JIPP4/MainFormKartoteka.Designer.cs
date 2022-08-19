
namespace ProjektZaliczeniowy_JIPP4
{
    partial class MainFormKartoteka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.clockDigital = new System.Windows.Forms.Timer(this.components);
            this.lblDayName = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.analogClockBox = new System.Windows.Forms.PictureBox();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.eclipseEditButton = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseDeleteButton = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseButtonExit = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseAddButton = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseSearchButton = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.panelButton.SuspendLayout();
            this.panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.analogClockBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(16, 273);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(285, 45);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "22:15.34";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(16, 334);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(285, 45);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "01.08.2022";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockDigital
            // 
            this.clockDigital.Interval = 1000;
            this.clockDigital.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // lblDayName
            // 
            this.lblDayName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDayName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDayName.Font = new System.Drawing.Font("Microsoft Tai Le", 18F);
            this.lblDayName.Location = new System.Drawing.Point(16, 396);
            this.lblDayName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDayName.Name = "lblDayName";
            this.lblDayName.Size = new System.Drawing.Size(285, 45);
            this.lblDayName.TabIndex = 8;
            this.lblDayName.Text = "PONIEDZIAŁEK";
            this.lblDayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.eclipseEditButton);
            this.panelButton.Controls.Add(this.eclipseDeleteButton);
            this.panelButton.Controls.Add(this.eclipseButtonExit);
            this.panelButton.Controls.Add(this.eclipseAddButton);
            this.panelButton.Controls.Add(this.eclipseSearchButton);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Margin = new System.Windows.Forms.Padding(4);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(287, 622);
            this.panelButton.TabIndex = 14;
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.analogClockBox);
            this.panelTime.Controls.Add(this.lblDayName);
            this.panelTime.Controls.Add(this.lblDate);
            this.panelTime.Controls.Add(this.lblTime);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTime.Location = new System.Drawing.Point(287, 0);
            this.panelTime.Margin = new System.Windows.Forms.Padding(4);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(317, 622);
            this.panelTime.TabIndex = 15;
            // 
            // analogClockBox
            // 
            this.analogClockBox.Location = new System.Drawing.Point(16, 15);
            this.analogClockBox.Margin = new System.Windows.Forms.Padding(4);
            this.analogClockBox.Name = "analogClockBox";
            this.analogClockBox.Size = new System.Drawing.Size(285, 244);
            this.analogClockBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.analogClockBox.TabIndex = 9;
            this.analogClockBox.TabStop = false;
            // 
            // eclipseEditButton
            // 
            this.eclipseEditButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eclipseEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseEditButton.Location = new System.Drawing.Point(16, 311);
            this.eclipseEditButton.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseEditButton.Name = "eclipseEditButton";
            this.eclipseEditButton.Size = new System.Drawing.Size(252, 90);
            this.eclipseEditButton.TabIndex = 12;
            this.eclipseEditButton.Text = "Edytuj";
            this.toolTipButton.SetToolTip(this.eclipseEditButton, "Edytowanie danych w bazie Kartoteka");
            this.eclipseEditButton.UseVisualStyleBackColor = false;
            // 
            // eclipseDeleteButton
            // 
            this.eclipseDeleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eclipseDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseDeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseDeleteButton.Location = new System.Drawing.Point(16, 214);
            this.eclipseDeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseDeleteButton.Name = "eclipseDeleteButton";
            this.eclipseDeleteButton.Size = new System.Drawing.Size(252, 90);
            this.eclipseDeleteButton.TabIndex = 11;
            this.eclipseDeleteButton.Text = "Usuń";
            this.toolTipButton.SetToolTip(this.eclipseDeleteButton, "Usuwanie danych z bazy Kartoteka");
            this.eclipseDeleteButton.UseVisualStyleBackColor = false;
            // 
            // eclipseButtonExit
            // 
            this.eclipseButtonExit.BackColor = System.Drawing.Color.Red;
            this.eclipseButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseButtonExit.Location = new System.Drawing.Point(16, 519);
            this.eclipseButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseButtonExit.Name = "eclipseButtonExit";
            this.eclipseButtonExit.Size = new System.Drawing.Size(252, 90);
            this.eclipseButtonExit.TabIndex = 13;
            this.eclipseButtonExit.Text = "Zamknij";
            this.toolTipButton.SetToolTip(this.eclipseButtonExit, "Wyłączenie aplikacji Kartoteka");
            this.eclipseButtonExit.UseVisualStyleBackColor = false;
            this.eclipseButtonExit.Click += new System.EventHandler(this.eclipseButtonExit_Click);
            // 
            // eclipseAddButton
            // 
            this.eclipseAddButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eclipseAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseAddButton.Location = new System.Drawing.Point(16, 117);
            this.eclipseAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseAddButton.Name = "eclipseAddButton";
            this.eclipseAddButton.Size = new System.Drawing.Size(252, 90);
            this.eclipseAddButton.TabIndex = 10;
            this.eclipseAddButton.Text = "Dodaj";
            this.toolTipButton.SetToolTip(this.eclipseAddButton, "Dodawanie nowych danych do bazy Kartoteka");
            this.eclipseAddButton.UseVisualStyleBackColor = false;
            this.eclipseAddButton.Click += new System.EventHandler(this.eclipseAddButton_Click);
            // 
            // eclipseSearchButton
            // 
            this.eclipseSearchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eclipseSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseSearchButton.Location = new System.Drawing.Point(16, 20);
            this.eclipseSearchButton.Margin = new System.Windows.Forms.Padding(4);
            this.eclipseSearchButton.Name = "eclipseSearchButton";
            this.eclipseSearchButton.Size = new System.Drawing.Size(252, 90);
            this.eclipseSearchButton.TabIndex = 9;
            this.eclipseSearchButton.Text = "Wyszukaj";
            this.eclipseSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTipButton.SetToolTip(this.eclipseSearchButton, "Wyszukiwanie w bazie danych Kartoteka");
            this.eclipseSearchButton.UseVisualStyleBackColor = false;
            this.eclipseSearchButton.Click += new System.EventHandler(this.eclipseSearchButton_Click);
            // 
            // MainFormKartoteka
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(604, 622);
            this.ControlBox = false;
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.panelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFormKartoteka";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kartoteka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelButton.ResumeLayout(false);
            this.panelTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.analogClockBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer clockDigital;
        private System.Windows.Forms.Label lblDayName;
        private EclipseButton eclipseSearchButton;
        private EclipseButton eclipseAddButton;
        private EclipseButton eclipseDeleteButton;
        private EclipseButton eclipseEditButton;
        private EclipseButton eclipseButtonExit;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.PictureBox analogClockBox;
        private System.Windows.Forms.ToolTip toolTipButton;
    }
}

