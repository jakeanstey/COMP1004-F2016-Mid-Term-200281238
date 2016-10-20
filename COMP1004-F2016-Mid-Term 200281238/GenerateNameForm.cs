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
        /// <summary>
        /// Form constructor
        /// </summary>
        public GenerateNameForm()
        {
            InitializeComponent();
            GenerateNames();
        }

        /// <summary>
        /// Generate random names based on the length of the list of names.
        /// </summary>
        private void GenerateNames()
        {
            Random random = new Random();
            int firstNameRandomNumber = random.Next(0, FirstNameListBox.Items.Count);
            int lastNameRandomNumber = random.Next(0, FirstNameListBox.Items.Count);

            FirstNameTextBox.Text = FirstNameListBox.Items[firstNameRandomNumber].ToString();
            LastNameTextBox.Text = LastNameListBox.Items[lastNameRandomNumber].ToString();
        }

        /// <summary>
        /// Handle the generating of names.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        /// <summary>
        /// Send off to the next form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            abilityGeneratorForm.Show();
            this.Hide();
        }
    }
}
