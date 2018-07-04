using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop;

namespace SDDMajorWorkTL
{
    public partial class TotalMarksPage : Form
    {
        TextBox[] subjectnamearray { get; set; }
        List<string> datatablesubjectnamearray { get; set; }
        int numofsubjects { get; set; }
        DataTable MarksWeightingRecordDataTable { get; set; }
        double[] subjectMarks { get; set; }
        double totalMarks { get; set; }

        public TotalMarksPage(TextBox[] subjectnamearray1, List<string> datatablesubjectnamearray1, int numofsubjects1, DataTable MarksWeightingRecordDataTable1, double[] subjectMarks1, double totalMarks1)
        {
            InitializeComponent();
            subjectnamearray = subjectnamearray1;
            datatablesubjectnamearray = datatablesubjectnamearray1;
            numofsubjects = numofsubjects1;
            MarksWeightingRecordDataTable = MarksWeightingRecordDataTable1;
            subjectMarks = subjectMarks1;
            totalMarks = totalMarks1;
            textBox1.Text = Convert.ToString(totalMarks);
            textBox1.Enabled = false;
            this.comboboxsubjectname.DropDownStyle = ComboBoxStyle.DropDownList;
            for (int i = 0; i < 6; i++)
            {
                comboboxsubjectname.Items.Add(subjectnamearray[i].Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MarksandWeightingTable = new Marks_and_Weighting_Table(subjectnamearray, datatablesubjectnamearray, numofsubjects, MarksWeightingRecordDataTable, subjectMarks, totalMarks);
            MarksandWeightingTable.Closed += (s, args) => this.Close();
            MarksandWeightingTable.Show();
            MarksandWeightingTable.StartPosition = FormStartPosition.Manual;
            MarksandWeightingTable.Location = new Point(this.Location.X, this.Location.Y);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Menu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
            Menu.StartPosition = FormStartPosition.Manual;
            Menu.Location = new Point(this.Location.X, this.Location.Y);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboboxsubjectname_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < numofsubjects; i++)
            {
                if (comboboxsubjectname.SelectedIndex >= numofsubjects)
                    textBox2.Text = "";
                if (comboboxsubjectname.SelectedIndex == i)
                    textBox2.Text = Convert.ToString(subjectMarks[i]);
            }
        }

        private void TotalMarksPage_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application oXL;
            Microsoft.Office.Interop.Excel._Workbook oWB;
            Microsoft.Office.Interop.Excel._Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Range oRng;
            object misvalue = System.Reflection.Missing.Value;
            
            {
                //Start Excel and get Application object.
                oXL = new Microsoft.Office.Interop.Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(""));
                oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = subjectnamearray[0].Text;
                oSheet.Cells[1, 2] = subjectnamearray[1].Text;
                oSheet.Cells[1, 3] = subjectnamearray[2].Text;
                oSheet.Cells[1, 4] = subjectnamearray[3].Text;
                oSheet.Cells[1, 5] = subjectnamearray[4].Text;
                oSheet.Cells[1, 6] = subjectnamearray[5].Text;

                //Format A1:D1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "F1").Font.Bold = true;
                oSheet.get_Range("A1", "F1").VerticalAlignment =
                    Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                for (int i = 0; i < numofsubjects; i++)
                {
                    oSheet.Cells[2, i + 1] = subjectMarks[i];
                }

                oSheet.Cells[4, 1] = "Total Marks";
                oSheet.Cells[5, 1] = totalMarks;

                oXL.Visible = true;
                oXL.UserControl = false;
            }
        }
    }
}
