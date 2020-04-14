using BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workers
{
    public partial class PersonDetailForm : Form
    {
        Person person;
        List<Contest> contests = new List<Contest>();
        List<Course> courses = new List<Course>();
        int index = -1;
        int selectedCourse;
        int selectedContest;

        event AddPerson personAdded;
        event EditPerson personEdited;

        public PersonDetailForm(AddPerson onPersonAdded)
        {
            InitializeComponent();
            this.personAdded = onPersonAdded;
            cbEducationGrade.SelectedIndex = 0;
            cbQualofication.SelectedIndex = 0;
            person = new Person();
        }

        public PersonDetailForm(EditPerson personEdited, Person person, int index)
        {
            InitializeComponent();
            this.personEdited = personEdited;

            Text = "Редактирование";
            btnAddPerson.Text = "Сохранить";

            this.person = person;
            this.index = index;

            tbName.Text = person.Name;
            dateBirth.Value = person.BirthDate;
            cbEducationGrade.SelectedIndex = (int)person.Education.Degree;
            dateEducationEnd.Value = person.Education.EndTime;
            tbEducationPlace.Text = person.Education.Place;
            dateHire.Value = person.HireDate;
            dateQualification.Value = person.Qualification.Date;
            cbQualofication.SelectedIndex = (int)person.Qualification.QualificationCategorie;
            tbExpirience.Text = person.WorkExperience.ToString();
            contests.AddRange(person.Contests);
            courses.AddRange(person.Courses);
            chBoxIsFired.Checked = person.IsFired;
            UpdateContests();
            UpdateCourses();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            int workExpirience;
            if (!int.TryParse(tbExpirience.Text, out workExpirience))
            {
                MessageBox.Show("Введите корректный стаж работы", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            person.Name = tbName.Text;
            person.BirthDate = dateBirth.Value;
            person.Education = new Education() { Degree = (Degree)cbEducationGrade.SelectedIndex, EndTime = dateEducationEnd.Value, Place = tbEducationPlace.Text };
            person.HireDate = dateHire.Value;
            person.Qualification = new Qualification() { Date = dateQualification.Value, QualificationCategorie = (QualificationCategorie)cbQualofication.SelectedIndex };
            person.WorkExperience = workExpirience;
            person.Contests = contests;
            person.Courses = courses;
            person.IsFired = chBoxIsFired.Checked;

            if (index == -1)
            {
                personAdded?.Invoke(person);
            }
            else
            {
                personEdited?.Invoke(person, index);
            }

            Close();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Date = dateCourse.Value;
            course.Theme = tbCourseName.Text;

            ClearCoursesFields();

            courses.Add(course);
            lbCourses.Items.Add(course.ToString());
        }

        private void btnAddCourse_ClickEdit(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Date = dateCourse.Value;
            course.Theme = tbCourseName.Text;

            courses[selectedCourse] = course;

            ClearCoursesFields();
            UpdateCourses();

            btnAddCourse.Click -= btnAddCourse_ClickEdit;
            btnAddCourse.Click += btnAddCourse_Click;
            btnAddCourse.Text = "Добавить курс";
        }

        private void btnAddContest_Click(object sender, EventArgs e)
        {
            Contest contest = new Contest();
            contest.Date = dateContest.Value;
            contest.Title = tbContestName.Text;

            ClearContestsFields();

            contests.Add(contest);
            lbContests.Items.Add(contest.ToString());
        }

        private void btnAddContest_ClickEdit(object sender, EventArgs e)
        {
            Contest contest = new Contest();
            contest.Date = dateContest.Value;
            contest.Title = tbContestName.Text;

            contests[selectedContest] = contest;

            ClearContestsFields();
            UpdateContests();

            btnAddContest.Click -= btnAddContest_ClickEdit;
            btnAddContest.Click += btnAddContest_Click;
            btnAddContest.Text = "Добавить курс";
        }

        private void UpdateCourses()
        {
            lbCourses.Items.Clear();
            foreach (Course course in courses)
            {
                lbCourses.Items.Add(course.ToString());
            }
        }

        private void UpdateContests()
        {
            lbContests.Items.Clear();
            foreach (Contest contest in contests)
            {
                lbContests.Items.Add(contest.ToString());
            }
        }

        private void ClearCoursesFields()
        {
            dateCourse.Value = DateTime.Now;
            tbCourseName.Text = "";
        }

        private void ClearContestsFields()
        {
            dateContest.Value = DateTime.Now;
            tbContestName.Text = "";
        }

        private void deleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbCourses.SelectedIndex;
            if (selectedIndex == -1)
            {
                return;
            }
            courses.RemoveAt(selectedIndex);
            lbCourses.Items.RemoveAt(selectedIndex);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedCourse = lbCourses.SelectedIndex;
            if (selectedCourse == -1)
            {
                return;
            }
            Course course = courses[selectedCourse];
            tbCourseName.Text = course.Theme;
            dateCourse.Value = course.Date;
            btnAddCourse.Click -= btnAddCourse_Click;
            btnAddCourse.Click -= btnAddCourse_ClickEdit;
            btnAddCourse.Click += btnAddCourse_ClickEdit;
            btnAddCourse.Text = "Сохранить";
        }

        private void deleteContestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbContests.SelectedIndex;
            if (selectedIndex == -1)
            {
                return;
            }
            contests.RemoveAt(selectedIndex);
            lbContests.Items.RemoveAt(selectedIndex);
        }

        private void editContestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedContest = lbContests.SelectedIndex;
            if (selectedContest == -1)
            {
                return;
            }
            Contest contest = contests[selectedContest];
            tbContestName.Text = contest.Title;
            dateContest.Value = contest.Date;

            btnAddContest.Click -= btnAddContest_Click;
            btnAddContest.Click -= btnAddContest_ClickEdit;
            btnAddContest.Click += btnAddContest_ClickEdit;
            btnAddContest.Text = "Сохранить";
        }
    }
}
