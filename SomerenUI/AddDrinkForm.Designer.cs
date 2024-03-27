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
            checkBoxAlcoholic = new System.Windows.Forms.CheckBox();
            checkBoxNonAlcoholic = new System.Windows.Forms.CheckBox();
            comboBoxType = new System.Windows.Forms.ComboBox();
            buttonSave = new System.Windows.Forms.Button();
            textBoxSold = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
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
            label2.Location = new System.Drawing.Point(55, 167);
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
            textBoxDrinkName.Location = new System.Drawing.Point(350, 70);
            textBoxDrinkName.Name = "textBoxDrinkName";
            textBoxDrinkName.Size = new System.Drawing.Size(200, 39);
            textBoxDrinkName.TabIndex = 8;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new System.Drawing.Point(341, 242);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new System.Drawing.Size(209, 39);
            textBoxPrice.TabIndex = 8;
            // 
            // textBoxStockAmount
            // 
            textBoxStockAmount.Location = new System.Drawing.Point(341, 436);
            textBoxStockAmount.Name = "textBoxStockAmount";
            textBoxStockAmount.Size = new System.Drawing.Size(209, 39);
            textBoxStockAmount.TabIndex = 8;
            // 
            // checkBoxAlcoholic
            // 
            checkBoxAlcoholic.AutoSize = true;
            checkBoxAlcoholic.Location = new System.Drawing.Point(350, 142);
            checkBoxAlcoholic.Name = "checkBoxAlcoholic";
            checkBoxAlcoholic.Size = new System.Drawing.Size(143, 36);
            checkBoxAlcoholic.TabIndex = 9;
            checkBoxAlcoholic.Text = "Alcoholic";
            checkBoxAlcoholic.UseVisualStyleBackColor = true;
            // 
            // checkBoxNonAlcoholic
            // 
            checkBoxNonAlcoholic.AutoSize = true;
            checkBoxNonAlcoholic.Location = new System.Drawing.Point(563, 142);
            checkBoxNonAlcoholic.Name = "checkBoxNonAlcoholic";
            checkBoxNonAlcoholic.Size = new System.Drawing.Size(189, 36);
            checkBoxNonAlcoholic.TabIndex = 10;
            checkBoxNonAlcoholic.Text = "NonAlcoholic";
            checkBoxNonAlcoholic.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "BEER ", "SPARKLING ", "FRUIT JUICE ", "WINE " });
            comboBoxType.Location = new System.Drawing.Point(341, 337);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new System.Drawing.Size(209, 40);
            comboBoxType.TabIndex = 11;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(359, 580);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(150, 46);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxSold
            // 
            textBoxSold.Location = new System.Drawing.Point(341, 507);
            textBoxSold.Name = "textBoxSold";
            textBoxSold.Size = new System.Drawing.Size(209, 39);
            textBoxSold.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(55, 514);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(123, 32);
            label7.TabIndex = 14;
            label7.Text = "Enter Sold";
            // 
            // AddDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1103, 638);
            Controls.Add(label7);
            Controls.Add(textBoxSold);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxType);
            Controls.Add(checkBoxNonAlcoholic);
            Controls.Add(checkBoxAlcoholic);
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
        private System.Windows.Forms.CheckBox checkBoxAlcoholic;
        private System.Windows.Forms.CheckBox checkBoxNonAlcoholic;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSold;
        private System.Windows.Forms.Label label7;
    }
}