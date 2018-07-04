using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDDMajorWorkTL
{
    public partial class SubjectPage : Form
    {
        /*starts the subjectpage function*/
        public SubjectPage()
        {
            InitializeComponent();
            this.ComboBoxNumOfSubjects.DropDownStyle = ComboBoxStyle.DropDownList;
        }
  
        /*allows the user to select the number of subjects they do and shows the textboxes for the subject name accordingly*/
        private void ComboBoxNumOfSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxNumOfSubjects.Enabled = false;
            NameOfSubjectQuestion.Visible = true;
            if (ComboBoxNumOfSubjects.SelectedIndex == 0)
            {
                /*https://stackoverflow.com/questions/14250082/making-text-box-visible-unvisible-c-sharp?rq=1*/
                SubjectName1.Visible = true;
                SubjectName2.Visible = true;
                SubjectName3.Visible = false;
                SubjectName4.Visible = false;
                SubjectName5.Visible = false;
                SubjectName6.Visible = false;
                
            }
            else if (ComboBoxNumOfSubjects.SelectedIndex == 1)
            {
                SubjectName1.Visible = true;
                SubjectName2.Visible = true;
                SubjectName3.Visible = true;
                SubjectName4.Visible = false;
                SubjectName5.Visible = false;
                SubjectName6.Visible = false;
                

            }
            else if (ComboBoxNumOfSubjects.SelectedIndex == 2)
            {
                SubjectName1.Visible = true;
                SubjectName2.Visible = true;
                SubjectName3.Visible = true;
                SubjectName4.Visible = true;
                SubjectName5.Visible = false;
                SubjectName6.Visible = false;
               

            }
            else if (ComboBoxNumOfSubjects.SelectedIndex == 3)
            {
                SubjectName1.Visible = true;
                SubjectName2.Visible = true;
                SubjectName3.Visible = true;
                SubjectName4.Visible = true;
                SubjectName5.Visible = true;
                SubjectName6.Visible = false;
                
            }
            else if (ComboBoxNumOfSubjects.SelectedIndex == 4)
            {
                SubjectName1.Visible = true;
                SubjectName2.Visible = true;
                SubjectName3.Visible = true;
                SubjectName4.Visible = true;
                SubjectName5.Visible = true;
                SubjectName6.Visible = true;
              
            }
            

        }






        /*Hides the subject page and shows the menu*/

        private void SubjectPageBackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Menu = new Menu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
            Menu.StartPosition = FormStartPosition.Manual;
            Menu.Location = new Point(this.Location.X, this.Location.Y);
            /*https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form*/
         }

        /*Collects the number of subjects the user does and the name of those subjects. This function also
         displays error messages when the textboxes are empty. This function also creates the datatable column names.
         The function then hides subject page and shows the Task Page.*/
        private void SubjectPageNextBtn_Click(object sender, EventArgs e)
        {

            int NumOfSubjects = ComboBoxNumOfSubjects.SelectedIndex+2;


            List<string> DatatableSubjectNameArray = new List<string>();

            TextBox[] SubjectNameArray = new TextBox[] { SubjectName1, SubjectName2, SubjectName3, SubjectName4, SubjectName5, SubjectName6 };
            int i = 0;
            while (i < NumOfSubjects)
            {
                if (SubjectNameArray[i].Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please fill out all textboxes or select a valid input.", "Error Message");
                    /*https://www.codeproject.com/Questions/496674/EmptyplusTextboxplusValidationplusinplusC*/
                    
                    return;
                }
                i = i + 1;
            }
            i = 0;

            this.Hide();
            var TaskPage = new Task_Page(SubjectNameArray,DatatableSubjectNameArray, NumOfSubjects);
            TaskPage.Closed += (s, args) => this.Close();
            TaskPage.Show();
            TaskPage.StartPosition = FormStartPosition.Manual;
            TaskPage.Location = new Point(this.Location.X, this.Location.Y);

            

            while (i < NumOfSubjects)
            {

                DatatableSubjectNameArray.Add(SubjectNameArray[i].Text + " Weighting");
                DatatableSubjectNameArray.Add(SubjectNameArray[i].Text + " Marks");
                /*http://csharp.net-informations.com/collection/list.htm*/


                i = i + 1;


            }
           
            Task_Page taskpage = new Task_Page(SubjectNameArray, DatatableSubjectNameArray, NumOfSubjects);
            /*https://stackoverflow.com/questions/1559770/send-values-from-one-form-to-another-form*/

        }


    }
}



