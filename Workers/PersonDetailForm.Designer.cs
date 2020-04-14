namespace Workers
{
    partial class PersonDetailForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEducationGrade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEducationPlace = new System.Windows.Forms.TextBox();
            this.dateEducationEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateHire = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.tbExpirience = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbQualofication = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.coursesCm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateCourse = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbCourseName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddContest = new System.Windows.Forms.Button();
            this.lbContests = new System.Windows.Forms.ListBox();
            this.cmContests = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteContestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateContest = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbContestName = new System.Windows.Forms.TextBox();
            this.dateQualification = new System.Windows.Forms.DateTimePicker();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.chBoxIsFired = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.coursesCm.SuspendLayout();
            this.panel3.SuspendLayout();
            this.cmContests.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(55, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(258, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата рождения";
            // 
            // dateBirth
            // 
            this.dateBirth.CustomFormat = "dd.MM.yyyy";
            this.dateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateBirth.Location = new System.Drawing.Point(104, 32);
            this.dateBirth.Name = "dateBirth";
            this.dateBirth.Size = new System.Drawing.Size(209, 20);
            this.dateBirth.TabIndex = 3;
            this.dateBirth.Value = new System.DateTime(2020, 4, 8, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Образование";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbEducationGrade);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbEducationPlace);
            this.panel1.Controls.Add(this.dateEducationEnd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 110);
            this.panel1.TabIndex = 5;
            // 
            // cbEducationGrade
            // 
            this.cbEducationGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEducationGrade.FormattingEnabled = true;
            this.cbEducationGrade.Items.AddRange(new object[] {
            "Среднее профессиональное",
            "Высшее профессиональное",
            "Среднее педагогическое",
            "Высшее педагогическое"});
            this.cbEducationGrade.Location = new System.Drawing.Point(57, 77);
            this.cbEducationGrade.Name = "cbEducationGrade";
            this.cbEducationGrade.Size = new System.Drawing.Size(238, 21);
            this.cbEducationGrade.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ступень";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Учебное заведение";
            // 
            // tbEducationPlace
            // 
            this.tbEducationPlace.Location = new System.Drawing.Point(116, 51);
            this.tbEducationPlace.Name = "tbEducationPlace";
            this.tbEducationPlace.Size = new System.Drawing.Size(179, 20);
            this.tbEducationPlace.TabIndex = 6;
            // 
            // dateEducationEnd
            // 
            this.dateEducationEnd.CustomFormat = "dd.MM.yyyy";
            this.dateEducationEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEducationEnd.Location = new System.Drawing.Point(95, 25);
            this.dateEducationEnd.Name = "dateEducationEnd";
            this.dateEducationEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEducationEnd.TabIndex = 7;
            this.dateEducationEnd.Value = new System.DateTime(2020, 4, 8, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата окончания";
            // 
            // dateHire
            // 
            this.dateHire.CustomFormat = "dd.MM.yyyy";
            this.dateHire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateHire.Location = new System.Drawing.Point(104, 58);
            this.dateHire.Name = "dateHire";
            this.dateHire.Size = new System.Drawing.Size(209, 20);
            this.dateHire.TabIndex = 7;
            this.dateHire.Value = new System.DateTime(2020, 4, 8, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата приема";
            // 
            // tbExpirience
            // 
            this.tbExpirience.Location = new System.Drawing.Point(91, 84);
            this.tbExpirience.Name = "tbExpirience";
            this.tbExpirience.Size = new System.Drawing.Size(53, 20);
            this.tbExpirience.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Стаж работы";
            // 
            // cbQualofication
            // 
            this.cbQualofication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQualofication.FormattingEnabled = true;
            this.cbQualofication.Items.AddRange(new object[] {
            "ВКК",
            "1КК",
            "СЗД",
            "Нет"});
            this.cbQualofication.Location = new System.Drawing.Point(100, 110);
            this.cbQualofication.Name = "cbQualofication";
            this.cbQualofication.Size = new System.Drawing.Size(204, 21);
            this.cbQualofication.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Квалификация";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Дата присвоения квалификации";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddCourse);
            this.panel2.Controls.Add(this.lbCourses);
            this.panel2.Controls.Add(this.dateCourse);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.tbCourseName);
            this.panel2.Location = new System.Drawing.Point(319, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 267);
            this.panel2.TabIndex = 11;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(207, 71);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(97, 23);
            this.btnAddCourse.TabIndex = 12;
            this.btnAddCourse.Text = "Добавить курс";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // lbCourses
            // 
            this.lbCourses.ContextMenuStrip = this.coursesCm;
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.Location = new System.Drawing.Point(6, 104);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(298, 160);
            this.lbCourses.TabIndex = 11;
            // 
            // coursesCm
            // 
            this.coursesCm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem});
            this.coursesCm.Name = "coursesCm";
            this.coursesCm.Size = new System.Drawing.Size(183, 48);
            // 
            // deleteCourseToolStripMenuItem
            // 
            this.deleteCourseToolStripMenuItem.Name = "deleteCourseToolStripMenuItem";
            this.deleteCourseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.deleteCourseToolStripMenuItem.Text = "Удаллить курс";
            this.deleteCourseToolStripMenuItem.Click += new System.EventHandler(this.deleteCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.editCourseToolStripMenuItem.Text = "Редактировать курс";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // dateCourse
            // 
            this.dateCourse.CustomFormat = "dd.MM.yyyy";
            this.dateCourse.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCourse.Location = new System.Drawing.Point(80, 42);
            this.dateCourse.Name = "dateCourse";
            this.dateCourse.Size = new System.Drawing.Size(224, 20);
            this.dateCourse.TabIndex = 10;
            this.dateCourse.Value = new System.DateTime(2020, 4, 8, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Дата курсов";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Повышение квалификации";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Тема";
            // 
            // tbCourseName
            // 
            this.tbCourseName.Location = new System.Drawing.Point(43, 16);
            this.tbCourseName.Name = "tbCourseName";
            this.tbCourseName.Size = new System.Drawing.Size(261, 20);
            this.tbCourseName.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddContest);
            this.panel3.Controls.Add(this.lbContests);
            this.panel3.Controls.Add(this.dateContest);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tbContestName);
            this.panel3.Location = new System.Drawing.Point(639, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 267);
            this.panel3.TabIndex = 13;
            // 
            // btnAddContest
            // 
            this.btnAddContest.Location = new System.Drawing.Point(187, 71);
            this.btnAddContest.Name = "btnAddContest";
            this.btnAddContest.Size = new System.Drawing.Size(117, 23);
            this.btnAddContest.TabIndex = 12;
            this.btnAddContest.Text = "Добавить конкурс";
            this.btnAddContest.UseVisualStyleBackColor = true;
            this.btnAddContest.Click += new System.EventHandler(this.btnAddContest_Click);
            // 
            // lbContests
            // 
            this.lbContests.ContextMenuStrip = this.cmContests;
            this.lbContests.FormattingEnabled = true;
            this.lbContests.Location = new System.Drawing.Point(6, 104);
            this.lbContests.Name = "lbContests";
            this.lbContests.Size = new System.Drawing.Size(298, 160);
            this.lbContests.TabIndex = 11;
            // 
            // cmContests
            // 
            this.cmContests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteContestToolStripMenuItem,
            this.editContestToolStripMenuItem});
            this.cmContests.Name = "coursesCm";
            this.cmContests.Size = new System.Drawing.Size(203, 48);
            // 
            // deleteContestToolStripMenuItem
            // 
            this.deleteContestToolStripMenuItem.Name = "deleteContestToolStripMenuItem";
            this.deleteContestToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.deleteContestToolStripMenuItem.Text = "Удаллить конкурс";
            this.deleteContestToolStripMenuItem.Click += new System.EventHandler(this.deleteContestToolStripMenuItem_Click);
            // 
            // editContestToolStripMenuItem
            // 
            this.editContestToolStripMenuItem.Name = "editContestToolStripMenuItem";
            this.editContestToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.editContestToolStripMenuItem.Text = "Редактировать конкурс";
            this.editContestToolStripMenuItem.Click += new System.EventHandler(this.editContestToolStripMenuItem_Click);
            // 
            // dateContest
            // 
            this.dateContest.CustomFormat = "dd.MM.yyyy";
            this.dateContest.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateContest.Location = new System.Drawing.Point(92, 42);
            this.dateContest.Name = "dateContest";
            this.dateContest.Size = new System.Drawing.Size(212, 20);
            this.dateContest.TabIndex = 10;
            this.dateContest.Value = new System.DateTime(2020, 4, 8, 0, 0, 0, 0);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Дата конкурса";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Участие в конкурсах";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Название";
            // 
            // tbContestName
            // 
            this.tbContestName.Location = new System.Drawing.Point(66, 16);
            this.tbContestName.Name = "tbContestName";
            this.tbContestName.Size = new System.Drawing.Size(238, 20);
            this.tbContestName.TabIndex = 6;
            // 
            // dateQualification
            // 
            this.dateQualification.CustomFormat = "dd.MM.yyyy";
            this.dateQualification.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateQualification.Location = new System.Drawing.Point(184, 137);
            this.dateQualification.Name = "dateQualification";
            this.dateQualification.Size = new System.Drawing.Size(123, 20);
            this.dateQualification.TabIndex = 14;
            this.dateQualification.Value = new System.DateTime(2020, 4, 8, 0, 0, 0, 0);
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(12, 279);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(301, 23);
            this.btnAddPerson.TabIndex = 15;
            this.btnAddPerson.Text = "Добавить работника";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // chBoxIsFired
            // 
            this.chBoxIsFired.AutoSize = true;
            this.chBoxIsFired.Location = new System.Drawing.Point(325, 281);
            this.chBoxIsFired.Name = "chBoxIsFired";
            this.chBoxIsFired.Size = new System.Drawing.Size(64, 17);
            this.chBoxIsFired.TabIndex = 16;
            this.chBoxIsFired.Text = "Уволен";
            this.chBoxIsFired.UseVisualStyleBackColor = true;
            // 
            // PersonDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 308);
            this.Controls.Add(this.chBoxIsFired);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.dateQualification);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbQualofication);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbExpirience);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateHire);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "PersonDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление нового работника";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.coursesCm.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.cmContests.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateEducationEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbEducationPlace;
        private System.Windows.Forms.ComboBox cbEducationGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateHire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbExpirience;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbQualofication;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.DateTimePicker dateCourse;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbCourseName;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddContest;
        private System.Windows.Forms.ListBox lbContests;
        private System.Windows.Forms.DateTimePicker dateContest;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbContestName;
        private System.Windows.Forms.DateTimePicker dateQualification;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.ContextMenuStrip coursesCm;
        private System.Windows.Forms.ToolStripMenuItem deleteCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmContests;
        private System.Windows.Forms.ToolStripMenuItem deleteContestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editContestToolStripMenuItem;
        private System.Windows.Forms.CheckBox chBoxIsFired;
    }
}