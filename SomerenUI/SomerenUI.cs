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

        private void HideAllPanels()
        {
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlDashboard.Hide();
        }
        private void ShowDashboardPanel()
        {
            // hide all other panels
            HideAllPanels();

            // show dashboard
            pnlDashboard.Show();
        }
        private void ShowStudentsPanel()
        {
            // hide all other panels
            HideAllPanels();

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
            HideAllPanels();

            // show drinks
            pnlDrinks.Show();

            try
            {
                // get and display all students
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);

                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drinks: " + e.Message);
            }
        }
        private void ShowActivitiesPanel()
        {
            // hide all other panels
            HideAllPanels();

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
            HideAllPanels();

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
            HideAllPanels();

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
            listView1.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem list1 = new ListViewItem(student.FirstName.ToString()); //create ListView
                list1.Tag = student;

                //Add SubItems
                list1.SubItems.Add(student.LastName.ToString());
                list1.SubItems.Add(student.Number.ToString());
                list1.SubItems.Add(student.Nationality.ToString());
                list1.SubItems.Add(student.PhoneNumber.ToString());
                list1.SubItems.Add(student.Class.ToString());

                listView1.Items.Add(list1);
            }

            foreach (Student student in students)
            {
                ListViewItem list2 = new ListViewItem(student.FirstName.ToString()); //create ListView
                list2.Tag = student;

                //Add SubItems
                list2.SubItems.Add(student.LastName.ToString());
                list2.SubItems.Add(student.Number.ToString());
                list2.SubItems.Add(student.Nationality.ToString());
                list2.SubItems.Add(student.PhoneNumber.ToString());
                list2.SubItems.Add(student.Class.ToString());

                listViewStudents.Items.Add(list2);
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
        private void pnlDrinks_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pnlRooms_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pnlRooms_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
