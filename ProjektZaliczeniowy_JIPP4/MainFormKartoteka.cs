using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjektZaliczeniowy_JIPP4
{
    public partial class MainFormKartoteka : Form
    {
        private Clock analogClock = new Clock();
        
        public MainFormKartoteka()
        {
            InitializeComponent();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            lblDayName.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            analogClock.bitmap = new Bitmap(analogClock.WIDTH + 1, analogClock.HEIGHT + 1);

            //wyśrodkowanie zegara
            analogClock.positionX = analogClock.WIDTH / 2;
            analogClock.positionY = analogClock.HEIGHT / 2;

            //kolor
            analogClock.time.Interval = 1000;
            analogClock.time.Tick += new EventHandler(this.analog_Tick);
            analogClock.time.Start();


            clockDigital.Start();
        }

        private void analog_Tick(object sender, EventArgs e)
        {
            analogClock.analogClock();
            analogClockBox.Image = analogClock.bitmap;
        }

        private void eclipseButtonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Zamykanie Kartoteki", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void eclipseSearchButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm search = new SearchForm();
            search.ShowDialog();
            search = null;
            this.Show();
        }

        private void eclipseAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm = new AddForm();
            addForm.ShowDialog();
            addForm = null;
            this.Show();
        }

        private void eclipseEditButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditForm editForm = new EditForm();
            editForm.ShowDialog();
            editForm = null;
            this.Show();
        }
    }
}
