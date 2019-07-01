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
using System.IO;
using static Manukonda_Assign2.PublicVariables;

namespace Manukonda_Assign2
{
    public partial class Form1 : Form
    {

        private String student = "", course = "";//strings used for storing the selected strings in the student list
        public Form1()
        {
            InitializeComponent(); //initializes the form
            PublicVariables.Input(); //reads the input content from the input file
        }

        private void Form1_Load(object sender, EventArgs e) //loads the form
        {
            int coun = 0;
            list_of_students.Items.Clear(); //after every run it clears the student list
            PublicVariables.studentlist.Sort(); //sorts the student list
            while (coun != PublicVariables.studentCount) //adds all the items to the student list
            {
                list_of_students.Items.Add("z" + PublicVariables.studentlist[coun].zidPro + "  --  " + (PublicVariables.studentlist[coun].FirstNamePro) + " , " + (PublicVariables.studentlist[coun].LastNamePro));
                coun++;
            }

            coun = 0;
            list_of_courses.Items.Clear(); //after every run it clears the courses list
            PublicVariables.courselist.Sort(); //sorts the courses list
            while (coun != PublicVariables.courseCount) //adds all the items to the course list
            {
                list_of_courses.Items.Add(PublicVariables.courselist[coun].dcodePro + " " + PublicVariables.courselist[coun].courseNumPro + "-" + PublicVariables.courselist[coun].SectionPro + " (" + PublicVariables.courselist[coun].EnrolledPro + "/" + PublicVariables.courselist[coun].max_capPro + ")");
                coun++;
            }
            Dictionary<String, String> combolist = new Dictionary<String, String>(); //dictionary to store the keys and all the associated Majors
            String majorread="";
            combolist.Add("-1", "--Select--");
            using (StreamReader sr = new StreamReader("2188_a2_input03.txt"))
            {
                majorread = sr.ReadLine();
                coun = 0;
                while (majorread != null)
                {
                    combolist.Add(Convert.ToString(coun), majorread);
                    coun++;
                    majorread = sr.ReadLine();
                }
                
            }
            
    
            majorCombo.DataSource = new BindingSource(combolist, null);
            majorCombo.DisplayMember = "Value";
            majorCombo.ValueMember = "Key";

            Dictionary<String, String> combolist1 = new Dictionary<String, String>(); //dictionary to store the keys and all the associated year
            combolist1.Add("-1", "--Select--");
            combolist1.Add("1", "Freshman");
            combolist1.Add("2", "Sophomore");
            combolist1.Add("3", "Junior");
            combolist1.Add("4", "Senior");
            combolist1.Add("5", "PostBacc");
            yearCombo.DataSource = new BindingSource(combolist1, null);
            yearCombo.DisplayMember = "Value";
            yearCombo.ValueMember = "Key";

            Dictionary<String, String> combolist2 = new Dictionary<String, String>(); //dictionary to store the keys and all the associated dept code
            combolist2.Add("-1", "--Select--");
            combolist2.Add("1", "ANTH");
            combolist2.Add("2", "ART");
            combolist2.Add("3", "CSCI");
            combolist2.Add("4", "FLGL");
            combolist2.Add("5", "MATH");
            combolist2.Add("6", "MGMT");
            combolist2.Add("7", "MUSE");
            combolist2.Add("8", "PHYS");
            combolist2.Add("9", "PSYC");
            combolist2.Add("10", "STAT");
            dcodeCombo.DataSource = new BindingSource(combolist2, null);
            dcodeCombo.DisplayMember = "Value";
            dcodeCombo.ValueMember = "Key";

        }

        //method enabled when enroll student button is clicked in the form
        private void enrollStudent_Click(object sender, EventArgs e)
        {
            String[] str, str1, str2, str3;
            output.Clear();
            if (list_of_courses.SelectedIndex != -1 && list_of_students.SelectedIndex != -1)
            {
                student = Convert.ToString(list_of_students.SelectedItem);
                str = student.Split(' ');  //splits the selected student with the spaces
                str[0] = str[0].Trim('z'); //trims the starting z character
                course = Convert.ToString(list_of_courses.SelectedItem);
                str1 = course.Split(' '); //splits the selected course with the spaces
                str2 = str1[1].Split('-'); //splits it again with '-'
                str1[2] = str1[2].Trim(new char[] { '(', ')' }); //trims the starting and ending paranthesis
                str3 = str1[2].Split('/'); //splits it with '/'

                Course c1 = new Course();  //creates an object for course class
                c1.dcodePro = str1[0];
                c1.courseNumPro = Convert.ToUInt32(str2[0]);
                c1.SectionPro = str2[1];
                c1.credithoursPro = 0;
                c1.max_capPro = Convert.ToUInt16(str3[1]);
                uint id = Convert.ToUInt32(str[0]);
                Student s1 = new Student(id, "", "", "", AcademicYear.None, 0);
                int result = s1.Enroll(c1);
                if (result == 0) //if the student is enrolled the student is added to the student list
                {
                    c1.EnrolledPro++; //no of students enrolled is incremented
                    c1.Zid.Add(Convert.ToUInt32(id));
                    PublicVariables.cenroll.Add(id, c1.courseNumPro);
                    output.AppendText("z" + str[0] + " has successfully been enrolled into " + course + "\n");
                    int index = list_of_courses.Items.IndexOf(course);
                    int total = Convert.ToInt16(str3[0]) + 1;
                    list_of_courses.Items[index] = str1[0] + " " + str2[0] + "-" + str2[1] + " (" + Convert.ToString(total) + "/" + str3[1] + ")";
                }
                else if (result == 5)
                    output.AppendText("Capacity exceeded for the course " + course);
                else if (result == 10)
                    output.AppendText("The student is already enrolled.");
                else if (result == 15)
                    output.AppendText("Student cannot exceed 18 credit hours.");


            }
        }

