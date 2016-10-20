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
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Triggers when the timer runs out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            DelayTimer.Dispose(); // get rid of the timer so it doesnt keep opening the generate name form.
            this.Hide();
            GenerateNameForm generateNameForm = new GenerateNameForm();
            generateNameForm.Show();
        }
    }
}
