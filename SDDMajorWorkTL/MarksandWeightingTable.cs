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

namespace SDDMajorWorkTL
{
    public partial class Marks_and_Weighting_Table : Form
    {
        TextBox[] subjectnamearray { get; set; }
        List<string> datatablesubjectnamearray { get; set; }
        int numofsubjects { get; set; }
        DataTable MarksWeightingRecordDataTable { get; set; }
        double[] subjectMarks { get; set; }
        double totalMarks { get; set; }

        /*starts the Marks and Weighting Table function*/
        public Marks_and_Weighting_Table(TextBox[] subjectnamearray1, List<string> datatablesubjectnamearray1, int numofsubjects1, DataTable MarksWeightingRecordDataTable1, double[] subjectMarks1, double totalMarks1)
        {
            InitializeComponent();
            subjectnamearray = subjectnamearray1;
            datatablesubjectnamearray = datatablesubjectnamearray1;
            numofsubjects = numofsubjects1;
            MarksWeightingRecordDataTable = MarksWeightingRecordDataTable1;
            subjectMarks = subjectMarks1;
            totalMarks = totalMarks1;
        }

        /*Hides the Marks and Weighting Table Page and shows the subject page*/
        private void marksandweightingtablepagebackbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SubjectPage = new SubjectPage();
            SubjectPage.Closed += (s, args) => this.Close();
            SubjectPage.Show();
            SubjectPage.StartPosition = FormStartPosition.Manual;
            SubjectPage.Location = new Point(this.Location.X, this.Location.Y);
        }

        /*Hides the Marks and Weighting Table Page and shows the Menu page*/
        private void mainmenubtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Menu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
            Menu.StartPosition = FormStartPosition.Manual;
            Menu.Location = new Point(this.Location.X, this.Location.Y);
        }

        /*Hides the Marks and Weighting Table Page and shows the Total Marks Page*/
        private void marksandweightingtablepagenextbtn_Click(object sender, EventArgs e)
        {
            TotalMarksPage taskpage = new TotalMarksPage(subjectnamearray, datatablesubjectnamearray, numofsubjects, MarksWeightingRecordDataTable, subjectMarks, totalMarks);

            this.Hide();
            var TotalMarksPage = new TotalMarksPage(subjectnamearray, datatablesubjectnamearray, numofsubjects, MarksWeightingRecordDataTable, subjectMarks, totalMarks);
            TotalMarksPage.Closed += (s, args) => this.Close();
            TotalMarksPage.Show();
            TotalMarksPage.StartPosition = FormStartPosition.Manual;
            TotalMarksPage.Location = new Point(this.Location.X, this.Location.Y);
        }


        /*Shows the datatable made from Task Page*/
        private void Marks_and_Weighting_Table_Load(object sender, EventArgs e)
        {
            MarksandWeightingDataTable.DataSource = MarksWeightingRecordDataTable;
            MarksandWeightingDataTable.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            MarksandWeightingDataTable.MultiSelect = true;
            MarksandWeightingDataTable.SelectAll();
        }

        private void copyAlltoClipboard()
        {
            MarksandWeightingDataTable.SelectAll();
            DataObject dataObj = MarksandWeightingDataTable.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        /*https://stackoverflow.com/questions/18182029/how-to-export-datagridview-data-instantly-to-excel-on-button-click*/

        /*private void GenerateExcelSheet()
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range excelCellrange;

            excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = false;

            excel.DisplayAlerts = false;

            excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;

            excelSheet.Name = "Grade Record";

            excelCellrange.EntireColumn.AutoFit();

            Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;

            border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;

            border.Weight = 2d;
        }*/
    }
}
