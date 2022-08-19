using System;
using System.Drawing;
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
            //utworzenie bitmapy
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
            analogClock.graphics = Graphics.FromImage(analogClock.bitmap);

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] handCrood = new int[2];

            analogClock.graphics.Clear(Color.White);

            analogClock.graphics.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, analogClock.WIDTH, analogClock.HEIGHT);

            analogClock.graphics.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            analogClock.graphics.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            analogClock.graphics.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            analogClock.graphics.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            handCrood = analogClock.miunuteCrood(ss, analogClock.secondHand);
            analogClock.graphics.DrawLine(new Pen(Color.Red, 1f), new Point(analogClock.positionX, analogClock.positionY), new Point(handCrood[0], handCrood[1]));

            handCrood = analogClock.miunuteCrood(mm, analogClock.minuteHand);
            analogClock.graphics.DrawLine(new Pen(Color.Black, 2f), new Point(analogClock.positionX, analogClock.positionY), new Point(handCrood[0], handCrood[1]));

            handCrood = analogClock.hourCrood(hh % 12, mm, analogClock.hourHand);
            analogClock.graphics.DrawLine(new Pen(Color.Gray, 3f), new Point(analogClock.positionX, analogClock.positionY), new Point(handCrood[0], handCrood[1]));

            //
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
            SearchForm search = new SearchForm();
            search.ShowDialog();
            Hide();
        }
    }
}
