
namespace ProjektZaliczeniowy_JIPP4
{
    partial class Kartoteka
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
            this.eclipseButtonExit = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseButton4 = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseButton3 = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseButton2 = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.eclipseButton1 = new ProjektZaliczeniowy_JIPP4.EclipseButton();
            this.panelButton = new System.Windows.Forms.Panel();
            this.panelTime = new System.Windows.Forms.Panel();
            this.analogClockBox = new System.Windows.Forms.PictureBox();
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
            this.lblTime.Location = new System.Drawing.Point(12, 222);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(214, 37);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "22:15.34";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 271);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(214, 37);
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
            this.lblDayName.Location = new System.Drawing.Point(12, 322);
            this.lblDayName.Name = "lblDayName";
            this.lblDayName.Size = new System.Drawing.Size(214, 37);
            this.lblDayName.TabIndex = 8;
            this.lblDayName.Text = "PONIEDZIAŁEK";
            this.lblDayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eclipseButtonExit
            // 
            this.eclipseButtonExit.BackColor = System.Drawing.Color.Red;
            this.eclipseButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseButtonExit.Location = new System.Drawing.Point(12, 538);
            this.eclipseButtonExit.Name = "eclipseButtonExit";
            this.eclipseButtonExit.Size = new System.Drawing.Size(189, 73);
            this.eclipseButtonExit.TabIndex = 13;
            this.eclipseButtonExit.Text = "Zamknij";
            this.eclipseButtonExit.UseVisualStyleBackColor = false;
            this.eclipseButtonExit.Click += new System.EventHandler(this.eclipseButtonExit_Click);
            // 
            // eclipseButton4
            // 
            this.eclipseButton4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eclipseButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseButton4.Location = new System.Drawing.Point(12, 253);
            this.eclipseButton4.Name = "eclipseButton4";
            this.eclipseButton4.Size = new System.Drawing.Size(189, 73);
            this.eclipseButton4.TabIndex = 12;
            this.eclipseButton4.Text = "Edytuj";
            this.eclipseButton4.UseVisualStyleBackColor = false;
            // 
            // eclipseButton3
            // 
            this.eclipseButton3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eclipseButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseButton3.Location = new System.Drawing.Point(12, 174);
            this.eclipseButton3.Name = "eclipseButton3";
            this.eclipseButton3.Size = new System.Drawing.Size(189, 73);
            this.eclipseButton3.TabIndex = 11;
            this.eclipseButton3.Text = "Usuń";
            this.eclipseButton3.UseVisualStyleBackColor = false;
            // 
            // eclipseButton2
            // 
            this.eclipseButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eclipseButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseButton2.Location = new System.Drawing.Point(12, 95);
            this.eclipseButton2.Name = "eclipseButton2";
            this.eclipseButton2.Size = new System.Drawing.Size(189, 73);
            this.eclipseButton2.TabIndex = 10;
            this.eclipseButton2.Text = "Dodaj";
            this.eclipseButton2.UseVisualStyleBackColor = false;
            // 
            // eclipseButton1
            // 
            this.eclipseButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eclipseButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eclipseButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eclipseButton1.Location = new System.Drawing.Point(12, 16);
            this.eclipseButton1.Name = "eclipseButton1";
            this.eclipseButton1.Size = new System.Drawing.Size(189, 73);
            this.eclipseButton1.TabIndex = 9;
            this.eclipseButton1.Text = "Wyszukaj";
            this.eclipseButton1.UseVisualStyleBackColor = false;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.eclipseButton4);
            this.panelButton.Controls.Add(this.eclipseButton3);
            this.panelButton.Controls.Add(this.eclipseButtonExit);
            this.panelButton.Controls.Add(this.eclipseButton2);
            this.panelButton.Controls.Add(this.eclipseButton1);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButton.Location = new System.Drawing.Point(0, 0);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(215, 623);
            this.panelButton.TabIndex = 14;
            // 
            // panelTime
            // 
            this.panelTime.Controls.Add(this.analogClockBox);
            this.panelTime.Controls.Add(this.lblDayName);
            this.panelTime.Controls.Add(this.lblDate);
            this.panelTime.Controls.Add(this.lblTime);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTime.Location = new System.Drawing.Point(744, 0);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(238, 623);
            this.panelTime.TabIndex = 15;
            // 
            // analogClockBox
            // 
            this.analogClockBox.Location = new System.Drawing.Point(12, 12);
            this.analogClockBox.Name = "analogClockBox";
            this.analogClockBox.Size = new System.Drawing.Size(214, 198);
            this.analogClockBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.analogClockBox.TabIndex = 9;
            this.analogClockBox.TabStop = false;
            // 
            // Kartoteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(982, 623);
            this.Controls.Add(this.panelTime);
            this.Controls.Add(this.panelButton);
            this.Name = "Kartoteka";
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
        private EclipseButton eclipseButton1;
        private EclipseButton eclipseButton2;
        private EclipseButton eclipseButton3;
        private EclipseButton eclipseButton4;
        private EclipseButton eclipseButtonExit;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.PictureBox analogClockBox;
    }
}

