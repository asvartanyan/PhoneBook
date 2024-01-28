
namespace WindowsFormsApp1
{
    partial class Sort2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxLastName = new System.Windows.Forms.CheckBox();
            this.checkBoxMidName = new System.Windows.Forms.CheckBox();
            this.checkBoxFirstName = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxApartment = new System.Windows.Forms.CheckBox();
            this.checkBoxHouse = new System.Windows.Forms.CheckBox();
            this.checkBoxCity = new System.Windows.Forms.CheckBox();
            this.checkBoxStreet = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxYearOfSet = new System.Windows.Forms.CheckBox();
            this.checkBoxNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxPaymentType = new System.Windows.Forms.CheckBox();
            this.checkBoxPaired = new System.Windows.Forms.CheckBox();
            this.buttonClearAllFields = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.radioButtonAscending = new System.Windows.Forms.RadioButton();
            this.radioButtonDescending = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxLastName);
            this.groupBox1.Controls.Add(this.checkBoxMidName);
            this.groupBox1.Controls.Add(this.checkBoxFirstName);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name:";
            // 
            // checkBoxLastName
            // 
            this.checkBoxLastName.AutoSize = true;
            this.checkBoxLastName.Location = new System.Drawing.Point(19, 116);
            this.checkBoxLastName.Name = "checkBoxLastName";
            this.checkBoxLastName.Size = new System.Drawing.Size(99, 23);
            this.checkBoxLastName.TabIndex = 2;
            this.checkBoxLastName.Text = "Last name";
            this.checkBoxLastName.UseVisualStyleBackColor = true;
            // 
            // checkBoxMidName
            // 
            this.checkBoxMidName.AutoSize = true;
            this.checkBoxMidName.Location = new System.Drawing.Point(19, 77);
            this.checkBoxMidName.Name = "checkBoxMidName";
            this.checkBoxMidName.Size = new System.Drawing.Size(121, 23);
            this.checkBoxMidName.TabIndex = 1;
            this.checkBoxMidName.Text = "Middle name";
            this.checkBoxMidName.UseVisualStyleBackColor = true;
            // 
            // checkBoxFirstName
            // 
            this.checkBoxFirstName.AutoSize = true;
            this.checkBoxFirstName.Location = new System.Drawing.Point(19, 38);
            this.checkBoxFirstName.Name = "checkBoxFirstName";
            this.checkBoxFirstName.Size = new System.Drawing.Size(97, 23);
            this.checkBoxFirstName.TabIndex = 0;
            this.checkBoxFirstName.Text = "First name";
            this.checkBoxFirstName.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxApartment);
            this.groupBox2.Controls.Add(this.checkBoxHouse);
            this.groupBox2.Controls.Add(this.checkBoxCity);
            this.groupBox2.Controls.Add(this.checkBoxStreet);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adress:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBoxApartment
            // 
            this.checkBoxApartment.AutoSize = true;
            this.checkBoxApartment.Location = new System.Drawing.Point(23, 154);
            this.checkBoxApartment.Name = "checkBoxApartment";
            this.checkBoxApartment.Size = new System.Drawing.Size(102, 23);
            this.checkBoxApartment.TabIndex = 6;
            this.checkBoxApartment.Text = "Apartment";
            this.checkBoxApartment.UseVisualStyleBackColor = true;
            // 
            // checkBoxHouse
            // 
            this.checkBoxHouse.AutoSize = true;
            this.checkBoxHouse.Location = new System.Drawing.Point(23, 116);
            this.checkBoxHouse.Name = "checkBoxHouse";
            this.checkBoxHouse.Size = new System.Drawing.Size(70, 23);
            this.checkBoxHouse.TabIndex = 5;
            this.checkBoxHouse.Text = "House";
            this.checkBoxHouse.UseVisualStyleBackColor = true;
            // 
            // checkBoxCity
            // 
            this.checkBoxCity.AutoSize = true;
            this.checkBoxCity.Location = new System.Drawing.Point(23, 38);
            this.checkBoxCity.Name = "checkBoxCity";
            this.checkBoxCity.Size = new System.Drawing.Size(55, 23);
            this.checkBoxCity.TabIndex = 3;
            this.checkBoxCity.Text = "City";
            this.checkBoxCity.UseVisualStyleBackColor = true;
            // 
            // checkBoxStreet
            // 
            this.checkBoxStreet.AutoSize = true;
            this.checkBoxStreet.Location = new System.Drawing.Point(23, 77);
            this.checkBoxStreet.Name = "checkBoxStreet";
            this.checkBoxStreet.Size = new System.Drawing.Size(67, 23);
            this.checkBoxStreet.TabIndex = 4;
            this.checkBoxStreet.Text = "Street";
            this.checkBoxStreet.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxYearOfSet);
            this.groupBox3.Controls.Add(this.checkBoxNumber);
            this.groupBox3.Controls.Add(this.checkBoxPaymentType);
            this.groupBox3.Controls.Add(this.checkBoxPaired);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.groupBox3.Location = new System.Drawing.Point(500, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 197);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Number:";
            // 
            // checkBoxYearOfSet
            // 
            this.checkBoxYearOfSet.AutoSize = true;
            this.checkBoxYearOfSet.Location = new System.Drawing.Point(18, 154);
            this.checkBoxYearOfSet.Name = "checkBoxYearOfSet";
            this.checkBoxYearOfSet.Size = new System.Drawing.Size(98, 23);
            this.checkBoxYearOfSet.TabIndex = 10;
            this.checkBoxYearOfSet.Text = "Year of set";
            this.checkBoxYearOfSet.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumber
            // 
            this.checkBoxNumber.AutoSize = true;
            this.checkBoxNumber.Location = new System.Drawing.Point(18, 38);
            this.checkBoxNumber.Name = "checkBoxNumber";
            this.checkBoxNumber.Size = new System.Drawing.Size(83, 23);
            this.checkBoxNumber.TabIndex = 7;
            this.checkBoxNumber.Text = "Number";
            this.checkBoxNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxPaymentType
            // 
            this.checkBoxPaymentType.AutoSize = true;
            this.checkBoxPaymentType.Location = new System.Drawing.Point(18, 116);
            this.checkBoxPaymentType.Name = "checkBoxPaymentType";
            this.checkBoxPaymentType.Size = new System.Drawing.Size(126, 23);
            this.checkBoxPaymentType.TabIndex = 9;
            this.checkBoxPaymentType.Text = "Payment type";
            this.checkBoxPaymentType.UseVisualStyleBackColor = true;
            // 
            // checkBoxPaired
            // 
            this.checkBoxPaired.AutoSize = true;
            this.checkBoxPaired.Location = new System.Drawing.Point(18, 77);
            this.checkBoxPaired.Name = "checkBoxPaired";
            this.checkBoxPaired.Size = new System.Drawing.Size(72, 23);
            this.checkBoxPaired.TabIndex = 8;
            this.checkBoxPaired.Text = "Paired";
            this.checkBoxPaired.UseVisualStyleBackColor = true;
            // 
            // buttonClearAllFields
            // 
            this.buttonClearAllFields.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonClearAllFields.Location = new System.Drawing.Point(501, 267);
            this.buttonClearAllFields.Name = "buttonClearAllFields";
            this.buttonClearAllFields.Size = new System.Drawing.Size(238, 48);
            this.buttonClearAllFields.TabIndex = 3;
            this.buttonClearAllFields.Text = "Clear all fields";
            this.buttonClearAllFields.UseVisualStyleBackColor = true;
            this.buttonClearAllFields.Click += new System.EventHandler(this.buttonClearAllFields_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.buttonSort.Location = new System.Drawing.Point(13, 267);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(482, 48);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // radioButtonAscending
            // 
            this.radioButtonAscending.AutoSize = true;
            this.radioButtonAscending.Checked = true;
            this.radioButtonAscending.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.radioButtonAscending.Location = new System.Drawing.Point(16, 16);
            this.radioButtonAscending.Name = "radioButtonAscending";
            this.radioButtonAscending.Size = new System.Drawing.Size(99, 23);
            this.radioButtonAscending.TabIndex = 5;
            this.radioButtonAscending.TabStop = true;
            this.radioButtonAscending.Text = "Ascending";
            this.radioButtonAscending.UseVisualStyleBackColor = true;
            // 
            // radioButtonDescending
            // 
            this.radioButtonDescending.AutoSize = true;
            this.radioButtonDescending.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.radioButtonDescending.Location = new System.Drawing.Point(243, 16);
            this.radioButtonDescending.Name = "radioButtonDescending";
            this.radioButtonDescending.Size = new System.Drawing.Size(109, 23);
            this.radioButtonDescending.TabIndex = 6;
            this.radioButtonDescending.TabStop = true;
            this.radioButtonDescending.Text = "Descending";
            this.radioButtonDescending.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonAscending);
            this.groupBox4.Controls.Add(this.radioButtonDescending);
            this.groupBox4.Location = new System.Drawing.Point(13, 216);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(725, 45);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // Sort2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 328);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonClearAllFields);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sort2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sort2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBoxLastName;
        private System.Windows.Forms.CheckBox checkBoxMidName;
        private System.Windows.Forms.CheckBox checkBoxFirstName;
        private System.Windows.Forms.CheckBox checkBoxApartment;
        private System.Windows.Forms.CheckBox checkBoxHouse;
        private System.Windows.Forms.CheckBox checkBoxCity;
        private System.Windows.Forms.CheckBox checkBoxStreet;
        private System.Windows.Forms.CheckBox checkBoxYearOfSet;
        private System.Windows.Forms.CheckBox checkBoxNumber;
        private System.Windows.Forms.CheckBox checkBoxPaymentType;
        private System.Windows.Forms.CheckBox checkBoxPaired;
        private System.Windows.Forms.Button buttonClearAllFields;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.RadioButton radioButtonAscending;
        private System.Windows.Forms.RadioButton radioButtonDescending;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}