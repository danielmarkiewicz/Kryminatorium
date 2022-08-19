using System;
using System.Windows.Forms;
using ProjektZaliczeniowy_JIPP4.ProjektJIPP4_DanielMarkiewiczDataSetTableAdapters;

namespace ProjektZaliczeniowy_JIPP4
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void eclipseButtonSearchFormExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zakończyć wyszukiwanie?", "Zamykanie wyszukiwania", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                MainFormKartoteka mainFormKartoteka = new MainFormKartoteka();
                mainFormKartoteka.Show();
            }
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.osobaTableAdapter.Fill(this.projektJIPP4_DanielMarkiewiczDataSet.Osoba);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            osobaTableAdapter.FillByName(projektJIPP4_DanielMarkiewiczDataSet.Osoba, textBoxName.Text);
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            osobaTableAdapter.FillBySurname(projektJIPP4_DanielMarkiewiczDataSet.Osoba, textBoxSurname.Text);
        }

        private void textBoxPesel_TextChanged(object sender, EventArgs e)
        {
            osobaTableAdapter.FillByPESEL(projektJIPP4_DanielMarkiewiczDataSet.Osoba, textBoxPesel.Text);
        }
    }
}
