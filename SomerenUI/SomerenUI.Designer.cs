using System.Windows.Forms;

namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            lecturersToolStripMenuItem = new ToolStripMenuItem();
            activitiesToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem1 = new ToolStripMenuItem();
            drinksToolStripMenuItem = new ToolStripMenuItem();
            pnlDashboard = new Panel();
            lblDashboard = new Label();
            pnlStudents = new Panel();
            pictureBox1 = new PictureBox();
            listViewStudents = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            label1 = new Label();
            pnlLecturers = new Panel();
            pnlActivities = new Panel();
            pnlRooms = new Panel();
            pnlDrinks = new Panel();
            revenueReporttextBox = new TextBox();
            enddateTimePicker = new DateTimePicker();
            GenerateRevenueReportButton = new Button();
            startdateTimePicker = new DateTimePicker();
            pictureBox5 = new PictureBox();
            listViewDrinks = new ListView();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            listViewRooms = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            listViewActivities = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            listViewLecturers = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            label2 = new Label();
            panelRevenue = new Panel();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            pictureBox6 = new PictureBox();
            listView1 = new ListView();
            columnHeader27 = new ColumnHeader();
            columnHeader28 = new ColumnHeader();
            columnHeader29 = new ColumnHeader();
            columnHeader30 = new ColumnHeader();
            columnHeader31 = new ColumnHeader();
            columnHeader32 = new ColumnHeader();
            label6 = new Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLecturers.SuspendLayout();
            pnlActivities.SuspendLayout();
            pnlRooms.SuspendLayout();
            pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem1, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 5, 0, 5);
            menuStrip1.Size = new System.Drawing.Size(1786, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(154, 36);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(262, 44);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(262, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(130, 36);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(129, 36);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem1
            // 
            roomsToolStripMenuItem1.Name = "roomsToolStripMenuItem1";
            roomsToolStripMenuItem1.Size = new System.Drawing.Size(106, 36);
            roomsToolStripMenuItem1.Text = "Rooms";
            roomsToolStripMenuItem1.Click += roomsToolStripMenuItem1_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(101, 36);
            drinksToolStripMenuItem.Text = "Drinks";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(23, 58);
            pnlDashboard.Margin = new Padding(5, 6, 5, 6);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1742, 994);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(24, 27);
            lblDashboard.Margin = new Padding(5, 0, 5, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(421, 32);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(23, 58);
            pnlStudents.Margin = new Padding(5, 6, 5, 6);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1742, 994);
            pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1495, 0);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(242, 262);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listViewStudents.Location = new System.Drawing.Point(29, 90);
            listViewStudents.Margin = new Padding(5, 6, 5, 6);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1419, 865);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = View.Details;
            listViewStudents.SelectedIndexChanged += listViewStudents_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Number";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nationality";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Phone number";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(24, 14);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(211, 65);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlLecturers
            // 
            pnlLecturers.Controls.Add(pnlActivities);
            pnlLecturers.Controls.Add(pictureBox2);
            pnlLecturers.Controls.Add(listViewLecturers);
            pnlLecturers.Controls.Add(label2);
            pnlLecturers.Location = new System.Drawing.Point(24, 58);
            pnlLecturers.Margin = new Padding(5, 6, 5, 6);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new System.Drawing.Size(1742, 994);
            pnlLecturers.TabIndex = 3;
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(pnlRooms);
            pnlActivities.Controls.Add(pictureBox3);
            pnlActivities.Controls.Add(listViewActivities);
            pnlActivities.Controls.Add(label3);
            pnlActivities.Location = new System.Drawing.Point(0, 0);
            pnlActivities.Margin = new Padding(5, 6, 5, 6);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1742, 994);
            pnlActivities.TabIndex = 4;
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(pnlDrinks);
            pnlRooms.Controls.Add(pictureBox4);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(label4);
            pnlRooms.Location = new System.Drawing.Point(0, 0);
            pnlRooms.Margin = new Padding(5, 6, 5, 6);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1742, 994);
            pnlRooms.TabIndex = 5;
            // 
            // pnlDrinks
            // 
            pnlDrinks.Controls.Add(revenueReporttextBox);
            pnlDrinks.Controls.Add(enddateTimePicker);
            pnlDrinks.Controls.Add(GenerateRevenueReportButton);
            pnlDrinks.Controls.Add(startdateTimePicker);
            pnlDrinks.Controls.Add(pictureBox5);
            pnlDrinks.Controls.Add(listViewDrinks);
            pnlDrinks.Controls.Add(label5);
            pnlDrinks.Location = new System.Drawing.Point(99, 100);
            pnlDrinks.Margin = new Padding(5, 6, 5, 6);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1742, 994);
            pnlDrinks.TabIndex = 6;
            // 
            // revenueReporttextBox
            // 
            revenueReporttextBox.Location = new System.Drawing.Point(1002, 731);
            revenueReporttextBox.Multiline = true;
            revenueReporttextBox.Name = "revenueReporttextBox";
            revenueReporttextBox.Size = new System.Drawing.Size(342, 162);
            revenueReporttextBox.TabIndex = 10;
            // 
            // enddateTimePicker
            // 
            enddateTimePicker.Location = new System.Drawing.Point(970, 528);
            enddateTimePicker.Name = "enddateTimePicker";
            enddateTimePicker.Size = new System.Drawing.Size(400, 39);
            enddateTimePicker.TabIndex = 9;
            enddateTimePicker.ValueChanged += enddateTimePicker_ValueChanged;
            // 
            // GenerateRevenueReportButton
            // 
            GenerateRevenueReportButton.Location = new System.Drawing.Point(1035, 591);
            GenerateRevenueReportButton.Name = "GenerateRevenueReportButton";
            GenerateRevenueReportButton.Size = new System.Drawing.Size(286, 107);
            GenerateRevenueReportButton.TabIndex = 7;
            GenerateRevenueReportButton.Text = "Generate report";
            GenerateRevenueReportButton.UseVisualStyleBackColor = true;
            GenerateRevenueReportButton.Click += GenerateRevenueReportButton_Click;
            // 
            // startdateTimePicker
            // 
            startdateTimePicker.Location = new System.Drawing.Point(970, 483);
            startdateTimePicker.Name = "startdateTimePicker";
            startdateTimePicker.Size = new System.Drawing.Size(400, 39);
            startdateTimePicker.TabIndex = 8;
            startdateTimePicker.ValueChanged += startdateTimePicker_ValueChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(1495, 0);
            pictureBox5.Margin = new Padding(5, 6, 5, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(242, 262);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // listViewDrinks
            // 
            listViewDrinks.Columns.AddRange(new ColumnHeader[] { columnHeader21, columnHeader22, columnHeader23, columnHeader24, columnHeader25, columnHeader26 });
            listViewDrinks.Location = new System.Drawing.Point(29, 90);
            listViewDrinks.Margin = new Padding(5, 6, 5, 6);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(1419, 865);
            listViewDrinks.TabIndex = 1;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = View.Details;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Drink ID";
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Name";
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Alcoholic";
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "Price";
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "Type";
            // 
            // columnHeader26
            // 
            columnHeader26.Text = "Stock amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(24, 14);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(162, 65);
            label5.TabIndex = 0;
            label5.Text = "Drinks";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(1495, 0);
            pictureBox4.Margin = new Padding(5, 6, 5, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(242, 262);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader18, columnHeader19, columnHeader20 });
            listViewRooms.Location = new System.Drawing.Point(29, 90);
            listViewRooms.Margin = new Padding(5, 6, 5, 6);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1419, 865);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = View.Details;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Room ID";
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Foor number";
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Size";
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(24, 14);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(173, 65);
            label4.TabIndex = 0;
            label4.Text = "Rooms";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(1495, 0);
            pictureBox3.Margin = new Padding(5, 6, 5, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(242, 262);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewActivities
            // 
            listViewActivities.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            listViewActivities.Location = new System.Drawing.Point(29, 90);
            listViewActivities.Margin = new Padding(5, 6, 5, 6);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(1419, 865);
            listViewActivities.TabIndex = 1;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            listViewActivities.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Activity ID";
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Name";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Day";
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Start time";
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "End time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(24, 14);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(217, 65);
            label3.TabIndex = 0;
            label3.Text = "Activities";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1495, 0);
            pictureBox2.Margin = new Padding(5, 6, 5, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(242, 262);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listViewLecturers.Location = new System.Drawing.Point(29, 90);
            listViewLecturers.Margin = new Padding(5, 6, 5, 6);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(1419, 865);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Lecturer ID";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "First name";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Last Name";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Age";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Phone number";
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Room ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(24, 14);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(220, 65);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // panelRevenue
            // 
            panelRevenue.Controls.Add(textBox1);
            panelRevenue.Controls.Add(dateTimePicker1);
            panelRevenue.Controls.Add(button1);
            panelRevenue.Controls.Add(dateTimePicker2);
            panelRevenue.Controls.Add(pictureBox6);
            panelRevenue.Controls.Add(listView1);
            panelRevenue.Controls.Add(label6);
            panelRevenue.Location = new System.Drawing.Point(22, 72);
            panelRevenue.Margin = new Padding(5, 6, 5, 6);
            panelRevenue.Name = "panelRevenue";
            panelRevenue.Size = new System.Drawing.Size(1742, 963);
            panelRevenue.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(712, 211);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(451, 538);
            textBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(188, 356);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(400, 39);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(242, 488);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(286, 107);
            button1.TabIndex = 7;
            button1.Text = "Generate report";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new System.Drawing.Point(188, 279);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new System.Drawing.Size(400, 39);
            dateTimePicker2.TabIndex = 8;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (System.Drawing.Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new System.Drawing.Point(1495, 0);
            pictureBox6.Margin = new Padding(5, 6, 5, 6);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new System.Drawing.Size(242, 262);
            pictureBox6.TabIndex = 2;
            pictureBox6.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader27, columnHeader28, columnHeader29, columnHeader30, columnHeader31, columnHeader32 });
            listView1.Location = new System.Drawing.Point(66, 85);
            listView1.Margin = new Padding(5, 6, 5, 6);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(1419, 865);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
          
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Drink ID";
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "Name";
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "Alcoholic";
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "Price";
            // 
            // columnHeader31
            // 
            columnHeader31.Text = "Type";
            // 
            // columnHeader32
            // 
            columnHeader32.Text = "Stock amount";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(24, 14);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(363, 65);
            label6.TabIndex = 0;
            label6.Text = "Revenue Report";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1786, 1077);
            Controls.Add(panelRevenue);
            Controls.Add(pnlLecturers);
            Controls.Add(menuStrip1);
            Controls.Add(pnlStudents);
            Controls.Add(pnlDashboard);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLecturers.ResumeLayout(false);
            pnlLecturers.PerformLayout();
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelRevenue.ResumeLayout(false);
            panelRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem lecturersToolStripMenuItem;
        private ToolStripMenuItem activitiesToolStripMenuItem;
        private ToolStripMenuItem drinksToolStripMenuItem;
        private Panel pnlDashboard;
        private Label lblDashboard;
        private Panel pnlStudents;
        private PictureBox pictureBox1;
        private ListView listViewStudents;
        private Label label1;
        private Panel pnlLecturers;
        private Panel pnlRooms;
        private PictureBox pictureBox4;
        private ListView listViewRooms;
        private Label label4;
        private Panel pnlActivities;
        private PictureBox pictureBox3;
        private ListView listViewActivities;
        private Label label3;
        private PictureBox pictureBox2;
        private ListView listViewLecturers;
        private Label label2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ToolStripMenuItem roomsToolStripMenuItem1;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private Panel pnlDrinks;
        private PictureBox pictureBox5;
        private ListView listViewDrinks;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private ColumnHeader columnHeader26;
        private Label label5;
        private TextBox revenueReporttextBox;
        private DateTimePicker enddateTimePicker;
        private Button GenerateRevenueReportButton;
        private DateTimePicker startdateTimePicker;
        private Panel panelRevenue;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DateTimePicker dateTimePicker2;
        private PictureBox pictureBox6;
        private ListView listView1;
        private ColumnHeader columnHeader27;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
        private Label label6;
    }
}