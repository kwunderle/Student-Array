using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayOfStudents___Katharine_Wunderle
{
    //Author: Katharine Wunderle
    //ID: 623748
    //Date: 04/25/2021
    //Goal: Display an array of 5 student names and course grade an average for all
    public partial class studentNameArray : Form
    {
        public studentNameArray()
        {
            InitializeComponent();
        }
        //Constant for array size
        const int CONSTArrayMax = 5;
        //Declare array variables for students and grades
        string[] studentNameArrayStr = new string[CONSTArrayMax];
        decimal[] courseGradeArrayDec = new decimal[CONSTArrayMax];
        //Array index counter variable
        int arrayIndex = 0;
        private void addStudentToArrayBtn_Click(object sender, EventArgs e)
        {
            //Input validation variable
            bool tryParseBool;
            //Input variables
            string studentName = "";
            decimal courseGrade = 0;

            //Get student name and validate input from user
            if (studentNameTxtBx.Text == "")
            { MessageBox.Show("Error: Please enter the Student's Name.");
                return;
            }
            //Name returned as input
            studentName = studentNameTxtBx.Text;
            //Get course grade and validate input from user
            tryParseBool = decimal.TryParse(courseGradeTxtBx.Text, out courseGrade);
            if (tryParseBool == false || courseGrade > 100)
            { MessageBox.Show("Error: Please enter a valid course grade.");
                return;
            }
            //Stop array when max reached
            if (arrayIndex >= CONSTArrayMax)
            { MessageBox.Show("Array is full, cannot add any more students.");
                return;
            }
            //Assign input to array
            else
            {
                studentNameArrayStr[arrayIndex] = studentName;
                courseGradeArrayDec[arrayIndex] = courseGrade;
            }
            //Clear textboxes upon entering input into array
            studentNameTxtBx.Text = "";
            courseGradeTxtBx.Text = "";
            //Next value in array
            arrayIndex = arrayIndex + 1;
            MessageBox.Show("Student data has been added to Array Index[" + (arrayIndex-1) + "]");
                return;
                
        }

        private void displayArrayBtn_Click(object sender, EventArgs e)
        {
            //Declare variables
            string stringList = "";
            int studentCount = 0;
            decimal totalGrade = 0;
            decimal gradeAverage = 0;

            //Begin array display string
            stringList = "STUDENT DATA ENTERED SO FAR:\n";
            //Concatenate string for each set of input values
            for (int i = 0; i < studentNameArrayStr.Length; i++)
            {
                stringList = stringList + "Array[" + i + "] - " +
                        "Student #" + (i + 1);
                if (courseGradeArrayDec[i] ==0)
                    { stringList = stringList + "     (NOT ENTERED)\n"; }
                else {
                        stringList = stringList + 
                        " Name: " + studentNameArrayStr[i] +
                        "   Grade: " + courseGradeArrayDec[i].ToString("") + "\n";
                    //Count total students entered
                        studentCount++;
                    //Calculate average grade
                    totalGrade = totalGrade + courseGradeArrayDec[i];
                    gradeAverage = totalGrade / studentCount;
                        }

            }
            //Calculate average grade and add to string
            if (studentCount > 0)
            {
                stringList = stringList + "TOTAL STUDENTS: " + studentCount +
                      "   AVERAGE GRADE: " + gradeAverage.ToString("");
            }
            //Display completed string in array label
            studentArrayLbl.Text = stringList;
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            //Clear text boxes and array display
            studentNameTxtBx.Text = "";
            courseGradeTxtBx.Text = "";
            studentArrayLbl.Text = "";
            //Reset array values
            arrayIndex = 0;
            studentNameArrayStr = new string[CONSTArrayMax];
            courseGradeArrayDec = new decimal[CONSTArrayMax];
        }
    }
}
