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

        //Show panel method (hides all panes and only shows the one that has to be seen)
        private void ShowPanel(Panel panel)
        {
            pnlStudents.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlDrinks.Hide();
            pnlDashboard.Hide();

            panel.Show();
        }

        //Shows panel dashboard
        private void ShowDashboardPanel()
        {
            ShowPanel(pnlDashboard);
        }

        //shows panel students
        private void ShowStudentsPanel()
        {
            ShowPanel(pnlStudents);

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

        //shows panel drinks
        private void ShowDrinksPanel()
        {
            ShowPanel(pnlDrinks);

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

        //shows panel Activities
        private void ShowActivitiesPanel()
        {
            ShowPanel(pnlActivities);

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

        //shows panel Rooms
        private void ShowRoomsPanel()
        {
            ShowPanel(pnlRooms);

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

        //shows panel Lecturers
        private void ShowLecturersPanel()
        {
            ShowPanel(pnlLecturers);

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

        //Gets and displays rooms into a ListView
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
                li.Tag = room;   // link room object to listview item
                listViewRooms.Items.Add(li);

            }
        }

        //Gets and displays lecturers into a ListView
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

        //Gets and displays students into a ListView
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

        //Gets and displays activities into a ListView
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

        //Gets and displays drinks into a ListView
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
