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
    public partial class SearchForm : Form
    {
        event SearchPeople search;
        private SearchParams searchParams;
        public SearchForm(SearchPeople search)
        {
            InitializeComponent();
            this.search = search;
            dateDate.Value = DateTime.Now;
            foreach (Control control in Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control c in panel.Controls)
                    {
                        if (c is DateTimePicker picker)
                        {
                            picker.Format = DateTimePickerFormat.Custom;
                            picker.CustomFormat = " ";
                            picker.Value = picker.MinDate;
                            picker.KeyDown += new KeyEventHandler((object sender, KeyEventArgs args) => { OnPickerKeyDown(picker, args); });
                            picker.MouseDown += new MouseEventHandler((object sender, MouseEventArgs args) => { OnPickerClick(picker); });
                        }
                    }
                }
            }
        }

        private void btnFindPeople_Click(object sender, EventArgs e)
        {
            searchParams = new SearchParams();
            searchParams.Name = tbName.Text;
            searchParams.Date = dateDate.Value;
            searchParams.Education = new Education() { Degree = cbEducationGrade.SelectedIndex == -1 ? Degree.none : (Degree)cbEducationGrade.SelectedIndex, Place = tbEducationPlace.Text };
            searchParams.EducationStart = GetDate(dateEducation1);
            searchParams.EducationEnd = GetDate(dateEducation2);
            searchParams.Qualification = new Qualification() { QualificationCategorie = cbQualification.SelectedIndex == -1 ? QualificationCategorie.none : (QualificationCategorie)cbQualification.SelectedIndex };
            searchParams.Course = new Course() { Theme = tbCourseName.Text };
            searchParams.CourseStart = GetDate(dateCourse1);
            searchParams.CourseEnd = GetDate(dateCourse2);
            searchParams.Contest = new Contest() { Title = tbContestName.Text };
            searchParams.ContestStart = GetDate(dateContest1);
            searchParams.ContestEnd = GetDate(dateContest2);
            searchParams.QualificationStart = GetDate(dateQualification1);
            searchParams.QualificationEnd = GetDate(dateQualification2);
            try
            {
                searchParams.AgeStart = TryReadInt(tbAge1);
                searchParams.AgeEnd = TryReadInt(tbAge2);
                searchParams.LocalExpirienceStart = TryReadInt(tbLocalExpirience1);
                searchParams.LocalExpirienceEnd = TryReadInt(tbLocalExpirience2);
                searchParams.AllExpirienceStart = TryReadInt(tbAllExpirience1);
                searchParams.AllExpirienceEnd = TryReadInt(tbAllExpirience2);
            }
            catch (Exception)
            {
                return;
            }
            searchParams.IsFired = chBoxIsFired.Checked;
            search(searchParams);
            Close();
        }

        private void OnPickerKeyDown(DateTimePicker picker, KeyEventArgs args)
        {
            if (args.KeyCode == Keys.Back)
            {
                picker.Format = DateTimePickerFormat.Custom;
                picker.Value = picker.MinDate;
                picker.CustomFormat = " ";
            }
        }

        private void OnPickerClick(DateTimePicker picker)
        {
            picker.Format = DateTimePickerFormat.Short;
        }

        private DateTime GetDate(DateTimePicker picker)
        {
            return picker.Value == picker.MinDate ? new DateTime() : picker.Value;
        }

        private int TryReadInt(TextBox textBox)
        {
            int sum;
            if (textBox.Text == "")
            {
                sum = -1;
            }
            else
            {
                try
                {
                    sum = int.Parse(textBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Введите корректные значения в ограничения по возрасту или стажу", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }
            return sum;
        }
    }
}
