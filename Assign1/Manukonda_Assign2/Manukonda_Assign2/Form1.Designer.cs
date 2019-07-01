namespace Manukonda_Assign2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrintCourseRoaster = new System.Windows.Forms.Button();
            this.enrollStudent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.zidsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deptfilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.Major = new System.Windows.Forms.Label();
            this.majorCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.yearCombo = new System.Windows.Forms.ComboBox();
            this.addStudent = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dcodeCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.courseno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sectionno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.capnumeric = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.list_of_students = new System.Windows.Forms.ListBox();
            this.list_of_courses = new System.Windows.Forms.ListBox();
            this.output = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.capnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintCourseRoaster
            // 
            this.PrintCourseRoaster.Location = new System.Drawing.Point(33, 58);
            this.PrintCourseRoaster.Name = "PrintCourseRoaster";
            this.PrintCourseRoaster.Size = new System.Drawing.Size(197, 34);
            this.PrintCourseRoaster.TabIndex = 0;
            this.PrintCourseRoaster.Text = "Print Course Roaster";
            this.PrintCourseRoaster.UseVisualStyleBackColor = true;
            this.PrintCourseRoaster.Click += new System.EventHandler(this.PrintCourseRoaster_Click);
            // 
            // enrollStudent
            // 
            this.enrollStudent.Location = new System.Drawing.Point(33, 98);
            this.enrollStudent.Name = "enrollStudent";
            this.enrollStudent.Size = new System.Drawing.Size(197, 37);
            this.enrollStudent.TabIndex = 1;
            this.enrollStudent.Text = "Enroll Student";
            this.enrollStudent.UseVisualStyleBackColor = true;
            this.enrollStudent.Click += new System.EventHandler(this.enrollStudent_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(33, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 36);
            this.button3.TabIndex = 2;
            this.button3.Text = "Drop Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.dropStudent_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(33, 183);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(197, 40);
            this.search.TabIndex = 3;
            this.search.Text = "Apply Search Criteria";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Student (by Z-ID)";
            // 
            // zidsearch
            // 
            this.zidsearch.Location = new System.Drawing.Point(266, 81);
            this.zidsearch.Name = "zidsearch";
            this.zidsearch.Size = new System.Drawing.Size(183, 26);
            this.zidsearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filter Courses (by Dept)";
            // 
            // deptfilter
            // 
            this.deptfilter.Location = new System.Drawing.Point(266, 159);
            this.deptfilter.Name = "deptfilter";
            this.deptfilter.Size = new System.Drawing.Size(183, 26);
            this.deptfilter.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name, First Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(33, 280);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(197, 26);
            this.name.TabIndex = 9;
            // 
            // Major
            // 
            this.Major.AutoSize = true;
            this.Major.Location = new System.Drawing.Point(29, 320);
            this.Major.Name = "Major";
            this.Major.Size = new System.Drawing.Size(48, 20);
            this.Major.TabIndex = 10;
            this.Major.Text = "Major";
            // 
            // majorCombo
            // 
            this.majorCombo.FormattingEnabled = true;
            this.majorCombo.Location = new System.Drawing.Point(33, 343);
            this.majorCombo.Name = "majorCombo";
            this.majorCombo.Size = new System.Drawing.Size(197, 28);
            this.majorCombo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Z-ID";
            // 
            // zid
            // 
            this.zid.Location = new System.Drawing.Point(266, 280);
            this.zid.Name = "zid";
            this.zid.Size = new System.Drawing.Size(183, 26);
            this.zid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Academic Year";
            // 
            // yearCombo
            // 
            this.yearCombo.FormattingEnabled = true;
            this.yearCombo.Location = new System.Drawing.Point(266, 343);
            this.yearCombo.Name = "yearCombo";
            this.yearCombo.Size = new System.Drawing.Size(183, 28);
            this.yearCombo.TabIndex = 15;
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(33, 390);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(156, 40);
            this.addStudent.TabIndex = 16;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Department Code";
            // 
            // dcodeCombo
            // 
            this.dcodeCombo.FormattingEnabled = true;
            this.dcodeCombo.Location = new System.Drawing.Point(33, 500);
            this.dcodeCombo.Name = "dcodeCombo";
            this.dcodeCombo.Size = new System.Drawing.Size(197, 28);
            this.dcodeCombo.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 477);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Course Number";
            // 
            // courseno
            // 
            this.courseno.Location = new System.Drawing.Point(266, 500);
            this.courseno.Name = "courseno";
            this.courseno.Size = new System.Drawing.Size(183, 26);
            this.courseno.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 552);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Section Number";
            // 
            // sectionno
            // 
            this.sectionno.Location = new System.Drawing.Point(33, 575);
            this.sectionno.Name = "sectionno";
            this.sectionno.Size = new System.Drawing.Size(197, 26);
            this.sectionno.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(272, 553);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Capacity";
            // 
            // capnumeric
            // 
            this.capnumeric.Location = new System.Drawing.Point(266, 575);
            this.capnumeric.Name = "capnumeric";
            this.capnumeric.Size = new System.Drawing.Size(183, 26);
            this.capnumeric.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(33, 625);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 38);
            this.button6.TabIndex = 25;
            this.button6.Text = "Add Course";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.addCourse_Click);
            // 
            // list_of_students
            // 
            this.list_of_students.FormattingEnabled = true;
            this.list_of_students.ItemHeight = 20;
            this.list_of_students.Location = new System.Drawing.Point(525, 58);
            this.list_of_students.Name = "list_of_students";
            this.list_of_students.Size = new System.Drawing.Size(227, 584);
            this.list_of_students.TabIndex = 26;
            // 
            // list_of_courses
            // 
            this.list_of_courses.FormattingEnabled = true;
            this.list_of_courses.ItemHeight = 20;
            this.list_of_courses.Location = new System.Drawing.Point(793, 58);
            this.list_of_courses.Name = "list_of_courses";
            this.list_of_courses.Size = new System.Drawing.Size(225, 584);
            this.list_of_courses.TabIndex = 27;
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(33, 702);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(985, 173);
            this.output.TabIndex = 28;
            this.output.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(282, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(461, 37);
            this.label11.TabIndex = 29;
            this.label11.Text = "NIU ENROLLMENT SYSTEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 896);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.output);
            this.Controls.Add(this.list_of_courses);
            this.Controls.Add(this.list_of_students);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.capnumeric);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sectionno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.courseno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dcodeCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.yearCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.zid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.majorCombo);
            this.Controls.Add(this.Major);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deptfilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zidsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.enrollStudent);
            this.Controls.Add(this.PrintCourseRoaster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.capnumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintCourseRoaster;
        private System.Windows.Forms.Button enrollStudent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zidsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deptfilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label Major;
        private System.Windows.Forms.ComboBox majorCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox zid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox yearCombo;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox dcodeCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox courseno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sectionno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown capnumeric;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox list_of_students;
        private System.Windows.Forms.ListBox list_of_courses;
        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label11;
    }
}