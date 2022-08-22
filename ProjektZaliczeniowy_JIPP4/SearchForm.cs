using System;
using System.Windows.Forms;

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
                this.Close();
            }
            
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projektJIPP4_DanielMarkiewiczDataSet.Osoba' . Możesz go przenieść lub usunąć.
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
    }
}
