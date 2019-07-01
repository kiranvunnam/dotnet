using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manukonda_Assign3
{
    public partial class NIUAcademicPerformanceQuerySystem : Form
    {
        public NIUAcademicPerformanceQuerySystem()
        {
            InitializeComponent();
            PublicVariables.Input();

            //grades are loaded into the first grade combo box
            gradeCombo.Items.Add("A");
            gradeCombo.Items.Add("A-");
            gradeCombo.Items.Add("B+");
            gradeCombo.Items.Add("B");
            gradeCombo.Items.Add("B-");
            gradeCombo.Items.Add("C++");
            gradeCombo.Items.Add("C");
            gradeCombo.Items.Add("C-");
            gradeCombo.Items.Add("D");
            gradeCombo.Items.Add("F");

            //majors are loaded into major combo box using input file
            using (StreamReader sr = new StreamReader("2188_a3_input03.txt"))
            {
                String department = sr.ReadLine();
                int i = 1;
                while (department != null)
                {
                    majorCombo.Items.Add(department);
                    department = sr.ReadLine();
                    i++;
                }
            }
            //grades are loaded into second grade combo box
                        gradeCombo1.Items.Add("A");
                        gradeCombo1.Items.Add("A-");
                        gradeCombo1.Items.Add("B+");
                        gradeCombo1.Items.Add("B");
                        gradeCombo1.Items.Add("B-");
                        gradeCombo1.Items.Add("C++");
                        gradeCombo1.Items.Add("C");
                        gradeCombo1.Items.Add("C-");
                        gradeCombo1.Items.Add("D");
                        gradeCombo1.Items.Add("F");
        }

        //action to do for grade report of one student
        private void showResults1(object sender, EventArgs e)
        {
            //everytime the method is called output textbox will be cleared
            outputRich.Clear();
            int check = 0;
            String enterzid = zidTextBox.Text;
            if (enterzid != "")
            {
                if (enterzid.Contains("z") || enterzid.Contains("Z"))
                {
                    if (enterzid.Length == 8)
                    {
                        //to trim the 'z' if entered by the user
                        enterzid = enterzid.Trim(new char[] { 'z', 'Z' });
                        check = 1;
                    }
                    else
                    {
                        //to display an error msg to the user
                        outputRich.AppendText("Enter correct Zid.");
                        check = 0;
                    }
                }
                else if (enterzid.Length == 7)
                {
                    check = 1;

                }
                else
                {
                    outputRich.AppendText("Enter correct Zid.");
                    check = 0;
                }
                if (check == 1)
                {
                    //Query to get the grade report for one student
                    var oneQuery = from grade in PublicVariables.gradelist
                                       where grade.z_idPro == Convert.ToUInt32(enterzid)
                                       orderby grade.ccodePro ascending
                                       select new { StudentID = grade.z_idPro, Dept = grade.ccodePro, CourseNumber = grade.sectPro, StudentGrades = grade.gradePro };
                    outputRich.AppendText("Single Student Grade Report  (" + enterzid + ")\n");
                    outputRich.AppendText("----------------------------------------------\n");
                    Console.WriteLine(oneQuery);
                    if (oneQuery.Any())
                    {
                        foreach (var item in oneQuery)
                        {
                            outputRich.AppendText("z" + item.StudentID + "  |  " + item.Dept + "-" + item.CourseNumber + "   |  " + item.StudentGrades + "\n");

                        }
                    }
                    else
                    {
                        outputRich.AppendText("No Results.");
                    }
                    outputRich.AppendText("\n\n### END RESULTS ###");

                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Action to do to get the grade threshold for one course
        private void showResults2(object sender, EventArgs e)
        {
            //To clear the textbox every time the method is called
            outputRich.Clear();
            string entergrade = Convert.ToString(gradeCombo.SelectedItem);
            string entercourse = CourseTextt.Text;
            string[] courAr = entercourse.Split(' ');
            if (entergrade != "" && entercourse != "")
            {
                if (LessThan1.Checked == true)
                {
                    //Query to get the grade threshold for one course
                    var twoQuery = from grade in PublicVariables.gradelist
                                         where Array.IndexOf(PublicVariables.grades,grade.gradePro) >= Array.IndexOf(PublicVariables.grades,entergrade) && grade.ccodePro.CompareTo(courAr[0]) == 0 && grade.sectPro == Convert.ToUInt32(courAr[1])
                                         orderby grade.z_idPro
                                         select new { StudentID = grade.z_idPro, Dept = grade.ccodePro, CourseNumber = grade.sectPro, StudentGrades = grade.gradePro };
                    outputRich.AppendText("Grade Threshold Report for (" + entercourse + ")\n");
                    outputRich.AppendText("----------------------------------------------\n");
                    Console.WriteLine(twoQuery);
                    if (twoQuery.Any())
                    {
                        foreach (var item in twoQuery)
                        {
                            outputRich.AppendText("z" + item.StudentID + "  |  " + item.Dept + "-" + item.CourseNumber + "   |  " + item.StudentGrades + "\n");

                        }
                    }
                    else
                    {
                        outputRich.AppendText("No Results.");
                    }
                    outputRich.AppendText("\n\n### END RESULTS ###");
                }
                else if (greaterthan1.Checked == true)
                {
                    //Query to get the grade threshold for one course
                    var twoQuery = from grade in PublicVariables.gradelist
                                         where Array.IndexOf(PublicVariables.grades, grade.gradePro) <= Array.IndexOf(PublicVariables.grades, entergrade) && grade.ccodePro.CompareTo(courAr[0]) == 0 && grade.sectPro == Convert.ToUInt32(courAr[1])
                                         orderby grade.z_idPro
                                         select new { StudentID = grade.z_idPro, Dept = grade.ccodePro, CourseNumber = grade.sectPro, StudentGrades = grade.gradePro };
                    outputRich.AppendText("Grade Threshold Report for (" + entercourse + ")\n");
                    outputRich.AppendText("----------------------------------------------\n");
                    Console.WriteLine(twoQuery);
                    if (twoQuery.Any())
                    {
                        foreach (var item in twoQuery)
                        {
                            outputRich.AppendText("z" + item.StudentID + "  |  " + item.Dept + "-" + item.CourseNumber + "   |  " + item.StudentGrades + "\n");

                        }
                    }
                    else
                    {
                        outputRich.AppendText("No Results.");
                    }
                    outputRich.AppendText("\n\n### END RESULTS ###");

                }
                else
                    outputRich.AppendText("Please select an option for search criteria");
            }
        }

        //Action to do to find the students failed in a course
        private void showResults3(object sender, EventArgs e)
        {
            Dictionary<string, string> majorDic = new Dictionary<string, string>
            {
                {"Computer Science","CSCI" },
                {"Mathematics","MATH" },
                {"Statistics","STAT" },
                {"Music","MUSE" },
                {"German","FLGL" },
                {"Theater","THEA" },
                {"Art","ART" },
                {"Anthropology","ANTH" },
                {"Psycology","PSYC" },
                {"Marketing","MKTG" },
                {"Physics","PHYS" },
                {"Finance","FINA" },
                {"Economics","ECON" },
                {"Biological Sciences","BIOS" },
                {"Chemistry","CHEM" },
                {"Undecided - Any College","UND" }
            };

            //to clear the output every time the function is called
            outputRich.Clear();
            string entermajor = Convert.ToString(majorCombo.SelectedItem);
            string entercourse = CourseTextm.Text;
            string[] courAr = entercourse.Split(' ');

            if (entermajor != "" && entercourse != "" && courAr[0] == majorDic[entermajor])
            {
                //Query to find the students failed in a course
                var threeQueryfail = from grade in PublicVariables.gradelist
                                where grade.gradePro.CompareTo("F") == 0 && grade.ccodePro.CompareTo(courAr[0]) == 0 && grade.sectPro == Convert.ToUInt32(courAr[1])
                                orderby grade.z_idPro ascending
                                select new { StudentID = grade.z_idPro, Dept = grade.ccodePro, CourseNumber = grade.sectPro, StudentGrades = grade.gradePro };
                outputRich.AppendText("Fail Report 0f Majors (" + entermajor + ") in " + entercourse + "\n");
                outputRich.AppendText("----------------------------------------------\n");
                Console.WriteLine(threeQueryfail);
                if (threeQueryfail.Any())
                {
                    foreach (var item in threeQueryfail)
                    {
                        outputRich.AppendText("z" + item.StudentID + "  |  " + item.Dept + "-" + item.CourseNumber + "   |  " + item.StudentGrades + "\n");

                    }
                }
                else
                {
                    outputRich.AppendText("No Results.");
                }
                outputRich.AppendText("\n\n### END RESULTS ###");

            }
            else
                outputRich.AppendText("Enter correct inputs");
        }

        //Action to do to get the grade report for one course
        private void showResults4(object sender, EventArgs e)
        {
            outputRich.Clear();
            string entercourse = CourseTextr.Text;
            string[] courAr = entercourse.Split(' ');
            if (entercourse != "")
            {
                //Query to find the grade report for onecourse
                var fourQuery = from grade in PublicVariables.gradelist
                                  where grade.ccodePro.CompareTo(courAr[0]) == 0 && grade.sectPro == Convert.ToUInt32(courAr[1])
                                  orderby grade.z_idPro ascending
                                  select new { StudentID = grade.z_idPro, Dept = grade.ccodePro, CourseNumber = grade.sectPro, StudentGrades = grade.gradePro };
                outputRich.AppendText("Grade Report for (" + entercourse + ") \n");
                outputRich.AppendText("----------------------------------------------\n");
                Console.WriteLine(fourQuery);
                if (fourQuery.Any())
                {
                    foreach (var item in fourQuery)
                    {
                        outputRich.AppendText("z" + item.StudentID + "  |  " + item.Dept + "-" + item.CourseNumber + "   |  " + item.StudentGrades + "\n");

                    }
                }
                else
                {
                    outputRich.AppendText("No Results.");
                }
                outputRich.AppendText("\n\n### END RESULTS ###");

            }
        }

        //Action to do to find the fail report for all courses
        private void showResults5(object sender, EventArgs e)
        {
            outputRich.Clear();
            double percentCriteria = Convert.ToDouble(percentageUpDown.Value);
            var fiveQuerycountfail = from grade in PublicVariables.gradelist
                                    where grade.gradePro == "F"
                                    orderby grade.ccodePro, grade.sectPro
                                    group grade by new { grade.ccodePro, grade.sectPro } into gradeGroup
                                    select new { dept = gradeGroup.Key.ccodePro, courseno = gradeGroup.Key.sectPro, failureCount = gradeGroup.Count() };

            var fullQuery = from grade in PublicVariables.gradelist
                             orderby grade.ccodePro, grade.sectPro
                             group grade by new { grade.ccodePro, grade.sectPro } into gradeCountGroup
                             select new { dept = gradeCountGroup.Key.ccodePro, courseno = gradeCountGroup.Key.sectPro, totalCount = gradeCountGroup.Count() };

            int count = 0;
            if (fullQuery.Any() && fiveQuerycountfail.Any())
            {
                if (Lessthan2.Checked == true)
                {
                    count = 0;
                    outputRich.AppendText("Fail Percentage (<= " + percentageUpDown.Value + "%) Report for classes.\n");
                    outputRich.AppendText("---------------------------------------------------------------------\n");
                    foreach (var grade in fullQuery)
                    {
                        foreach (var failgrade in fiveQuerycountfail)
                        {
                            if (grade.dept == failgrade.dept && grade.courseno == failgrade.courseno)
                            {
                                double failcount = Convert.ToDouble(failgrade.failureCount);

                                if (failcount / grade.totalCount <= percentCriteria)
                                {
                                    count++;
                                    outputRich.AppendText("Out of " + grade.totalCount + " enrolled in " + grade.dept + "-" + grade.courseno + ",  " + failgrade.failureCount + "  failed  ( " + String.Format("{0 : 0.00%}", (failcount / grade.totalCount)) + ")\n\n");
                                }

                            }
                        }
                    }
                }

                else if (greaterthan2.Checked == true)
                {
                    count = 0;
                    outputRich.AppendText("Fail Percentage (>= " + percentageUpDown.Value + "%) Report for classes.\n");
                    outputRich.AppendText("---------------------------------------------------------------------\n");
                    foreach (var grade in fullQuery)
                    {
                        foreach (var failgrade in fiveQuerycountfail)
                        {
                            if (grade.dept == failgrade.dept && grade.courseno == failgrade.courseno)
                            {
                                double failcount = Convert.ToDouble(failgrade.failureCount);

                                if ((failcount / grade.totalCount) * 100 >= percentCriteria)
                                {
                                    count++;
                                    outputRich.AppendText("Out of " + grade.totalCount + " enrolled in " + grade.dept + "-" + grade.courseno + ",  " + failgrade.failureCount + "  failed  ( " + String.Format("{0 : 0.00%}", (failcount / grade.totalCount)) + ")\n\n");
                                }

                            }
                        }
                    }
                }
                else
                {
                    outputRich.AppendText("Please choose an option");
                }
            }
            if (count == 0)
            {
                outputRich.AppendText("No courses matched the query criteria\n");
            }

            outputRich.AppendText("\n\n\n### END RESULTS ###");
        }

        //Action to do to find the pass report for all courses
        private void showResults6(object sender, EventArgs e)
        {
            string entergrade = Convert.ToString(gradeCombo1.SelectedItem);
            outputRich.Clear();
            double percentage = Convert.ToDouble(percentageUpDown.Value);

            var totalQuery = from grade in PublicVariables.gradelist
                             orderby grade.ccodePro, grade.sectPro
                             group grade by new { grade.ccodePro, grade.sectPro } into gradeCountGroup
                             select new { dept = gradeCountGroup.Key.ccodePro, courseno = gradeCountGroup.Key.sectPro, totalCount = gradeCountGroup.Count() };

            if (totalQuery.Any())
            {
                if (Lessthan3.Checked == true)
                {
                    var countFailureQuery = from grade in PublicVariables.gradelist
                                            where Array.IndexOf(PublicVariables.grades,grade.gradePro) != 1 && Array.IndexOf(PublicVariables.grades,grade.gradePro) <= Array.IndexOf(PublicVariables.grades,entergrade)
                                            orderby grade.ccodePro, grade.sectPro
                                            group grade by new { grade.ccodePro, grade.sectPro } into gradeGroup
                                            select new { dept = gradeGroup.Key.ccodePro, courseno = gradeGroup.Key.sectPro, failureCount = gradeGroup.Count() };

                    if (countFailureQuery.Any())
                    {
                        outputRich.AppendText("Pass Percentage (<= " + entergrade + "%) Report for classes.\n");
                        outputRich.AppendText("---------------------------------------------------------------------\n");
                        foreach (var grade in totalQuery)
                        {
                            foreach (var failgrade in countFailureQuery)
                            {
                                if (grade.dept == failgrade.dept && grade.courseno == failgrade.courseno)
                                {
                                    double failcount = Convert.ToDouble(failgrade.failureCount);


                                    outputRich.AppendText("Out of " + grade.totalCount + " enrolled in " + grade.dept + "-" + grade.courseno + ",  " + failgrade.failureCount + "  passed at or below this threshold  ( " + String.Format("{0 : 0.00%}", (failcount / grade.totalCount)) + ")\n\n");


                                }
                            }
                        }
                    }
                    else
                        outputRich.AppendText("No courses matched the query criteria\n");

                }

                else if (greaterthan3.Checked == true)
                {
                    var countFailureQuery = from grade in PublicVariables.gradelist
                                            where Array.IndexOf(PublicVariables.grades,grade.gradePro) != 1 && Array.IndexOf(PublicVariables.grades,grade.gradePro) >= Array.IndexOf(PublicVariables.grades,entergrade)
                                            orderby grade.ccodePro, grade.sectPro
                                            group grade by new { grade.ccodePro, grade.sectPro } into gradeGroup

                                            select new { dept = gradeGroup.Key.ccodePro, courseno = gradeGroup.Key.sectPro, failureCount = gradeGroup.Count() };
                    if (countFailureQuery.Any())
                    {
                        outputRich.AppendText("Pass Percentage (>= " + entergrade + "%) Report for classes.\n");
                        outputRich.AppendText("---------------------------------------------------------------------\n");
                        foreach (var grade in totalQuery)
                        {
                            foreach (var failgrade in countFailureQuery)
                            {
                                if (grade.dept == failgrade.dept && grade.courseno == failgrade.courseno)
                                {
                                    double failcount = Convert.ToDouble(failgrade.failureCount);

                                    outputRich.AppendText("Out of " + grade.totalCount + " enrolled in " + grade.dept + "-" + grade.courseno + ",  " + failgrade.failureCount + "  passed at or above this threshold  ( " + String.Format("{0 : 0.00%}", (failcount / grade.totalCount)) + ")\n\n");


                                }
                            }
                        }
                    }
                    else
                        outputRich.AppendText("No courses matched the query criteria\n");

                }
                else
                {
                    outputRich.AppendText("Please choose an option");
                }
            }
            else
                outputRich.AppendText("No courses matched the query criteria\n");

            outputRich.AppendText("\n\n\n### END RESULTS ###");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
