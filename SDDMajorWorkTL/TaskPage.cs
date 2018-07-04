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
    public partial class Task_Page : Form
    {
        TextBox[] SubjectNameArray { get; set; }
        List<string> DatatableSubjectNameArray { get; set; }
        int NumOfSubjects { get; set; }
        TextBox[,] weightages;
        TextBox[,] marks;

        /*Starts the Task Page function*/
        public Task_Page(TextBox[] SubjectNameArray1, List<string> DatatableSubjectNameArrayFromSubjectPage, int NumOfSubjectsFromSubjectPage)
        {
            InitializeComponent();
            SubjectNameArray = SubjectNameArray1;
            DatatableSubjectNameArray = DatatableSubjectNameArrayFromSubjectPage;
            NumOfSubjects = NumOfSubjectsFromSubjectPage;

            NumOfTasks.SelectedIndexChanged += (sender2, e2) => NumOfTasks_SelectedIndexChanged(sender2, e2, SubjectNameArray, DatatableSubjectNameArray, NumOfSubjects);
            TaskPageNextBtn.Click += (sender3, e3) => TaskPageNextBtn_Click(sender3, e3);

            this.NumOfTasks.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /*Hides the Task Page and shows the subject page*/
        private void TaskPageBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var SubjectPage = new SubjectPage();
            SubjectPage.Closed += (s, args) => this.Close();
            SubjectPage.Show();
            SubjectPage.StartPosition = FormStartPosition.Manual;
            SubjectPage.Location = new Point(this.Location.X, this.Location.Y);
        }

        private void TaskPageNextBtn_Click(object sender, EventArgs e)
        {
            NumOfTasks.Enabled = false;
            int NumberOfTasks = NumOfTasks.SelectedIndex + 2;

            var EmptyErrorMsg = false;
            var TotalWeightageMsg = false;
            var TotalPercentageageMsg = false;

            for (int i = 0; i < NumOfSubjects; i++)
            {
                double SubjectWeightage = 0;

                for (int j = 0; j < NumberOfTasks; j++)
                {
                    double parsedValue;
                    if (!double.TryParse(weightages[j, i].Text, out parsedValue) || !double.TryParse(marks[j, i].Text, out parsedValue))
                    {
                        MessageBox.Show("This is a number only field", "Error Message");
                        return;
                    }

                    if (weightages[j, i].Text.Trim() == string.Empty || marks[j, i].Text.Trim() == string.Empty)
                    {
                        EmptyErrorMsg = true;
                        i = NumOfSubjects;
                        break;
                    }

                    if (Convert.ToDouble(weightages[j, i].Text) < 0 || Convert.ToDouble(weightages[j, i].Text) > 1)
                    {
                        TotalWeightageMsg = true;
                        i = NumOfSubjects;
                        break;
                    }

                    if (Convert.ToDouble(marks[j, i].Text) < 0 || Convert.ToDouble(marks[j, i].Text) > 100)
                    {
                        TotalPercentageageMsg = true;
                        i = NumOfSubjects;
                        break;
                    }

                    SubjectWeightage += Convert.ToDouble(weightages[j, i].Text);
                }

                if (SubjectWeightage != Convert.ToDouble(1))
                {
                    TotalWeightageMsg = true;
                    break;
                }
            }

            if (EmptyErrorMsg == true)
            {
                MessageBox.Show("Please fill out all textboxes or select a valid input.", "Error Message");
                return;
                /*https://www.codeproject.com/Questions/496674/EmptyplusTextboxplusValidationplusinplusC*/
            }

            if (TotalWeightageMsg == true)
            {
                MessageBox.Show("Please enter a total weightage of 1 for each subject.", "Error Message");
                return;
            }

            if (TotalPercentageageMsg == true)
            {
                MessageBox.Show("Please enter a total percentage of 1 for each task.", "Error Message");
                return;
            }

            /* Marks and Weighting Table */

            DataTable MarksWeightingRecordDataTable = new DataTable();
            MarksWeightingRecordDataTable.Clear();

            foreach (string DatatableSubjectName in DatatableSubjectNameArray)
            {
                MarksWeightingRecordDataTable.Columns.Add(DatatableSubjectName);
            }

            for (int i = 0; i < NumberOfTasks; i += 1)
            {
                DataRow newRow = MarksWeightingRecordDataTable.NewRow();

                for (int j = 0, k = 0; k < NumOfSubjects; j += 2, k++)
                {
                    newRow[j] = weightages[i, k].Text;
                    newRow[j + 1] = marks[i, k].Text;
                }

                MarksWeightingRecordDataTable.Rows.Add(newRow);
            }

            double[] Subjectmarks = new double[NumOfSubjects];
            for (int i = 0; i < NumOfSubjects; i += 1)
            {
                double sum = 0;
                for (int k = 0; k < NumberOfTasks; k++)
                {
                    double temp = Convert.ToDouble(weightages[k, i].Text) * Convert.ToDouble(marks[k, i].Text);
                    sum += temp;
                }

                Subjectmarks[i] = sum;
            }

            double totalMarks = 0;
            for (int i = 0; i < NumOfSubjects; i++)
            {
                totalMarks += Subjectmarks[i];
            }

            totalMarks /= NumOfSubjects;

            this.Hide();
            var MarksandWeightingTable = new Marks_and_Weighting_Table(SubjectNameArray, DatatableSubjectNameArray, NumOfSubjects, MarksWeightingRecordDataTable, Subjectmarks, totalMarks);
            MarksandWeightingTable.Closed += (s, args) => this.Close();
            MarksandWeightingTable.Show();
            MarksandWeightingTable.StartPosition = FormStartPosition.Manual;
            MarksandWeightingTable.Location = new Point(this.Location.X, this.Location.Y);
        }

        private void NumOfTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumOfTasks_SelectedIndexChanged(object sender, EventArgs e, TextBox[] SubjectNameArray, List<string> datatablesubjectnamearray, int NumOfSubjects)
        {
            NumOfTasks.Enabled = false;
            int NumberOfTasks = NumOfTasks.SelectedIndex + 2;

            LblWeightingTask.Show();

            Label[] SubjectNamesW = new Label[NumOfSubjects];
            Font defaultFont = SystemFonts.DefaultFont;

            for (int i = 0; i < NumOfSubjects; i++)
            {
                SubjectNamesW[i] = new Label();
            }

            int LeftDistance = 25;

            for (int i = 0; i < NumOfSubjects; i++)
            {
                this.Controls.Add(SubjectNamesW[i]);
                SubjectNamesW[i].Top = -10 * 25;
                SubjectNamesW[i].Left = LeftDistance;
                SubjectNamesW[i].BringToFront();
                SubjectNamesW[i].Text = SubjectNameArray[i].Text;
                SubjectNamesW[i].Font = new Font(defaultFont.FontFamily, defaultFont.Size, FontStyle.Bold);
                LeftDistance += 130;
            }

            Label[] SubjectNamesM = new Label[NumOfSubjects];

            for (int i = 0; i < NumOfSubjects; i++)
            {
                SubjectNamesM[i] = new Label();
            }

            LeftDistance = 25;

            for (int i = 0; i < NumOfSubjects; i++)
            {
                this.Controls.Add(SubjectNamesM[i]);
                SubjectNamesM[i].Top = 6 * 25;
                SubjectNamesM[i].Left = LeftDistance;
                SubjectNamesM[i].BringToFront();
                SubjectNamesM[i].Text = SubjectNameArray[i].Text;
                SubjectNamesM[i].Font = new Font(defaultFont.FontFamily, defaultFont.Size, FontStyle.Bold);
                LeftDistance += 130;
            }

            weightages = new TextBox[NumberOfTasks, NumOfSubjects];

            for (int i = 0; i < NumberOfTasks; i++)
            {
                for (int j = 0; j < NumOfSubjects; j++)
                {
                    weightages[i, j] = new TextBox();
                }
            }

            LeftDistance = 25;
            for (int i = 0; i < NumOfSubjects; i++)
            {
                int leftc = -9;
                for (int j = 0; j < NumberOfTasks; j++)
                {
                    this.Controls.Add(weightages[j, i]);
                    weightages[j, i].Top = leftc * 25;
                    weightages[j, i].Left = LeftDistance;
                    weightages[j, i].BringToFront();
                    leftc = leftc + 2;
                }

                LeftDistance += 130;
            }

            LblMarksTask.Show();

            marks = new TextBox[NumberOfTasks, NumOfSubjects];

            for (int i = 0; i < NumberOfTasks; i++)
            {
                for (int j = 0; j < NumOfSubjects; j++)
                {
                    marks[i, j] = new TextBox();
                }
            }

            LeftDistance = 25;
            for (int i = 0; i < NumOfSubjects; i++)
            {
                int leftc = 7;
                for (int j = 0; j < NumberOfTasks; j++)
                {
                    this.Controls.Add(marks[j, i]);
                    marks[j, i].Top = leftc * 25;
                    marks[j, i].Left = LeftDistance;
                    marks[j, i].BringToFront();
                    leftc = leftc + 2;
                }

                LeftDistance += 130;
            }
        }
    }
}


