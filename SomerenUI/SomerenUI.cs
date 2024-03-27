using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using SomerenDAL;
using System.Linq;

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
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();

            // show dashboard
            pnlDashboard.Show();
        }
        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();

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
        private void ShowDrinksPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlStudents.Hide();

            // show drinks
            pnlDrinks.Show();

            try
            {
                // get and display all students
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        private void ShowActivitiesPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlStudents.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();

            // show activities
            pnlActivities.Show();

            try
            {
                // get and display all students
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }
        private void ShowRoomsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlStudents.Hide();
            pnlDrinks.Hide();

            // show rooms
            pnlRooms.Show();

            try
            {
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);

            }
        }
        private void ShowLecturersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlRooms.Hide();
            pnlActivities.Hide();
            pnlStudents.Hide();
            pnlDrinks.Hide();

            // show lecturers
            pnlLecturers.Show();

            try
            {
                List<Lecturer> lecturers = GetLecturers();
                DisplayLecturers(lecturers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the lecturers: " + e.Message);

            }
        }


        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;

        }
        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it

            listViewRooms.Items.Clear();

            foreach (Room room in rooms)
            {
                ListViewItem li = new ListViewItem(room.Id.ToString());
                li.SubItems.Add(room.Number.ToString());
                li.SubItems.Add(room.Size.ToString());
                li.SubItems.Add(room.Type.ToString());
                //Comment or something anywhere
                li.Tag = room;   // link room object to listview item
                listViewRooms.Items.Add(li);

            }
        }

        private List<Lecturer> GetLecturers()
        {
            LecturerService lecturerService = new LecturerService();
            List<Lecturer> lecturers = lecturerService.GetLecturers();
            return lecturers;
        }
        private void DisplayLecturers(List<Lecturer> lecturers)
        {
            // clear the listview before filling it
            listViewLecturers.Items.Clear();

            foreach (Lecturer lecturer in lecturers)
            {
                ListViewItem list = new ListViewItem(lecturer.LecturerId.ToString());
                list.Tag = lecturer;
                list.SubItems.Add(lecturer.LecturerId.ToString());
                list.SubItems.Add(lecturer.FirstName);
                list.SubItems.Add(lecturer.LastName);
                list.SubItems.Add(lecturer.Age.ToString());
                list.SubItems.Add(lecturer.PhoneNumber.ToString());
                list.SubItems.Add(lecturer.RoomId.ToString());
                listViewLecturers.Items.Add(list);
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
                ListViewItem list = new ListViewItem(student.Name.ToString()); //create ListView
                list.Tag = student;

                //Add SubItems
                list.SubItems.Add(student.Number.ToString());
                list.SubItems.Add(student.Nationality.ToString());
                list.SubItems.Add(student.PhoneNumber.ToString());
                list.SubItems.Add(student.Class.ToString());

                listViewStudents.Items.Add(list);
            }
        }

        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }
        private void DisplayActivities(List<Activity> activities)
        {


            // clear the listview before filling it
            listViewActivities.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem list = new ListViewItem(activity.ActivityId.ToString());
                list.Tag = activity;
                list.SubItems.Add(activity.Name);
                list.SubItems.Add(activity.Day);
                list.SubItems.Add(activity.StartDayTime.ToString());
                list.SubItems.Add(activity.EndDayTime.ToString());
                listViewActivities.Items.Add(list);
            }

        }

        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }
        private void DisplayDrinks(List<Drink> drinks)
        {
            // clear the listview before filling it
            listViewDrinks.Items.Clear();

            foreach (Drink drink in drinks)
            {
                ListViewItem list = new ListViewItem(drink.DrinkId.ToString());

                list.Tag = drink;
                list.SubItems.Add(drink.DrinkId.ToString());
                list.SubItems.Add(drink.DrinkName);
                list.SubItems.Add(drink.IsAlcoholic.ToString());
                list.SubItems.Add(drink.Price.ToString());
                list.SubItems.Add(drink.DrinkType);
                list.SubItems.Add(drink.StockAmount);

                listViewDrinks.Items.Add(list);
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

        private void roomsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLecturersPanel();
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e) { }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) { }

        private void startdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startdateTimePicker.MaxDate = DateTime.Today;
        }

        private void enddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            enddateTimePicker.MaxDate = DateTime.Today;
        }

        public bool IsValidDateWindow(DateTime startDate, DateTime endDate)
        {
            DateTime today = DateTime.Today;

            if (startDate > today || endDate > today || startDate > endDate)
            {
                return false;
            }

            return true;
        }

        private void GenerateRevenueReportButton_Click(object sender, EventArgs e)
        {
            DateTime startDate = startdateTimePicker.Value;
            DateTime endDate = enddateTimePicker.Value;

            try
            {
                RevenueReport report = GenerateRevenueReport(startDate, endDate);
                ShowRevenueReport(report);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private RevenueReport GenerateRevenueReport(DateTime startDate, DateTime endDate)
        {
            RevenueReportDao dao = new RevenueReportDao();

            List<Drink> drinksSold = dao.GetDrinksSoldByDate(startDate, endDate);


            int totalDrinksSold = drinksSold.Sum(d => d.Sold);
            float turnover = drinksSold.Sum(d => d.Price * d.Sold);


            // Oluşturulan raporu döndür
            return new RevenueReport
            {
                TotalDrinksSold = totalDrinksSold,
                Turnover = turnover,
                //NumberOfCustomers = numberOfCustomers
            };
        }

        private void ShowRevenueReport(RevenueReport report)
        {
            string message = $"Total Drinks Sold: {report.TotalDrinksSold}\n" +
                             $"Turnover: {report.Turnover}\n" +
                             $"Number of Customers: {report.NumberOfCustomers}";

            revenueReporttextBox.Text = message;
        }

        
    }
}
