namespace SomerenUI
{
    partial class UpdateDrinkForm
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
            buttonUpdate = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            txtBoxNewDrinkName = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            txtBoxNewPrice = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            comboBoxNewType = new System.Windows.Forms.ComboBox();
            txtBoxNewStockAmount = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            textBoxNewSold = new System.Windows.Forms.TextBox();
            radioButtonAlcoholic = new System.Windows.Forms.RadioButton();
            radioButtonNonAlcoholic = new System.Windows.Forms.RadioButton();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new System.Drawing.Point(602, 678);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new System.Drawing.Size(150, 46);
            buttonUpdate.TabIndex = 25;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(316, 81);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(202, 32);
            label7.TabIndex = 13;
            label7.Text = "New Drink Name:";
            // 
            // txtBoxNewDrinkName
            // 
            txtBoxNewDrinkName.Location = new System.Drawing.Point(571, 74);
            txtBoxNewDrinkName.Name = "txtBoxNewDrinkName";
            txtBoxNewDrinkName.Size = new System.Drawing.Size(242, 39);
            txtBoxNewDrinkName.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(316, 168);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(242, 32);
            label8.TabIndex = 18;
            label8.Text = "New Alcoholic Status:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(316, 286);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(187, 32);
            label9.TabIndex = 26;
            label9.Text = "Enter New Price:";
            // 
            // txtBoxNewPrice
            // 
            txtBoxNewPrice.Location = new System.Drawing.Point(571, 286);
            txtBoxNewPrice.Name = "txtBoxNewPrice";
            txtBoxNewPrice.Size = new System.Drawing.Size(242, 39);
            txtBoxNewPrice.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(316, 396);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(212, 32);
            label10.TabIndex = 28;
            label10.Text = "Choose New Type:";
            // 
            // comboBoxNewType
            // 
            comboBoxNewType.FormattingEnabled = true;
            comboBoxNewType.Items.AddRange(new object[] { "Beer", "Wine", "Water", "Tea", "Coffee", "Sparkling", "Juice", "Other" });
            comboBoxNewType.Location = new System.Drawing.Point(571, 388);
            comboBoxNewType.Name = "comboBoxNewType";
            comboBoxNewType.Size = new System.Drawing.Size(242, 40);
            comboBoxNewType.TabIndex = 29;
            // 
            // txtBoxNewStockAmount
            // 
            txtBoxNewStockAmount.Location = new System.Drawing.Point(571, 494);
            txtBoxNewStockAmount.Name = "txtBoxNewStockAmount";
            txtBoxNewStockAmount.Size = new System.Drawing.Size(242, 39);
            txtBoxNewStockAmount.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(316, 494);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(169, 64);
            label11.TabIndex = 31;
            label11.Text = "Enter New \r\nStock Amount:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(316, 593);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(131, 64);
            label13.TabIndex = 43;
            label13.Text = "Enter New \r\nSold:";
            // 
            // textBoxNewSold
            // 
            textBoxNewSold.Location = new System.Drawing.Point(571, 604);
            textBoxNewSold.Name = "textBoxNewSold";
            textBoxNewSold.Size = new System.Drawing.Size(242, 39);
            textBoxNewSold.TabIndex = 44;
            // 
            // radioButtonAlcoholic
            // 
            radioButtonAlcoholic.AutoSize = true;
            radioButtonAlcoholic.Location = new System.Drawing.Point(582, 168);
            radioButtonAlcoholic.Name = "radioButtonAlcoholic";
            radioButtonAlcoholic.Size = new System.Drawing.Size(142, 36);
            radioButtonAlcoholic.TabIndex = 45;
            radioButtonAlcoholic.TabStop = true;
            radioButtonAlcoholic.Text = "Alcoholic";
            radioButtonAlcoholic.UseVisualStyleBackColor = true;
            // 
            // radioButtonNonAlcoholic
            // 
            radioButtonNonAlcoholic.AutoSize = true;
            radioButtonNonAlcoholic.Location = new System.Drawing.Point(828, 168);
            radioButtonNonAlcoholic.Name = "radioButtonNonAlcoholic";
            radioButtonNonAlcoholic.Size = new System.Drawing.Size(185, 36);
            radioButtonNonAlcoholic.TabIndex = 46;
            radioButtonNonAlcoholic.TabStop = true;
            radioButtonNonAlcoholic.Text = "Nonalcoholic";
            radioButtonNonAlcoholic.UseVisualStyleBackColor = true;
            // 
            // UpdateDrinkForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1394, 852);
            Controls.Add(radioButtonNonAlcoholic);
            Controls.Add(radioButtonAlcoholic);
            Controls.Add(textBoxNewSold);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(txtBoxNewStockAmount);
            Controls.Add(comboBoxNewType);
            Controls.Add(label10);
            Controls.Add(txtBoxNewPrice);
            Controls.Add(label9);
            Controls.Add(buttonUpdate);
            Controls.Add(txtBoxNewDrinkName);
            Controls.Add(label8);
            Controls.Add(label7);
            Name = "UpdateDrinkForm";
            Text = "UpdateDrink";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxNewDrinkName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxNewPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxNewType;
        private System.Windows.Forms.TextBox txtBoxNewStockAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxNewSold;
        private System.Windows.Forms.RadioButton radioButtonAlcoholic;
        private System.Windows.Forms.RadioButton radioButtonNonAlcoholic;
    }
}