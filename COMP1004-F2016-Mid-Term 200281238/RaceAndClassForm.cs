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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_200281238
{
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;
        private Character _myCharacter;

        /// <summary>
        /// Constructor for the race selector class. 
        /// </summary>
        public RaceAndClassForm()
        {
            InitializeComponent();
            _myCharacter = Program.character;
            if(_myCharacter.Race != null)
            {
                switch (_myCharacter.Race)
                {
                    case "Human":
                        HumanRadioButton.Select();
                        break;
                    case "Elf":
                        ElfRadioButton.Select();
                        break;
                    case "Dwarf":
                        DwarfRadioButton.Select();
                        break;
                    case "Halfling":
                        HalflingRadioButton.Select();
                        break;
                }                        
            }
        }

        /// <summary>
        /// Triggered when the back button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            _myCharacter.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _myCharacter.Race = this._selectedRace;

            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }
    }
}
