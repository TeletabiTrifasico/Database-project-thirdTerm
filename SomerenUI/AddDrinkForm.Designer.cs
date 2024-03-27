namespace SomerenUI
{
    partial class AddDrinkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            textBoxDrinkName = new System.Windows.Forms.TextBox();
            textBoxPrice = new System.Windows.Forms.TextBox();
            textBoxStockAmount = new System.Windows.Forms.TextBox();
            comboBoxType = new System.Windows.Forms.ComboBox();
            buttonSave = new System.Windows.Forms.Button();
            textBoxSold = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            radioButtonAlcoholic = new System.Windows.Forms.RadioButton();
            radioButtonNonAlcoholic = new System.Windows.Forms.RadioButton();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 70);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(209, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter Drink Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(55, 168);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 32);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(55, 242);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 32);
            label3.TabIndex = 2;
            label3.Text = "Enter Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(55, 340);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 32);
            label4.TabIndex = 3;
            label4.Text = "Enter Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(55, 443);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(231, 32);
            label5.TabIndex = 4;
            label5.Text = "Enter Stock Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(55, 142);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(269, 32);
            label6.TabIndex = 7;
            label6.Text = "Choose Alcoholic Status";
            // 
            // textBoxDrinkName
            // 
            textBoxDrinkName.Location = new System.Drawing.Point(386, 70);
            textBoxDrinkName.Name = "textBoxDrinkName";
            textBoxDrinkName.Size = new System.Drawing.Size(200, 39);
            textBoxDrinkName.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(376, 239);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(209, 39);
            textBoxPrice.TabIndex = 8;
            // 
            // textBoxStockAmount
            // 
            textBoxStockAmount.Location = new System.Drawing.Point(376, 440);
            textBoxStockAmount.Name = "textBoxStockAmount";
            textBoxStockAmount.Size = new System.Drawing.Size(209, 39);
            textBoxStockAmount.TabIndex = 8;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Beer", "Wine", "Water", "Tea", "Coffee", "Sparkling", "Juice", "Other" });
            comboBoxType.Location = new System.Drawing.Point(376, 337);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(209, 40);
            comboBoxType.TabIndex = 11;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(404, 581);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(150, 46);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxSold
            // 
            textBoxSold.Location = new System.Drawing.Point(376, 514);
            textBoxSold.Name = "textBoxSold";
            textBoxSold.Size = new System.Drawing.Size(209, 39);
            textBoxSold.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(55, 514);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(128, 32);
            label7.TabIndex = 14;
            label7.Text = "Enter Sold:";
            // 
            // radioButtonAlcoholic
            // 
            radioButtonAlcoholic.AutoSize = true;
            radioButtonAlcoholic.Location = new System.Drawing.Point(386, 142);
            radioButtonAlcoholic.Name = "radioButtonAlcoholic";
            radioButtonAlcoholic.Size = new System.Drawing.Size(142, 36);
            radioButtonAlcoholic.TabIndex = 15;
            radioButtonAlcoholic.TabStop = true;
            radioButtonAlcoholic.Text = "Alcoholic";
            radioButtonAlcoholic.UseVisualStyleBackColor = true;
            // 
            // radioButtonNonAlcoholic
            // 
            radioButtonNonAlcoholic.AutoSize = true;
            radioButtonNonAlcoholic.Location = new System.Drawing.Point(601, 142);
            radioButtonNonAlcoholic.Name = "radioButtonNonAlcoholic";
            radioButtonNonAlcoholic.Size = new System.Drawing.Size(188, 36);
            radioButtonNonAlcoholic.TabIndex = 16;
            radioButtonNonAlcoholic.TabStop = true;
            radioButtonNonAlcoholic.Text = "NonAlcoholic";
            radioButtonNonAlcoholic.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Red;
            label8.Location = new System.Drawing.Point(187, 51);
            label8.MaximumSize = new System.Drawing.Size(79, 79);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(77, 19);
            label8.TabIndex = 17;
            label8.Text = "(Required*)";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.Color.Red;
            label10.Location = new System.Drawing.Point(187, 239);
            label10.MaximumSize = new System.Drawing.Size(79, 79);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(77, 19);
            label10.TabIndex = 19;
            label10.Text = "(Required*)";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label11.ForeColor = System.Drawing.Color.Red;
            label11.Location = new System.Drawing.Point(187, 424);
            label11.MaximumSize = new System.Drawing.Size(79, 79);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(77, 19);
            label11.TabIndex = 20;
            label11.Text = "(Required*)";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Segoe UI", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label12.ForeColor = System.Drawing.Color.Red;
            label12.Location = new System.Drawing.Point(187, 514);
            label12.MaximumSize = new System.Drawing.Size(79, 79);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(77, 19);
            label12.TabIndex = 21;
            label12.Text = "(Required*)";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1104, 638);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(radioButtonNonAlcoholic);
            Controls.Add(radioButtonAlcoholic);
            Controls.Add(label7);
            Controls.Add(textBoxSold);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxStockAmount);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxDrinkName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddDrinkForm";
            Text = "Add Drink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDrinkName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStockAmount;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSold;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonAlcoholic;
        private System.Windows.Forms.RadioButton radioButtonNonAlcoholic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}