        //this method is enabled when we click drop studednt button
        private void dropStudent_Click(object sender, EventArgs e)
        {
            String[] str, str1, str2, str3;
            output.Clear();
            if (list_of_courses.SelectedIndex != -1 && list_of_courses.SelectedIndex != -1)
            {
                student = Convert.ToString(list_of_students.SelectedItem);
                str = student.Split(' '); //splits the string with the space character
                str[0] = str[0].Trim('z'); //trims the starting z character
                course = Convert.ToString(list_of_courses.SelectedItem);
                str1 = course.Split(' '); //splits it with space character
                str2 = str1[1].Split('-'); //splits it again with '-'
                str1[2] = str1[2].Trim(new char[] { '(', ')' });
                str3 = str1[2].Split('/');

                Course c1 = new Course(); //creates an object for Course class
                c1.dcodePro = str1[0];
                c1.courseNumPro = Convert.ToUInt32(str2[0]);
                c1.SectionPro = str2[1];
                c1.credithoursPro = 0;
                c1.max_capPro = Convert.ToUInt16(str3[1]);
                uint id = Convert.ToUInt32(str[0]);
                Student s1 = new Student(id, "", "", "", AcademicYear.None, 0);
                int result = s1.Drop(c1);
                if (result == 0)
                {
                    PublicVariables.cenroll.Remove(id);
                    foreach (var cour in PublicVariables.courselist)
                    {
                        if (Convert.ToString(cour) == Convert.ToString(c1.courseNumPro))
                            cour.EnrolledPro -= 1;
                    }
                    output.AppendText("z" + id + " has successfully been dropped from " + course);
                    int index = list_of_courses.Items.IndexOf(course);
                    int total = Convert.ToInt16(str3[0]) - 1;
                    list_of_courses.Items[index] = str1[0] + " " + str2[0] + "-" + str2[1] + " (" + Convert.ToString(total) + "/" + str3[1] + ")";
                }
                else if (result == 20)
                {
                    output.AppendText("Student isn't enrolled into this course");
                }

            }

        }

        //this method is enabled when the apply search criteria button is clicked
        private void search_Click(object sender, EventArgs e)
        {
            int i = 0, count = 0, flag = 0;
            String str = "";
            String[] st;
            List<String> listStudent = new List<string>(); //new student list is created
            List<String> listCourse = new List<string>(); //new course list is created
            output.Clear();
            if (zidsearch.Text != "" && zidsearch.Text.Length == 3)
            {
                while (i < list_of_students.Items.Count)
                {
                    str = list_of_students.Items[i].ToString();
                    st = str.Split(' ');
                    if (st[0].Contains(zidsearch.Text))
                    {
                        listStudent.Add(str);
                        count++;
                    }
                    i++;
                }
                if (count > 0)
                {
                    list_of_students.Items.Clear();
                    i = 0;
                    while (i < count)
                    {
                        list_of_students.Items.Add(listStudent[i]);
                        i++;
                    }
                }
                else
                {
                    flag = 1;
                }

            }
            else
                flag = 1;
            if (deptfilter.Text != "")
            {
                count = 0;
                while (i < list_of_courses.Items.Count)
                {
                    str = list_of_courses.Items[i].ToString();
                    st = str.Split(' ');
                    if (st[0].Equals(deptfilter.Text))
                    {
                        listCourse.Add(str);
                        count++;
                    }
                    i++;
                }
                if (count > 0)
                {
                    flag = 0;
                    list_of_courses.Items.Clear();
                    i = 0;
                    while (i < listCourse.Count)
                    {
                        list_of_courses.Items.Add(listCourse[i]);
                        i++;
                    }
                }
                else
                {
                    flag = 1;

                }
            }
            if (flag != 0)
                output.AppendText("Nothing was a match for your filtering criteria");

        }

