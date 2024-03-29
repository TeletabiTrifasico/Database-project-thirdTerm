﻿using System.Windows.Forms;

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
            columnHeader27 = new ColumnHeader();
            label1 = new Label();
            pnlLecturers = new Panel();
            pictureBox2 = new PictureBox();
            listViewLecturers = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            label2 = new Label();
            pnlDrinks = new Panel();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            txtQuantity = new Label();
            textBox1 = new TextBox();
            txtPrice = new Label();
            btnPlaceOrder = new Button();
            listView1 = new ListView();
            columnHeader28 = new ColumnHeader();
            columnHeader29 = new ColumnHeader();
            columnHeader30 = new ColumnHeader();
            columnHeader31 = new ColumnHeader();
            columnHeader32 = new ColumnHeader();
            columnHeader33 = new ColumnHeader();
            label6 = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtQuarter = new Label();
            txtbxYear = new TextBox();
            txtYear = new Label();
            pictureBox5 = new PictureBox();
            listViewDrinks = new ListView();
            columnHeader21 = new ColumnHeader();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
            label5 = new Label();
            pnlActivities = new Panel();
            pictureBox3 = new PictureBox();
            listViewActivities = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            label3 = new Label();
            pnlRooms = new Panel();
            pictureBox4 = new PictureBox();
            listViewRooms = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLecturers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            pnlActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem1, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1100, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem1
            // 
            roomsToolStripMenuItem1.Name = "roomsToolStripMenuItem1";
            roomsToolStripMenuItem1.Size = new System.Drawing.Size(69, 24);
            roomsToolStripMenuItem1.Text = "Rooms";
            roomsToolStripMenuItem1.Click += roomsToolStripMenuItem1_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            drinksToolStripMenuItem.Text = "Drinks";
            drinksToolStripMenuItem.Click += drinksToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(262, 20);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(14, 36);
            pnlStudents.Margin = new Padding(3, 4, 3, 4);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1072, 621);
            pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(920, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(149, 164);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader27 });
            listViewStudents.Location = new System.Drawing.Point(18, 56);
            listViewStudents.Margin = new Padding(3, 4, 3, 4);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(875, 542);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = View.Details;
            listViewStudents.SelectedIndexChanged += listViewStudents_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "FirstName";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Last name";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Student number";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nationality";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Phone number";
            columnHeader5.Width = 110;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Class";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(15, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 41);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // pnlLecturers
            // 
            pnlLecturers.Controls.Add(pictureBox2);
            pnlLecturers.Controls.Add(listViewLecturers);
            pnlLecturers.Controls.Add(label2);
            pnlLecturers.Location = new System.Drawing.Point(11, 34);
            pnlLecturers.Margin = new Padding(3, 4, 3, 4);
            pnlLecturers.Name = "pnlLecturers";
            pnlLecturers.Size = new System.Drawing.Size(1072, 621);
            pnlLecturers.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(920, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(149, 164);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // listViewLecturers
            // 
            listViewLecturers.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11 });
            listViewLecturers.Location = new System.Drawing.Point(18, 56);
            listViewLecturers.Margin = new Padding(3, 4, 3, 4);
            listViewLecturers.Name = "listViewLecturers";
            listViewLecturers.Size = new System.Drawing.Size(875, 542);
            listViewLecturers.TabIndex = 1;
            listViewLecturers.UseCompatibleStateImageBehavior = false;
            listViewLecturers.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Lecturer ID";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "First name";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Last Name";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Age";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Phone number";
            columnHeader10.Width = 120;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Room ID";
            columnHeader11.Width = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(15, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(138, 41);
            label2.TabIndex = 0;
            label2.Text = "Lecturers";
            // 
            // pnlDrinks
            // 
            pnlDrinks.Controls.Add(label7);
            pnlDrinks.Controls.Add(numericUpDown1);
            pnlDrinks.Controls.Add(txtQuantity);
            pnlDrinks.Controls.Add(textBox1);
            pnlDrinks.Controls.Add(txtPrice);
            pnlDrinks.Controls.Add(btnPlaceOrder);
            pnlDrinks.Controls.Add(listView1);
            pnlDrinks.Controls.Add(label6);
            pnlDrinks.Controls.Add(radioButton4);
            pnlDrinks.Controls.Add(radioButton3);
            pnlDrinks.Controls.Add(radioButton2);
            pnlDrinks.Controls.Add(radioButton1);
            pnlDrinks.Controls.Add(txtQuarter);
            pnlDrinks.Controls.Add(txtbxYear);
            pnlDrinks.Controls.Add(txtYear);
            pnlDrinks.Controls.Add(pictureBox5);
            pnlDrinks.Controls.Add(listViewDrinks);
            pnlDrinks.Controls.Add(label5);
            pnlDrinks.Location = new System.Drawing.Point(5, 34);
            pnlDrinks.Margin = new Padding(3, 4, 3, 4);
            pnlDrinks.Name = "pnlDrinks";
            pnlDrinks.Size = new System.Drawing.Size(1072, 621);
            pnlDrinks.TabIndex = 6;
            pnlDrinks.Paint += pnlDrinks_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(649, 330);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(101, 20);
            label7.TabIndex = 18;
            label7.Text = "Student name";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(641, 126);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(150, 27);
            numericUpDown1.TabIndex = 17;
            // 
            // txtQuantity
            // 
            txtQuantity.AutoSize = true;
            txtQuantity.Location = new System.Drawing.Point(641, 103);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(65, 20);
            txtQuantity.TabIndex = 16;
            txtQuantity.Text = "Quantity";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(641, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(125, 27);
            textBox1.TabIndex = 15;
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Location = new System.Drawing.Point(641, 35);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(41, 20);
            txtPrice.TabIndex = 14;
            txtPrice.Text = "Price";
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new System.Drawing.Point(641, 404);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new System.Drawing.Size(127, 29);
            btnPlaceOrder.TabIndex = 13;
            btnPlaceOrder.Text = "Place order";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader28, columnHeader29, columnHeader30, columnHeader31, columnHeader32, columnHeader33 });
            listView1.FullRowSelect = true;
            listView1.Location = new System.Drawing.Point(15, 347);
            listView1.Name = "listView1";
            listView1.Size = new System.Drawing.Size(564, 217);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "First name";
            columnHeader28.Width = 80;
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "Last name";
            columnHeader29.Width = 80;
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "Sutent number";
            columnHeader30.Width = 110;
            // 
            // columnHeader31
            // 
            columnHeader31.Text = "Nationality";
            columnHeader31.Width = 90;
            // 
            // columnHeader32
            // 
            columnHeader32.Text = "Phone number";
            columnHeader32.Width = 110;
            // 
            // columnHeader33
            // 
            columnHeader33.Text = "Class";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(15, 292);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(134, 41);
            label6.TabIndex = 11;
            label6.Text = "Students";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new System.Drawing.Point(910, 307);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(49, 24);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.Text = "Q4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new System.Drawing.Point(910, 277);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(49, 24);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Q3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new System.Drawing.Point(910, 247);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(49, 24);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Q2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new System.Drawing.Point(910, 217);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(49, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Q1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtQuarter
            // 
            txtQuarter.AutoSize = true;
            txtQuarter.Location = new System.Drawing.Point(905, 194);
            txtQuarter.Name = "txtQuarter";
            txtQuarter.Size = new System.Drawing.Size(62, 20);
            txtQuarter.TabIndex = 5;
            txtQuarter.Text = "Quarter:";
            // 
            // txtbxYear
            // 
            txtbxYear.Location = new System.Drawing.Point(910, 160);
            txtbxYear.Name = "txtbxYear";
            txtbxYear.Size = new System.Drawing.Size(125, 27);
            txtbxYear.TabIndex = 4;
            // 
            // txtYear
            // 
            txtYear.AutoSize = true;
            txtYear.Location = new System.Drawing.Point(905, 135);
            txtYear.Name = "txtYear";
            txtYear.Size = new System.Drawing.Size(40, 20);
            txtYear.TabIndex = 3;
            txtYear.Text = "Year:";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(920, 0);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(149, 126);
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // listViewDrinks
            // 
            listViewDrinks.Columns.AddRange(new ColumnHeader[] { columnHeader21, columnHeader22, columnHeader23, columnHeader24, columnHeader25, columnHeader26 });
            listViewDrinks.FullRowSelect = true;
            listViewDrinks.Location = new System.Drawing.Point(18, 56);
            listViewDrinks.Margin = new Padding(3, 4, 3, 4);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new System.Drawing.Size(561, 215);
            listViewDrinks.TabIndex = 1;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            listViewDrinks.View = View.Details;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Drink ID";
            columnHeader21.Width = 70;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Name";
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Alcoholic";
            columnHeader23.Width = 80;
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
            columnHeader26.Width = 110;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(15, 9);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 41);
            label5.TabIndex = 0;
            label5.Text = "Drinks";
            // 
            // pnlActivities
            // 
            pnlActivities.Controls.Add(pictureBox3);
            pnlActivities.Controls.Add(listViewActivities);
            pnlActivities.Controls.Add(label3);
            pnlActivities.Location = new System.Drawing.Point(5, 36);
            pnlActivities.Margin = new Padding(3, 4, 3, 4);
            pnlActivities.Name = "pnlActivities";
            pnlActivities.Size = new System.Drawing.Size(1072, 621);
            pnlActivities.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(920, 0);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(149, 164);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // listViewActivities
            // 
            listViewActivities.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16 });
            listViewActivities.Location = new System.Drawing.Point(18, 56);
            listViewActivities.Margin = new Padding(3, 4, 3, 4);
            listViewActivities.Name = "listViewActivities";
            listViewActivities.Size = new System.Drawing.Size(875, 542);
            listViewActivities.TabIndex = 1;
            listViewActivities.UseCompatibleStateImageBehavior = false;
            listViewActivities.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Activity ID";
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Name";
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Day";
            columnHeader14.Width = 80;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Start time";
            columnHeader15.Width = 100;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "End time";
            columnHeader16.Width = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(15, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 41);
            label3.TabIndex = 0;
            label3.Text = "Activities";
            // 
            // pnlRooms
            // 
            pnlRooms.Controls.Add(pictureBox4);
            pnlRooms.Controls.Add(listViewRooms);
            pnlRooms.Controls.Add(label4);
            pnlRooms.Location = new System.Drawing.Point(8, 34);
            pnlRooms.Margin = new Padding(3, 4, 3, 4);
            pnlRooms.Name = "pnlRooms";
            pnlRooms.Size = new System.Drawing.Size(1072, 621);
            pnlRooms.TabIndex = 5;
            pnlRooms.Paint += pnlRooms_Paint_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(920, 0);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(149, 164);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // listViewRooms
            // 
            listViewRooms.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader18, columnHeader19, columnHeader20 });
            listViewRooms.Location = new System.Drawing.Point(18, 56);
            listViewRooms.Margin = new Padding(3, 4, 3, 4);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(875, 542);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = View.Details;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Room ID";
            columnHeader17.Width = 100;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Floor number";
            columnHeader18.Width = 100;
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
            label4.Location = new System.Drawing.Point(15, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(110, 41);
            label4.TabIndex = 0;
            label4.Text = "Rooms";
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1100, 673);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDrinks);
            Controls.Add(pnlLecturers);
            Controls.Add(pnlStudents);
            Controls.Add(pnlDashboard);
            Controls.Add(pnlRooms);
            Controls.Add(pnlActivities);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlDrinks.ResumeLayout(false);
            pnlDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            pnlActivities.ResumeLayout(false);
            pnlActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlRooms.ResumeLayout(false);
            pnlRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinksToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
        private Panel pnlLecturers;
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
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private Panel pnlRooms;
        private PictureBox pictureBox4;
        private ListView listViewRooms;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private Label label4;
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
        private ColumnHeader columnHeader27;
        private Label txtQuarter;
        private TextBox txtbxYear;
        private Label txtYear;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private ListView listView1;
        private Label label6;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
        private ColumnHeader columnHeader33;
        private Label txtPrice;
        private Button btnPlaceOrder;
        private TextBox textBox1;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label txtQuantity;
    }
}