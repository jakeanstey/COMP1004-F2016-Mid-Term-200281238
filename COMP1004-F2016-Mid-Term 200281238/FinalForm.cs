/**
* Midterm Exam
* Jake Anstey 200281238
* October 20, 2016
* This app is the start to creating a Dungeons and Dragons game.
*/

using COMP1004_F2016_Mid_Term_200281238.Properties;
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
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }
        private Character _myCharacter;

        /// <summary>
        /// The constructor and the first to load.
        /// </summary>
        public FinalForm()
        {
            InitializeComponent();
            _myCharacter = Program.character;
            FirstNameTextBox.Text = _myCharacter.FirstName;
            LastNameTextBox.Text = _myCharacter.LastName;
            StrengthTextBox.Text = _myCharacter.Strength;
            DexterityTextBox.Text = _myCharacter.Dexterity;
            ConstitutionTextBox.Text = _myCharacter.Constitution;
            IntelligenceTextBox.Text = _myCharacter.Intelligence;
            WisdomTextBox.Text = _myCharacter.Wisdom;
            CharismaTextBox.Text = _myCharacter.Charisma;
            RaceTextBox.Text = _myCharacter.Race;

            RacePictureBox.Image = (Image)Resources.ResourceManager.GetObject(_myCharacter.Race + "_Male");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
