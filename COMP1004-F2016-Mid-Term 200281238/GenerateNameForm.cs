/**
 * Midterm Exam
 * Jake Anstey 200281238
 * October 20, 2016
 * This app is the start to creating a Dungeons and Dragons game.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200281238
{
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
            GenerateNames();
        }

        private void GenerateNames()
        {
            Random random = new Random();
            int firstNameRandomNumber = random.Next(0, FirstNameListBox.Items.Count);
            int lastNameRandomNumber = random.Next(0, FirstNameListBox.Items.Count);

            FirstNameTextBox.Text = FirstNameListBox.Items[firstNameRandomNumber].ToString();
            LastNameTextBox.Text = LastNameListBox.Items[lastNameRandomNumber].ToString();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();
        }
    }
}
