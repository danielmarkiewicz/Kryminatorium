using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjektZaliczeniowy_JIPP4
{
    public partial class AddForm : Form
    {
        
        private Person person = new Person();

        public AddForm()
        {
            InitializeComponent();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'projektJIPP4_DanielMarkiewiczDataSet.Osoba' . Możesz go przenieść lub usunąć.
            this.osobaTableAdapter.Fill(this.projektJIPP4_DanielMarkiewiczDataSet.Osoba);

        }

        private void eclipseButtonSearchFormExit_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != "" || textBoxSurname.Text != "" || textBoxDateOfBirth.Text != "" || textBoxPESEL.Text != "")
            {
                if (MessageBox.Show("Czy zapisałeś zmiany?", "Zamykanie dodawania", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("Czy napewo chcesz wyjść?", "Zamykanie dodawania", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void eclipseButtonSaveChanges_Click(object sender, EventArgs e)
        {
            person.Name = textBoxName.Text;
            person.Surname = textBoxSurname.Text;

            if(textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxDateOfBirth.Text == "" || textBoxPESEL.Text == "")
            {
                MessageBox.Show("Uzupełnij pozostałe dane", "Weryfikacja danych", MessageBoxButtons.OK);
            }
            else
            {
                osobaTableAdapter.Insert(textBoxSurname.Text, textBoxName.Text, textBoxDateOfBirth.Text, person.Sex,
                    textBoxPESEL.Text);
                MessageBox.Show($"Pomyślnie dodano osobę do bazy danych {person.Name} {person.Surname}",
                    "Potwierdzenie dodania", MessageBoxButtons.OK);
                this.osobaTableAdapter.FillByIdADD(this.projektJIPP4_DanielMarkiewiczDataSet.Osoba);

                foreach (TextBox textBox in this.groupBoxAdd.Controls.OfType<TextBox>())
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
        }

        private void WomanSexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Sex = true;
        }

        private void ManSexRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            person.Sex = false;
        }
    }
}
