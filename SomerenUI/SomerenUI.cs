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
        private void ShowRoomsPanel()
        {
            pnlDashboard.Hide();

            pnlStudents.Hide();

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

        // LIST ACTIVITIES
        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivities();
            return activities;
        }
        // DISPLAY ACTIVITIES
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

        //LIST DRINKS
        private List<Drink> GetDrinks()
        {
            DrinkService drinkService = new DrinkService();
            List<Drink> drinks = drinkService.GetDrinks();
            return drinks;
        }

        //DISPLAY DRINKS
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
        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
