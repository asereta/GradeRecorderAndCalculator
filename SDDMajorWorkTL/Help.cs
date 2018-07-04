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
    public partial class Help : Form
    {
        /*starts the help page function*/
        public Help()
        {
            InitializeComponent();
        }


        /*Hides the help page and shows the menu page*/
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Menu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
            Menu.StartPosition = FormStartPosition.Manual;
            Menu.Location = new Point(this.Location.X, this.Location.Y);
        }

        private void helpinfo_Click(object sender, EventArgs e)
        {

        }


    }
}
