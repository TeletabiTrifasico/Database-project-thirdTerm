using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem name = new ListViewItem(student.Name);
                ListViewItem number = new ListViewItem(student.Number.ToString());
                ListViewItem nationality = new ListViewItem(student.Nationality);
                ListViewItem phoneNumber = new ListViewItem(student.PhoneNumber.ToString());
                ListViewItem clas = new ListViewItem(student.Class.ToString());
                name.Tag = student;   // link student object to listview item
                number.Tag = student;
                nationality.Tag = student;
                phoneNumber.Tag = student;
                clas.Tag = student;   
                listViewStudents.Items.Add(name);
                listViewStudents.Items.Add(number);
                listViewStudents.Items.Add(nationality);
                listViewStudents.Items.Add(phoneNumber);
                listViewStudents.Items.Add(clas);
            }
        }

        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }
    }
}
