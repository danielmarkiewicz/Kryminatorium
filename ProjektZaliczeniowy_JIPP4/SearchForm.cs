using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektZaliczeniowy_JIPP4
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
          
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            osobaTableAdapter.FillByPersonNameSurname(projektJIPP4_DanielMarkiewiczDataSet.Osoba, textBoxName.Text,
                textBoxSurname.Text);
            
            odbywaneWyrokiTableAdapter.FillByPersonExecute(projektJIPP4_DanielMarkiewiczDataSet.OdbywaneWyroki, textBoxName.Text,
                textBoxSurname.Text);
        }

        private void eclipseExitSearchFormButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zakończyć wyszukiwanie?", "Zamykanie wyszukiwarki", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                MainFormKartoteka mainFormKartoteka = new MainFormKartoteka();
                mainFormKartoteka.Show();
            }

        }
    }
}
