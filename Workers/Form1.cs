using BusinessLogic;
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
    public delegate void AddPerson(Person person);
    public delegate void EditPerson(Person person, int index);
    public delegate void SearchPeople(SearchParams searchParams);
    public partial class Form1 : Form
    {
        public event AddPerson PersonAdded;
        public event EditPerson PersonEdited;
        public event SearchPeople Searching;

        //TODO: протестировать и отладить поиск, сделать экспорт и восстановление через бекап, переписать Person.GetArray() на лист
        List<Person> displayedPeople = new List<Person>();
        PeopleManager peopleManager;
        DateTime date;
        public Form1()
        {
            InitializeComponent();

            PersonAdded += OnPersonAdded;
            PersonEdited += OnPersonEdited;
            Searching += OnSearching; 
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            peopleManager = new PeopleManager();
            displayedPeople = await peopleManager.Init();
            date = DateTime.Now;
            SetupGrid();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            lbDate.Text = date.ToString("dd.MM.yyyy");
            dataGrid.Rows.Clear();
            if (displayedPeople != null)
            {
                for (int i = 0; i < displayedPeople.Count; i++)
                {
                    List<string> ps = displayedPeople[i].GetArray(date);
                    ps.Insert(0, (i+1).ToString());
                    dataGrid.Rows.Add(ps.ToArray());
                    if (DateCalculator.DifferenceInYears(DateTime.Now, displayedPeople[i].HireDate) >= 2 && displayedPeople[i].Qualification.QualificationCategorie == QualificationCategorie.Not)
                    {
                        dataGrid.Rows[i].Cells[1].Style.BackColor = Color.Red;
                        dataGrid.Rows[i].Cells[6].Style.BackColor = Color.Yellow;
                        dataGrid.Rows[i].Cells[10].Style.BackColor = Color.Yellow;
                        dataGrid.Rows[i].Cells[1].Style.SelectionBackColor = Color.Red;
                        dataGrid.Rows[i].Cells[6].Style.SelectionBackColor = Color.Yellow;
                        dataGrid.Rows[i].Cells[10].Style.SelectionBackColor = Color.Yellow;
                        dataGrid.Rows[i].Cells[1].Style.SelectionForeColor = Color.Black;
                        dataGrid.Rows[i].Cells[6].Style.SelectionForeColor = Color.Black;
                        dataGrid.Rows[i].Cells[10].Style.SelectionForeColor = Color.Black;
                    }
                }
            }
            dataGrid.AutoResizeColumn(1, DataGridViewAutoSizeColumnMode.AllCells);
        }

        private void SetupGrid()
        {
            dataGrid.ColumnCount = 12;
            dataGrid.Columns[0].HeaderText = "№";
            dataGrid.Columns[1].HeaderText = "ФИО";
            dataGrid.Columns[2].HeaderText = "Дата рождения";
            dataGrid.Columns[3].HeaderText = "Возраст";
            dataGrid.Columns[4].HeaderText = "Образование";
            dataGrid.Columns[5].HeaderText = "Повышение квалификации";
            dataGrid.Columns[6].HeaderText = "Дата приема";
            dataGrid.Columns[7].HeaderText = "Стаж работы (в организации)";
            dataGrid.Columns[8].HeaderText = "Стаж работы (общий)";
            dataGrid.Columns[9].HeaderText = "Участие в конкурсе";
            dataGrid.Columns[10].HeaderText = "Квалификационная категория";
            dataGrid.Columns[11].HeaderText = "Уволен";
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
        }

        //Events
        private async void OnPersonAdded(Person person)
        {
            person = await peopleManager.AddPerson(person);
            displayedPeople.Add(person);
            UpdateDataGrid();
        }

        private async void OnPersonEdited(Person person, int index)
        {
            await peopleManager.EditPerson(person);
            displayedPeople[index] = person;
            UpdateDataGrid();
        }

        private void OnSearching(SearchParams searchParams)
        {
            displayedPeople = peopleManager.Search(searchParams);
            date = searchParams.Date;
            UpdateDataGrid();
        }

        //Clicks
        private void addWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonDetailForm form = new PersonDetailForm(PersonAdded);
            form.ShowDialog(this);
        }

        private async void deleteSelectedWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows[0] == null)
            {
                return;
            }
            int selectedIndex = dataGrid.SelectedRows[0].Index;
            await peopleManager.DeletePerson(displayedPeople[selectedIndex]);
            displayedPeople.RemoveAt(selectedIndex);
            UpdateDataGrid();
        }

        private void editSelectedWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows[0] == null)
            {
                return;
            }
            int selectedIndex = dataGrid.SelectedRows[0].Index;
            PersonDetailForm form = new PersonDetailForm(PersonEdited, displayedPeople[selectedIndex], selectedIndex);
            form.ShowDialog(this);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(Searching);
            searchForm.ShowDialog(this);
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayedPeople = peopleManager.GetPeople();
            date = DateTime.Now;
            UpdateDataGrid();
        }

        private void txtFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                peopleManager.Export(saveFileDialog.FileName, displayedPeople, date);
            }
        }

        private async void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файл JSON (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                displayedPeople = await peopleManager.OpenFile(openFileDialog.FileName);
                date = DateTime.Now;
                UpdateDataGrid();
            }
        }
    }
}
