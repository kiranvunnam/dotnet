/*
 Name : Kiranmayi Manukonda, Sai Kiran Vunnam
 ZID : z1827988, z1840993
 Assignment : 3
 */

//using Manukonda_Assign3;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manukonda_Assign3
{

    public static class PublicVariables
    {

        public static List<Student> studentlist = new List<Student>(); //contains the list of students
        public static List<Course> courselist = new List<Course>(); //contains the list of courses
        public static List<Grade> gradelist = new List<Grade>();//contains the grades of all students
        public static String[] studentArray, courseArray, gradeArray; //arrays to store students and courses
        public static String studentField, courseField , gradeField; //
        public static int studentCount = 0, courseCount = 0, gradeCount = 0;
        public static Dictionary<uint, uint> cenroll = new Dictionary<uint, uint>();
        public static string[] grades = new string[] { "A", "A-", "B+", "B", "B-" ,"C++", "C" , "C-" , "D" , "F"};
        public static void Input()
        {
            //reads the Students from the input file
            using (StreamReader sr = new StreamReader("2188_a3_input01.txt"))
            {
                studentField = sr.ReadLine();
                while (studentField != null)
                {
                    studentCount++;
                    studentArray = studentField.Split(',');
                    studentlist.Add(new Student(Convert.ToUInt32(studentArray[0]), studentArray[1], studentArray[2], studentArray[3], (AcademicYear)Enum.Parse(typeof(AcademicYear), studentArray[4]), Convert.ToSingle(studentArray[5])));
                    studentField = sr.ReadLine();
                }
                studentlist.Sort();
            }
            //reads the courses from the input file
            using (StreamReader sr = new StreamReader("2188_a3_input02.txt"))
            {
                courseField = sr.ReadLine();
                while (courseField != null)
                {
                    courseCount++;
                    courseArray = courseField.Split(',');
                    courselist.Add(new Course(courseArray[0], Convert.ToUInt16(courseArray[1]), courseArray[2], Convert.ToUInt16(courseArray[3]), Convert.ToUInt16(courseArray[4])));
                    courseField = sr.ReadLine();
                }
                courselist.Sort();
            }

            using (StreamReader sr = new StreamReader("2188_a3_input04.txt"))
            {
                gradeField = sr.ReadLine();
                while (gradeField != null)
                {
                    gradeCount++;
                    gradeArray = gradeField.Split(',');
                    gradelist.Add(new Grade(Convert.ToUInt32(gradeArray[0]), gradeArray[1], Convert.ToUInt32(gradeArray[2]), gradeArray[3]) );
                    gradeField = sr.ReadLine();
                }
                //gradelist.Sort();
            }

        }
        public class Program
        {
            static void Main(string[] args)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new NIUAcademicPerformanceQuerySystem());

            }
        }

        //enum to store the academic year
        public enum AcademicYear
        {
            None,
            Freshman,
            Sophomore,
            Junior,
            Senior,
            PostBacc
        }
        public class Student : IComparable<Student>
        {
            public readonly uint Zid; //to store the student z-id
            public string fname;  //to store the studets first name
            public string lname;  //to store the students last name
            public string major;  //to store the students major

            public AcademicYear stuyear; //to store the students year
            public float GPA;  //to store the stdents GPA
            public ushort credit_hrs;  //to store the students credit hours
            //Default constructor
            public Student()
            {
                fname = null;
                lname = null;
                major = null;
                GPA = 0;
                credit_hrs = 0;
            }
            //alternate constructor
            public Student(uint zid, string fn, string ln, string maj, AcademicYear year, float gpa)
            {
                Zid = zid;
                fname = fn;
                lname = ln;
                major = maj;
                stuyear = year;
                GPA = gpa;
            }
            //properties of all the attributes 
            public uint zidPro
            {
                get
                {
                    return Zid;
                }
            }
            public string FirstNamePro
            {
                get
                {
                    return fname;
                }
                set
                {
                    fname = value;
                }
            }
            public string LastNamePro
            {
                get
                {
                    return lname;
                }
                set
                {
                    lname = value;
                }
            }
            public string MajorPro
            {
                get
                {
                    return major;
                }
                set
                {
                    major = value;
                }
            }

            public AcademicYear yearPro
            {
                get
                {
                    return stuyear;
                }
                set
                {
                    stuyear = value;
                }
            }
            public float GpaPro
            {
                get
                {
                    return GPA;
                }
                set
                {
                    if (value >= 0.000 && value <= 4.000)
                        GPA = value;
                }
            }
            public ushort CredithoursPro
            {
                get
                {
                    return credit_hrs;
                }
                set
                {
                    credit_hrs = value;
                }
            }
            //compare to method

            public int CompareTo(Student o)
            {
                if (this.Zid < o.Zid)
                {
                    return -1;
                }
                else if (this.Zid == o.Zid)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            //enroll method for students to get enrolled
            public int Enroll(Course newCourse)
            {
                if (newCourse.stu_enrolled <= newCourse.max_capPro)
                {
                    foreach (var si in newCourse.stu_idPro)
                    {
                        if (this.zidPro == si)
                            return 10;
                    }
                    if ((newCourse.credithoursPro + this.CredithoursPro) > 18)
                        return 15;
                    else
                        return 0;
                }
                else
                    return 5;
            }

            //drop method to drop the course
            public int Drop(Course newCourse)
            {
                foreach (KeyValuePair<uint, uint> kv in PublicVariables.cenroll)
                {
                    if (this.zidPro == kv.Key)
                    {
                        return 0;
                    }
                }
                return 20;

            }

            //to convert into string
            public override string ToString()
            {
                return String.Format("Z{0} -- {1},{2} [{3}] ({4}) |{5}|", Zid, lname, fname, stuyear, major, GPA);
            }
        }


        public class Course : IComparable
        {
            public string dcode; //to store the depart code
            public uint courseNum;  //to store course number
            public string Section;  //to store the section
            public ushort credithours; //to store the credit hours
            public List<uint> Zid = new List<uint>(); //list to store zid
            public ushort stu_enrolled;  //to store number of students enrolled
            public ushort max_cap;  //to store the maximum capacity

            //properties of all the attributes
            public string dcodePro
            {
                get
                {
                    return dcode;
                }
                set
                {
                    dcode = value;
                }
            }
            public string SectionPro
            {
                get
                {
                    return Section;
                }
                set
                {
                    Section = value;
                }
            }
            public ushort credithoursPro
            {
                get
                {
                    return credithours;
                }
                set
                {
                    credithours = value;
                }
            }
            public uint courseNumPro
            {
                get
                {
                    return courseNum;
                }
                set
                {
                    courseNum = value;
                }
            }
            public List<uint> stu_idPro
            {
                get
                {
                    return Zid;
                }
                set
                {
                    Zid = value;
                }
            }
            public ushort EnrolledPro
            {
                get
                {
                    return stu_enrolled;
                }
                set
                {
                    stu_enrolled = value;
                }
            }
            public ushort max_capPro
            {
                get
                {
                    return max_cap;
                }
                set
                {
                    max_cap = value;
                }
            }
            //default constructor
            public Course()
            {
                dcode = "";
                Section = "";
                courseNum = 0;
                credithours = 0;
                stu_enrolled = 0;
                max_cap = 0;
            }
            //alternate constructor
            public Course(string code, uint coursenum, string sec_num, ushort hours, ushort max_capacity)
            {
                dcode = code;
                courseNum = coursenum;
                Section = sec_num;
                credithours = hours;
                max_cap = max_capacity;

            }
            //compare method to compare the courses
            public int CompareTo(Object alpha)
            {

                if (alpha == null) return 1;
                Course c = (Course)alpha;
                if (c != null)
                {
                    int result = dcodePro.CompareTo(c.dcodePro);
                    if (result == 0)
                        result = dcodePro.CompareTo(c.dcodePro);
                    return result;
                }
                return 0;
            }
            //to print the attributes
            public void PrintRoster()
            {
                /*Console.WriteLine("Which course roaster would you like printed?");
                Console.WriteLine("(DEPT COURSE_NUM-SECTION_NUM)");
                string s2 = Console.ReadLine();
                string[] s3 = s2.Split(' ');
                string[] s4 = s3[1].Split('-');
                Course c1 = new Course();*/
                for (int k = 0; k < PublicVariables.courselist.Count(); k++)
                {
                    if (Convert.ToString(this.courseNum) == Convert.ToString(PublicVariables.courselist[k].courseNum))
                    {
                        Console.WriteLine("Course: " + this.dcodePro + " " + this.courseNum + "-" + this.SectionPro + " (" + this.Zid.Count + "/" + PublicVariables.courselist[k].max_capPro + ")");
                        Console.WriteLine("---------------------------------");
                        if (this.stu_enrolled == 0)
                            Console.WriteLine("There isn't anyone enrolled into " + this.dcodePro + " " + this.courseNum + "-" + this.SectionPro + ".");
                        else
                            Console.WriteLine(" ");
                    }
                }
            }
            //to convert into the string
            public override string ToString()
            {
                return String.Format("{0} {1}-{2} ({3}/{4})", dcode, courseNum, Section, stu_enrolled, max_cap);
            }
        }

        //Grade class holds all the variables in 4th input file
        public class Grade
        {
            public uint z_id;  //stores the zid of the student
            public string ccode; //stores the dept code 
            public uint sect;  //stores the course code
            public string grade;  //stores the grade of student

            //all the properties for the variables are defined
            public uint z_idPro
            {
                get
                {
                    return z_id;
                }
                set
                {
                    z_id = value;
                }
            }
            public string ccodePro
            {
                get
                {
                    return ccode;
                }
                set
                {
                    ccode = value;
                }
            }
            public uint sectPro
            {
                get
                {
                    return sect;
                }
                set
                {
                    sect = value;
                }
            }
            public string gradePro
            {
                get
                {
                    return grade;
                }
                set
                {
                    grade = value;
                }
            }

            //default constructor
            public Grade()
            {
                z_id = 0;
                sect = 0;
                ccode = "";
                grade = "";
            }
            //alternate constructor
            public Grade(uint zid, string cocode, uint secti, string grad)
            {
                z_id = zid;
                ccode = cocode;
                sect = secti;
                grade = grad;

            }

        }
    }
}
