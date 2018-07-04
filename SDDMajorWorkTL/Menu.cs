using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDDMajorWorkTL
{
    public partial class Menu : Form
    {
        /*starts the menu function*/
        public Menu()
        {
            InitializeComponent();
        }


        /*Hides the menu and opens the subject page*/
        private void StartBtn_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            var SubjectPage = new SubjectPage();
            SubjectPage.Closed += (s, args) => this.Close();
            SubjectPage.Show();
            SubjectPage.StartPosition = FormStartPosition.Manual;
            SubjectPage.Location = new Point(this.Location.X, this.Location.Y);

        }

        /*Hides the menu and opens the Help Page*/
        private void HelpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Help = new Help();
            Help.Closed += (s, args) => this.Close();
            Help.Show();
            Help.StartPosition = FormStartPosition.Manual;
            Help.Location = new Point(this.Location.X, this.Location.Y);
        }

    }
}
