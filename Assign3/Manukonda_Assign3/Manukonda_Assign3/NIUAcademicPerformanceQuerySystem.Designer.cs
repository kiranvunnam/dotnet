namespace Manukonda_Assign3
{
    partial class NIUAcademicPerformanceQuerySystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.zidTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outputRich = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.greaterthan1 = new System.Windows.Forms.RadioButton();
            this.LessThan1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gradeCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CourseTextt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.majorCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CourseTextm = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CourseTextr = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.greaterthan2 = new System.Windows.Forms.RadioButton();
            this.Lessthan2 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.percentageUpDown = new System.Windows.Forms.NumericUpDown();
            this.button5 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.greaterthan3 = new System.Windows.Forms.RadioButton();
            this.Lessthan3 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.gradeCombo1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentageUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade Report for One Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Z-ID: ";
            // 
            // zidTextBox
            // 
            this.zidTextBox.Location = new System.Drawing.Point(58, 42);
            this.zidTextBox.Name = "zidTextBox";
            this.zidTextBox.Size = new System.Drawing.Size(157, 26);
            this.zidTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.showResults1);
            // 
            // outputRich
            // 
            this.outputRich.Location = new System.Drawing.Point(707, 41);
            this.outputRich.Name = "outputRich";
            this.outputRich.Size = new System.Drawing.Size(427, 648);
            this.outputRich.TabIndex = 4;
            this.outputRich.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grade Threshold for One Course";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.greaterthan1);
            this.groupBox1.Controls.Add(this.LessThan1);
            this.groupBox1.Location = new System.Drawing.Point(16, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // greaterthan1
            // 
            this.greaterthan1.AutoSize = true;
            this.greaterthan1.Location = new System.Drawing.Point(15, 55);
            this.greaterthan1.Name = "greaterthan1";
            this.greaterthan1.Size = new System.Drawing.Size(214, 24);
            this.greaterthan1.TabIndex = 7;
            this.greaterthan1.TabStop = true;
            this.greaterthan1.Text = "Greater Than or Equal To";
            this.greaterthan1.UseVisualStyleBackColor = true;
            // 
            // LessThan1
            // 
            this.LessThan1.AutoSize = true;
            this.LessThan1.Location = new System.Drawing.Point(15, 15);
            this.LessThan1.Name = "LessThan1";
            this.LessThan1.Size = new System.Drawing.Size(193, 24);
            this.LessThan1.TabIndex = 7;
            this.LessThan1.TabStop = true;
            this.LessThan1.Text = "Less Than or Equal To";
            this.LessThan1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grade";
            // 
            // gradeCombo
            // 
            this.gradeCombo.FormattingEnabled = true;
            this.gradeCombo.Location = new System.Drawing.Point(290, 189);
            this.gradeCombo.Name = "gradeCombo";
            this.gradeCombo.Size = new System.Drawing.Size(59, 28);
            this.gradeCombo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Course";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CourseTextt
            // 
            this.CourseTextt.Location = new System.Drawing.Point(374, 191);
            this.CourseTextt.Name = "CourseTextt";
            this.CourseTextt.Size = new System.Drawing.Size(143, 26);
            this.CourseTextt.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 31);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show Results";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.showResults2);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(331, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Major Students Who Failed A Course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Major";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // majorCombo
            // 
            this.majorCombo.FormattingEnabled = true;
            this.majorCombo.Location = new System.Drawing.Point(16, 285);
            this.majorCombo.Name = "majorCombo";
            this.majorCombo.Size = new System.Drawing.Size(199, 28);
            this.majorCombo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(370, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Course";
            // 
            // CourseTextm
            // 
            this.CourseTextm.Location = new System.Drawing.Point(374, 287);
            this.CourseTextm.Name = "CourseTextm";
            this.CourseTextm.Size = new System.Drawing.Size(143, 26);
            this.CourseTextm.TabIndex = 16;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Show Results";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.showResults3);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Grade Report for One Course";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "Course";
            // 
            // CourseTextr
            // 
            this.CourseTextr.Location = new System.Drawing.Point(96, 361);
            this.CourseTextr.Name = "CourseTextr";
            this.CourseTextr.Size = new System.Drawing.Size(138, 26);
            this.CourseTextr.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(523, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 34);
            this.button4.TabIndex = 21;
            this.button4.Text = "Show Results";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.showResults4);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 23);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fail Report For All Courses";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.greaterthan2);
            this.groupBox2.Controls.Add(this.Lessthan2);
            this.groupBox2.Location = new System.Drawing.Point(14, 434);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 100);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // greaterthan2
            // 
            this.greaterthan2.AutoSize = true;
            this.greaterthan2.Location = new System.Drawing.Point(6, 70);
            this.greaterthan2.Name = "greaterthan2";
            this.greaterthan2.Size = new System.Drawing.Size(214, 24);
            this.greaterthan2.TabIndex = 24;
            this.greaterthan2.TabStop = true;
            this.greaterthan2.Text = "Greater Than or Equal To";
            this.greaterthan2.UseVisualStyleBackColor = true;
            // 
            // Lessthan2
            // 
            this.Lessthan2.AutoSize = true;
            this.Lessthan2.Location = new System.Drawing.Point(6, 25);
            this.Lessthan2.Name = "Lessthan2";
            this.Lessthan2.Size = new System.Drawing.Size(193, 24);
            this.Lessthan2.TabIndex = 24;
            this.Lessthan2.TabStop = true;
            this.Lessthan2.Text = "Less Than or Equal To";
            this.Lessthan2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(264, 482);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 23);
            this.label12.TabIndex = 24;
            this.label12.Text = "Percentage";
            // 
            // percentageUpDown
            // 
            this.percentageUpDown.Location = new System.Drawing.Point(268, 508);
            this.percentageUpDown.Name = "percentageUpDown";
            this.percentageUpDown.Size = new System.Drawing.Size(113, 26);
            this.percentageUpDown.TabIndex = 25;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(523, 498);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 36);
            this.button5.TabIndex = 26;
            this.button5.Text = "Show Results";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.showResults5);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 553);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 23);
            this.label13.TabIndex = 27;
            this.label13.Text = "Pass Report For All Corses";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.greaterthan3);
            this.groupBox3.Controls.Add(this.Lessthan3);
            this.groupBox3.Location = new System.Drawing.Point(16, 589);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 100);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            // 
            // greaterthan3
            // 
            this.greaterthan3.AutoSize = true;
            this.greaterthan3.Location = new System.Drawing.Point(6, 70);
            this.greaterthan3.Name = "greaterthan3";
            this.greaterthan3.Size = new System.Drawing.Size(214, 24);
            this.greaterthan3.TabIndex = 29;
            this.greaterthan3.TabStop = true;
            this.greaterthan3.Text = "Greater Than or Equal To";
            this.greaterthan3.UseVisualStyleBackColor = true;
            // 
            // Lessthan3
            // 
            this.Lessthan3.AutoSize = true;
            this.Lessthan3.Location = new System.Drawing.Point(6, 25);
            this.Lessthan3.Name = "Lessthan3";
            this.Lessthan3.Size = new System.Drawing.Size(193, 24);
            this.Lessthan3.TabIndex = 29;
            this.Lessthan3.TabStop = true;
            this.Lessthan3.Text = "Less Than or Equal To";
            this.Lessthan3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(268, 632);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Grade";
            // 
            // gradeCombo1
            // 
            this.gradeCombo1.FormattingEnabled = true;
            this.gradeCombo1.Location = new System.Drawing.Point(268, 661);
            this.gradeCombo1.Name = "gradeCombo1";
            this.gradeCombo1.Size = new System.Drawing.Size(79, 28);
            this.gradeCombo1.TabIndex = 30;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(523, 653);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 30);
            this.button6.TabIndex = 31;
            this.button6.Text = "Show Results";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.showResults6);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(711, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 23);
            this.label15.TabIndex = 32;
            this.label15.Text = "Output";
            // 
            // NIUAcademicPerformanceQuerySystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 719);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.gradeCombo1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.percentageUpDown);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.CourseTextr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.CourseTextm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.majorCombo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CourseTextt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gradeCombo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputRich);
            this.Controls.Add(this.zidTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "NIUAcademicPerformanceQuerySystem";
            this.Text = "NIUAcademicPerformanceQuerySystem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.percentageUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zidTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox outputRich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton greaterthan1;
        private System.Windows.Forms.RadioButton LessThan1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox gradeCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CourseTextt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox majorCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CourseTextm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CourseTextr;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton greaterthan2;
        private System.Windows.Forms.RadioButton Lessthan2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown percentageUpDown;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton greaterthan3;
        private System.Windows.Forms.RadioButton Lessthan3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox gradeCombo1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label15;
    }
}