        //this method is enabled when add student method is clicked
        private void addStudent_Click(object sender, EventArgs e)
        {
            String fname = "", lname = "", maj = "", nameSt = name.Text;
            String zidSt = zid.Text;
            int flag = 0, yr = 0;
            output.Text = "";
            if (nameSt.Contains(",")) //checks if the name contains ,
            {
                String[] st = nameSt.Split(',');
                fname = st[1];
                lname = st[0];
                flag = 1;
            }
            else //or display that they should enter full name
            {
                flag++;
                output.AppendText("Please enter full name (Lastname, Firstname)\n");
            }
            if (zidSt.Contains("z") || zidSt.Contains("Z")) //if the zid contains z then we trim it
            {
                zidSt = zidSt.Trim(new char[] { 'z', 'Z' });
                if (zidSt.Count() == 7) //checking whether the zid is valid or not
                {
                    flag = 1;
                }
                else
                {
                    flag++;
                    output.AppendText("Please enter valid 7 digit Z-ID\n");
                }
            }
            else if (zidSt.Count() == 7)
            {
                flag = 1;
            }
            else
            {
                flag++;
                output.AppendText("Please enter valid 7 digit Z-ID\n");
            }

            if (Convert.ToInt32(majorCombo.SelectedIndex) != 0) //to check if the major is selected
            {
                maj = Convert.ToString(((KeyValuePair<string, string>)majorCombo.SelectedItem).Value);
                flag = 1;
            }
            else
            {
                flag++;
                output.AppendText("Please select major\n");
            }
            AcademicYear ay = AcademicYear.None;
            if (Convert.ToInt32(yearCombo.SelectedIndex) != 0) //to check if the year is selected
            {
                yr = Convert.ToInt32(yearCombo.SelectedIndex);
                ay = (AcademicYear)Enum.Parse(typeof(AcademicYear), Convert.ToString(yr));

                flag = 1;
            }
            else
            {
                flag++;
                output.AppendText("Please select academic year\n");
            }
            if (flag == 1)
            {

                PublicVariables.studentlist.Add(new Student(Convert.ToUInt32(zidSt), fname, lname, maj, ay, 0));

                list_of_students.Items.Add(zid.Text + "  --  " + (fname) + " , " + (lname));

                PublicVariables.studentCount++;

                output.AppendText("Student is added!!");
                Form1_Load(sender, e);

            }
        }

        //this method is enabled when the add course button is clicked
        private void addCourse_Click(object sender, EventArgs e)
        {
            output.Clear();
            String code = Convert.ToString(((KeyValuePair<string, string>)dcodeCombo.SelectedItem).Value);
            if (Convert.ToInt32(dcodeCombo.SelectedIndex) != 0 && Regex.IsMatch(Convert.ToString(courseno.Text), "^[0-9]{3}$") && Regex.IsMatch(Convert.ToString(sectionno.Text), "^[a-z0-9A-Z]{4}$") && capnumeric.Value > 0)
            {
                PublicVariables.courselist.Add(new Course(code, Convert.ToUInt32(courseno.Text), sectionno.Text, 3, Convert.ToUInt16(capnumeric.Text)));
                list_of_courses.Items.Add(code + " " + courseno.Text + "-" + sectionno.Text + " (" + Convert.ToString(0) + "/" + capnumeric.Value + ")");
                PublicVariables.courseCount++;
                output.AppendText("Course is added!");
                Form1_Load(sender, e);
            }
        }

        //this method is enabled when the print course roaster button is clicked
        private void PrintCourseRoaster_Click(object sender, EventArgs e)
        {
            String[] str1, str2, str3;
            output.Clear();
            if (list_of_courses.SelectedIndex != -1)
            {
                course = Convert.ToString(list_of_courses.SelectedItem);
                str1 = course.Split(' ');
                str2 = str1[1].Split('-');
                str1[2] = str1[2].Trim(new char[] { '(', ')' });
                str3 = str1[2].Split('/');
                int ch = 0;
                //int i = 0;

                output.AppendText(course + "\n");
                output.AppendText("--------------------------------------------------------\n");
                foreach (KeyValuePair<uint, uint> cd in PublicVariables.cenroll)
                {
                    if (cd.Value == Convert.ToUInt32(str2[0]))
                    {

                        foreach (var s in PublicVariables.studentlist)
                        {
                            if (s.zidPro == cd.Key)
                            {
                                output.AppendText("z" + Convert.ToString(s.zidPro).PadRight(11) + Convert.ToString(s.LastNamePro).PadLeft(10) + ",  " + Convert.ToString(s.FirstNamePro).PadRight(13) + Convert.ToString(s.MajorPro).PadRight(20) + "\n");
                            }
                            else
                                ch = 2;
                        }
                    }
                    else
                        ch = 0;
                }
                if (ch == 0)
                    output.AppendText("There isn't anyone enrolled into " + course + ".");
            }
        }


    }
}
