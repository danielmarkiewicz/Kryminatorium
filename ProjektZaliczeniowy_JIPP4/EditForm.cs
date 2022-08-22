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
    public partial class EditForm : Form
    {
        private Person person = new Person();

        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projektJIPP4_DanielMarkiewiczDataSet.Osoba' . Możesz go przenieść lub usunąć.
            this.osobaTableAdapter.Fill(this.projektJIPP4_DanielMarkiewiczDataSet.Osoba);
        }

        private void textBoxNameSearch_TextChanged(object sender, EventArgs e)
        {
            osobaTableAdapter.FillByName(projektJIPP4_DanielMarkiewiczDataSet.Osoba, textBoxNameSearch.Text);
        }

        private void textBoxSurnameEdit_TextChanged(object sender, EventArgs e)
        {
            osobaTableAdapter.FillBySurname(projektJIPP4_DanielMarkiewiczDataSet.Osoba, textBoxSurnameSearch.Text);
        }

        private void eclipseButtonSaveChanges_Click(object sender, EventArgs e)
        {
            person.Id = Convert.ToInt32(textBoxID.Text);
            person.Name = textBoxName.Text;

            person.ChangedData += (oldData, newData) =>
            {
                if (newData.Length < 1)
                {
                    MessageBox.Show("Podane dane nie spełniają wymagań");
                }
                else if (MessageBox.Show("Czy napewo dokonać edycji danych tej osoby?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    osobaBindingSource.EndEdit();
                    osobaTableAdapter.Update(projektJIPP4_DanielMarkiewiczDataSet);

                    MessageBox.Show($"Pomyślnie zmieniono dane osoby o ID: {person.Id}", "Potwierdzenie edycji", MessageBoxButtons.OK);

                    this.osobaTableAdapter.FillByID(this.projektJIPP4_DanielMarkiewiczDataSet.Osoba, person.Id);

                    if (MessageBox.Show("Czy nowe dane w bazie danych się zgadzają?", "Potwierdzenie", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.osobaTableAdapter.Fill(this.projektJIPP4_DanielMarkiewiczDataSet.Osoba);
                    }

                    foreach (TextBox textBox in this.groupBoxEdit.Controls.OfType<TextBox>())
                    {
                        textBox.Text = null;
                    }

                    foreach (TextBox textBox in this.groupBoxSearch.Controls.OfType<TextBox>())
                    {
                        textBox.Text = null;
                    }

                    if (WomanSexRadioButton.Checked && person.Sex)
                    {
                        WomanSexRadioButton.Checked = false;
                    }
                    else
                    {
                        ManSexRadioButton.Checked = false;
                    }
                
                }
            };
        }

        private void eclipseButtonSearchFormExit_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Czy napewo chcesz wyjść?", "Zamykanie edycji", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
        }
    }
}
