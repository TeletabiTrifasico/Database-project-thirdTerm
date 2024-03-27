using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Drawing;

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
            pnlDrinkSupplies.Hide();

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
        private void ShowDrinkSuppliesPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlLecturers.Hide();
            pnlActivities.Hide();
            pnlRooms.Hide();
            pnlStudents.Hide();
            pnlDrinks.Hide();

            // show drink supplies panel
            pnlDrinkSupplies.Show();

            try
            {
                // get and display all drink supplies
                List<Drink> drinkSupplies = GetDrinkSupplies();
                DisplayDrinkSupplies(drinkSupplies);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the drink supplies: " + e.Message);
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
            pnlDrinkSupplies.Hide();
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
            pnlDrinkSupplies.Hide();

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
            pnlDrinkSupplies.Hide();

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
                list.SubItems.Add(drink.DrinkName);
                list.SubItems.Add(drink.IsAlcoholic?"Yes":"No");
                list.SubItems.Add(drink.Price.ToString());
                list.SubItems.Add(drink.DrinkType);
                list.SubItems.Add(drink.StockAmount);
                list.SubItems.Add(drink.Sold.ToString());

                listViewDrinks.Items.Add(list);
            }
        }


        //check stock status according to stockamount
        private void CheckStockStatus(Drink drink, ListViewItem listItem)
        {
            int stockAmount = int.Parse(drink.StockAmount);
            string stockstatus = "";

            if (stockAmount <= 0)
            {
                stockstatus = "Stock Empty";
            }
            else if (stockAmount < 20)
            {
                stockstatus = "Stock Nearly Depleted";
            }
            else 
            {
                stockstatus = "Stock Sufficient";
            }
            listItem.SubItems.Add(stockstatus);
        }

        private List<Drink> GetDrinkSupplies()
        {

            DrinkService drinkService = new DrinkService();
            List<Drink> drinkSupplies = drinkService.GetDrinkSupplies();
            return drinkSupplies;
        }

        private void DisplayDrinkSupplies(List<Drink> drinkSupplies)
        {
            // clear the listview before filling it
            listViewDrinkSupplies.Items.Clear();

            foreach (Drink drink in drinkSupplies)
            {
                // Create a ListViewItem for each drink 
                ListViewItem listItem = new ListViewItem(drink.DrinkName.ToString());
                listItem.SubItems.Add(drink.DrinkId.ToString());
                listItem.SubItems.Add(drink.IsAlcoholic ? "Yes" : "No");
                listItem.SubItems.Add(drink.Price.ToString());
                listItem.SubItems.Add(drink.DrinkType);
                listItem.SubItems.Add(drink.Sold.ToString());
                listItem.Tag = drink;

                // Check stock status 
                CheckStockStatus(drink, listItem);

                // Add the ListViewItem to the ListView
                listViewDrinkSupplies.Items.Add(listItem);
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

        private void drinkSuppliesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinkSuppliesPanel();
        }

        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            AddDrinkForm addDrinkForm = new AddDrinkForm();
            addDrinkForm.ShowDialog();
            List<Drink> drinks = GetDrinkSupplies();
            DisplayDrinkSupplies(drinks);
        }
        private void btnUpdateDrink_Click(object sender, EventArgs e)
        {
            if (listViewDrinkSupplies.SelectedItems.Count==1)
            {
                Drink selectedDrink = (Drink)listViewDrinkSupplies.SelectedItems[0].Tag;
                UpdateDrinkForm updateDrinkForm = new UpdateDrinkForm(selectedDrink);
                updateDrinkForm.ShowDialog();
                List<Drink> drinks = GetDrinkSupplies();
                DisplayDrinkSupplies(drinks);
            }
            else
            {
                MessageBox.Show("Please select a drink to update.");
            }

        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            if (listViewDrinkSupplies.SelectedItems.Count == 1)
            {
                Drink selectedDrink = (Drink)listViewDrinkSupplies.SelectedItems[0].Tag; 
                int drinkId = selectedDrink.DrinkId; 
                try
                {
                    DrinkService drinkService = new DrinkService();
                    drinkService.DeleteDrink(selectedDrink); 
                    MessageBox.Show("Drink deleted successfully.");
                    List<Drink> drinks = GetDrinkSupplies();
                    DisplayDrinkSupplies(drinks); // Refresh the list
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the drink: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a drink to delete.");
            }
        }
    }

}

