using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manukonda_Assin2
{
    public static List<Student> studentList = new List<Student>(); //stores the list of students
    public static List<Course> courseList = new List<Course>();  //stores the list of courses
    public static string stu, cours; //to store student id and course id
    static string[] stuarray, coursarray; //to store students enrolled and course num
    public static int stucount = 0, courscount = 0;
    public static Dictionary<uint, uint> cenroll = new Dictionary<uint, uint>();
    static void Main(string[] args)
    {
        //to read the given student file
        using (StreamReader f = new StreamReader("2188_a1_input01.txt"))
        {
            stu = f.ReadLine();
            //adds all the students into the list
            while (stu != null)
            {
                stucount++;
                stuarray = stu.Split(',');
                studentList.Add(new Student(Convert.ToUInt32(stuarray[0]), stuarray[1], stuarray[2], stuarray[3], (AcademicYear)Enum.Parse(typeof(AcademicYear), stuarray[4]), Convert.ToSingle(stuarray[5])));
                stu = f.ReadLine();
            }

        }
        //to read the given course file
        using (StreamReader r = new StreamReader("2188_a1_input02.txt"))
        {
            cours = r.ReadLine();
            //adds all the courses into the list
            while (cours != null)
            {
                courscount++;
                coursarray = cours.Split(',');
                courseList.Add(new Course(coursarray[0], Convert.ToUInt16(coursarray[1]), coursarray[2], Convert.ToUInt16(coursarray[3]), Convert.ToUInt16(coursarray[4])));
                cours = r.ReadLine();
            }
        }
        Program.PrintMenu();
    }

    //This prints the "print menu"
    static public void PrintMenu()
    {

        int ch = 0;
        //to reapeat the loop till we quit
        while (ch != 8)
        {
            Console.WriteLine("Please choose from the following options: \n");
            Console.WriteLine("1. Print Student List (All)");
            Console.WriteLine("2. Print Student List (Major)");
            Console.WriteLine("3. Print Student List (Academic Year)");
            Console.WriteLine("4. Print Course List");
            Console.WriteLine("5. Print Course Roaster");
            Console.WriteLine("6. Enroll Student");
            Console.WriteLine("7. Drop Student");
            Console.WriteLine("8. Quit Application");
            //Console.WriteLine("after printing");
            ch = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(ch);

            switch (ch)
            {
                case 1:
                    //Console.WriteLine("in case 1");

                    Console.WriteLine("Student List (All Students): \n");
                    Console.WriteLine("--------------------");
                    //to print all the students
                    for (int i = 0; i != stucount; i++)
                    {
                        Console.WriteLine("z" + studentList[i].Zid + " --" + (studentList[i].fname).PadLeft(13) + ", " + (studentList[i].lname).PadRight(11) + "[" + (studentList[i].stuyear) + "]" + " (" + studentList[i].major + ") | " + studentList[i].GPA + " |");
                    }
                    // Console.ReadKey();

                    break;
                case 2:
                    Console.WriteLine("Which major list would  you like printed?");
                    //reads the entered major
                    string s = Console.ReadLine();

                    Console.WriteLine("Student List (" + s + " Majors):\n");
                    Console.WriteLine("--------------------");
                    int y = 0;
                    //to print the students with selected majors
                    for (int k = 0; k != stucount; k++)
                    {
                        if (s == studentList[k].MajorPro)
                        {
                            Console.WriteLine("z" + studentList[k].Zid + " --" + (studentList[k].fname).PadLeft(13) + ", " + (studentList[k].lname).PadRight(11) + "[" + (studentList[k].stuyear) + "]" + " (" + studentList[k].major + ") | " + studentList[k].GPA + " |");
                            y++;
                        }
                    }
                    if (y == 0)
                        Console.WriteLine("There doesn't appear to be any students majoring in '" + s + "'\n");
                    // Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Which academic year would you like printed?");
                    Console.WriteLine("(Freshman, Sophomore, Junior, Senior, PostBacc)");
                    //reads the entered academic year
                    string s1 = Console.ReadLine();
                    Console.WriteLine("Student List (" + s1 + " Majors):");
                    Console.WriteLine("--------------------");
                    int y1 = 0;
                    //to print the academic year
                    for (int k = 0; k != stucount; k++)
                    {
                        if (s1 == (studentList[k].yearPro).ToString())
                        {
                            Console.WriteLine("z" + studentList[k].Zid + " --" + (studentList[k].fname).PadLeft(13) + ", " + (studentList[k].lname).PadRight(11) + "[" + (studentList[k].stuyear) + "]" + " (" + studentList[k].major + ") | " + studentList[k].GPA + " |");
                            y1++;
                        }
                    }
                    if (y1 == 0)
                        Console.WriteLine("No matching academic year\n");
                    //Console.ReadKey();
                    break;
                case 4:

                    Console.WriteLine("Course List (All Courses)");
                    Console.WriteLine("-------------------------------------");
                    //to print all the courses
                    for (int k = 0; k != courscount; k++)
                    {
                        Console.WriteLine(courseList[k].dcodePro + " " + courseList[k].courseNumPro + "-" + courseList[k].SectionPro + " (" + courseList[k].stu_enrolled + "/" + courseList[k].max_capPro + ")");
                    }
                    //Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("which course roaster would you like printed?");
                    Console.WriteLine("(DEPT COURSE_NUM-SECTION_NUM)");
                    //to read the sring entered
                    string str = Console.ReadLine();
                    string[] str1 = str.Split(' ');
                    string[] str2 = str1[1].Split('-');
                    Course c = new Course(str1[0], Convert.ToUInt32(str2[0]), str2[1], 0, 0);
                    c.PrintRoster();
                    //Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("please enter the Z-ID (omitting the Z character) of the student you would like to enroll into a course.");
                    uint studentid = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Which Course will this student be enrolled into ?");
                    Console.WriteLine("(DEPT COURSE_NUM-SECTION_NUM)");
                    string cstr = Console.ReadLine();
                    //to split the entered string
                    string[] strg1 = cstr.Split(' ');
                    string[] strg2 = strg1[1].Split('-');
                    Course c4 = new Course();
                    c4.dcodePro = strg1[0];
                    c4.courseNumPro = Convert.ToUInt32(strg2[0]);
                    c4.SectionPro = strg2[1];
                    c4.credithoursPro = c4.credithoursPro;
                    c4.max_capPro = c4.max_capPro;
                    Student s5 = new Student(studentid, "", "", "", AcademicYear.None, 0);
                    int r = s5.Enroll(c4);
                    if (r == 0)
                    {
                        c4.stu_idPro.Add(Convert.ToUInt32(studentid));
                        cenroll.Add(studentid, c4.courseNumPro);
                        Console.WriteLine("z" + studentid + "has Successfilly enrolled into " + cstr + "\n");
                    }
                    else if (r == 5)
                        Console.WriteLine("Capacity exceeded for the course " + cstr);
                    else if (r == 10)
                        Console.WriteLine("The Student is Already Enrolled");
                    else if (r == 15)
                        Console.WriteLine("Student cannot exceed 18 credit hours");
                    //Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("please enter the Z-ID");
                    uint studentid1 = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Which course will this student be dropped from?");
                    Console.WriteLine("(DEPT COURSE_NUM-SECTION_NUM)");
                    string cstr1 = Console.ReadLine();
                    string[] strgd1 = cstr1.Split(' ');
                    string[] strgd2 = strgd1[1].Split('-');
                    Course c7 = new Course();
                    c7.dcodePro = strgd1[0];
                    c7.courseNumPro = Convert.ToUInt32(strgd2[0]);
                    c7.SectionPro = strgd2[1];
                    c7.credithoursPro = c7.credithoursPro;
                    c7.max_capPro = c7.max_capPro;
                    Student s7 = new Student(studentid1, "", "", "", AcademicYear.None, 0);
                    int r1 = s7.Drop(c7);
                    if (r1 == 0)
                    {
                        cenroll.Remove(studentid1);
                        foreach (var ci in courseList)
                        {
                            if (Convert.ToString(ci) == Convert.ToString(c7.courseNumPro))
                                ci.stu_enrolled -= 1;
                        }
                        Console.WriteLine("z" + studentid1 + "has Successfilly dropped from " + cstr1 + "\n");
                    }
                    else if (r1 == 20)
                        Console.WriteLine("Student is not enrolled into this course");
                    //Console.ReadKey();
                    break;
                case 8: break;
                default: break;
            }
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
            foreach (KeyValuePair<uint, uint> kv in cenroll)
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


    public class Course
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
        public int CompareTo(Course c)
        {
            return this.courseNum.CompareTo(c.courseNum);
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
            for (int k = 0; k < Program.courseList.Count(); k++)
            {
                if (Convert.ToString(this.courseNum) == Convert.ToString(Program.courseList[k].courseNum))
                {
                    Console.WriteLine("Course: " + this.dcodePro + " " + this.courseNum + "-" + this.SectionPro + " (" + this.Zid.Count + "/" + Program.courseList[k].max_capPro + ")");
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
}

