namespace midterm_valetparking
{
    partial class Form1
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
            this.txtBox_plate = new System.Windows.Forms.TextBox();
            this.lbl_plate = new System.Windows.Forms.Label();
            this.radio_premier = new System.Windows.Forms.RadioButton();
            this.radio_vip = new System.Windows.Forms.RadioButton();
            this.txtBox_hour = new System.Windows.Forms.TextBox();
            this.lbl_hoursBox = new System.Windows.Forms.Label();
            this.button_hours = new System.Windows.Forms.Button();
            this.radio_weekEnd = new System.Windows.Forms.RadioButton();
            this.radio_weekDay = new System.Windows.Forms.RadioButton();
            this.button_overnight = new System.Windows.Forms.Button();
            this.lbl_totalHours = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbl_totalFees = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_long = new System.Windows.Forms.Button();
            this.btn_avg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBox_plate
            // 
            this.txtBox_plate.Location = new System.Drawing.Point(71, 53);
            this.txtBox_plate.Name = "txtBox_plate";
            this.txtBox_plate.Size = new System.Drawing.Size(100, 20);
            this.txtBox_plate.TabIndex = 0;
            this.txtBox_plate.TextChanged += new System.EventHandler(this.txtBox_plate_TextChanged);
            // 
            // lbl_plate
            // 
            this.lbl_plate.AutoSize = true;
            this.lbl_plate.Location = new System.Drawing.Point(71, 34);
            this.lbl_plate.Name = "lbl_plate";
            this.lbl_plate.Size = new System.Drawing.Size(69, 13);
            this.lbl_plate.TabIndex = 1;
            this.lbl_plate.Text = "Vehicle Plate";
            this.lbl_plate.Click += new System.EventHandler(this.label1_Click);
            // 
            // radio_premier
            // 
            this.radio_premier.AutoSize = true;
            this.radio_premier.Location = new System.Drawing.Point(21, 21);
            this.radio_premier.Name = "radio_premier";
            this.radio_premier.Size = new System.Drawing.Size(60, 17);
            this.radio_premier.TabIndex = 3;
            this.radio_premier.TabStop = true;
            this.radio_premier.Text = "Premier";
            this.radio_premier.UseVisualStyleBackColor = true;
            this.radio_premier.CheckedChanged += new System.EventHandler(this.radio_premier_CheckedChanged);
            // 
            // radio_vip
            // 
            this.radio_vip.AutoSize = true;
            this.radio_vip.Location = new System.Drawing.Point(21, 44);
            this.radio_vip.Name = "radio_vip";
            this.radio_vip.Size = new System.Drawing.Size(42, 17);
            this.radio_vip.TabIndex = 4;
            this.radio_vip.TabStop = true;
            this.radio_vip.Text = "VIP";
            this.radio_vip.UseVisualStyleBackColor = true;
            this.radio_vip.CheckedChanged += new System.EventHandler(this.radio_vip_CheckedChanged);
            // 
            // txtBox_hour
            // 
            this.txtBox_hour.Location = new System.Drawing.Point(131, 149);
            this.txtBox_hour.Name = "txtBox_hour";
            this.txtBox_hour.Size = new System.Drawing.Size(100, 20);
            this.txtBox_hour.TabIndex = 5;
            this.txtBox_hour.TextChanged += new System.EventHandler(this.txtBox_hour_TextChanged);
            // 
            // lbl_hoursBox
            // 
            this.lbl_hoursBox.AutoSize = true;
            this.lbl_hoursBox.Location = new System.Drawing.Point(131, 133);
            this.lbl_hoursBox.Name = "lbl_hoursBox";
            this.lbl_hoursBox.Size = new System.Drawing.Size(72, 13);
            this.lbl_hoursBox.TabIndex = 6;
            this.lbl_hoursBox.Text = "Hours Parked";
            // 
            // button_hours
            // 
            this.button_hours.Location = new System.Drawing.Point(313, 146);
            this.button_hours.Name = "button_hours";
            this.button_hours.Size = new System.Drawing.Size(75, 23);
            this.button_hours.TabIndex = 7;
            this.button_hours.Text = "Add Hours";
            this.button_hours.UseVisualStyleBackColor = true;
            this.button_hours.Click += new System.EventHandler(this.button_hours_Click);
            // 
            // radio_weekEnd
            // 
            this.radio_weekEnd.AutoSize = true;
            this.radio_weekEnd.Location = new System.Drawing.Point(11, 45);
            this.radio_weekEnd.Name = "radio_weekEnd";
            this.radio_weekEnd.Size = new System.Drawing.Size(72, 17);
            this.radio_weekEnd.TabIndex = 10;
            this.radio_weekEnd.TabStop = true;
            this.radio_weekEnd.Text = "Weekend";
            this.radio_weekEnd.UseVisualStyleBackColor = true;
            this.radio_weekEnd.CheckedChanged += new System.EventHandler(this.radio_weekEnd_CheckedChanged);
            // 
            // radio_weekDay
            // 
            this.radio_weekDay.AutoSize = true;
            this.radio_weekDay.Location = new System.Drawing.Point(11, 22);
            this.radio_weekDay.Name = "radio_weekDay";
            this.radio_weekDay.Size = new System.Drawing.Size(71, 17);
            this.radio_weekDay.TabIndex = 9;
            this.radio_weekDay.TabStop = true;
            this.radio_weekDay.Text = "Weekday";
            this.radio_weekDay.UseVisualStyleBackColor = true;
            this.radio_weekDay.CheckedChanged += new System.EventHandler(this.radio_weekDay_CheckedChanged);
            // 
            // button_overnight
            // 
            this.button_overnight.Location = new System.Drawing.Point(304, 192);
            this.button_overnight.Name = "button_overnight";
            this.button_overnight.Size = new System.Drawing.Size(94, 23);
            this.button_overnight.TabIndex = 11;
            this.button_overnight.Text = "Overnight Park";
            this.button_overnight.UseVisualStyleBackColor = true;
            this.button_overnight.Click += new System.EventHandler(this.button_overnight_Click);
            // 
            // lbl_totalHours
            // 
            this.lbl_totalHours.AutoSize = true;
            this.lbl_totalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalHours.Location = new System.Drawing.Point(135, 292);
            this.lbl_totalHours.Name = "lbl_totalHours";
            this.lbl_totalHours.Size = new System.Drawing.Size(0, 37);
            this.lbl_totalHours.TabIndex = 12;
            this.lbl_totalHours.Click += new System.EventHandler(this.lbl_totalHours_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Lime;
            this.btnCalculate.Location = new System.Drawing.Point(573, 133);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(125, 36);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbl_totalFees
            // 
            this.lbl_totalFees.AutoSize = true;
            this.lbl_totalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalFees.Location = new System.Drawing.Point(135, 363);
            this.lbl_totalFees.Name = "lbl_totalFees";
            this.lbl_totalFees.Size = new System.Drawing.Size(0, 37);
            this.lbl_totalFees.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_premier);
            this.groupBox1.Controls.Add(this.radio_vip);
            this.groupBox1.Location = new System.Drawing.Point(254, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_weekDay);
            this.groupBox2.Controls.Add(this.radio_weekEnd);
            this.groupBox2.Location = new System.Drawing.Point(408, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 74);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parking Type";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Red;
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(29, 248);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_Clear);
            // 
            // btn_long
            // 
            this.btn_long.Location = new System.Drawing.Point(29, 306);
            this.btn_long.Name = "btn_long";
            this.btn_long.Size = new System.Drawing.Size(75, 35);
            this.btn_long.TabIndex = 19;
            this.btn_long.Text = "Longest Hour";
            this.btn_long.UseVisualStyleBackColor = true;
            // 
            // btn_avg
            // 
            this.btn_avg.Location = new System.Drawing.Point(29, 277);
            this.btn_avg.Name = "btn_avg";
            this.btn_avg.Size = new System.Drawing.Size(75, 23);
            this.btn_avg.TabIndex = 20;
            this.btn_avg.Text = "Average";
            this.btn_avg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_avg);
            this.Controls.Add(this.btn_long);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_totalFees);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbl_totalHours);
            this.Controls.Add(this.button_overnight);
            this.Controls.Add(this.button_hours);
            this.Controls.Add(this.lbl_hoursBox);
            this.Controls.Add(this.txtBox_hour);
            this.Controls.Add(this.lbl_plate);
            this.Controls.Add(this.txtBox_plate);
            this.Name = "Form1";
            this.Text = "Valet Parking Rate";
            this.Load += new System.EventHandler(this.x);
            this.Click += new System.EventHandler(this.A);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_plate;
        private System.Windows.Forms.Label lbl_plate;
        private System.Windows.Forms.RadioButton radio_premier;
        private System.Windows.Forms.RadioButton radio_vip;
        private System.Windows.Forms.TextBox txtBox_hour;
        private System.Windows.Forms.Label lbl_hoursBox;
        private System.Windows.Forms.Button button_hours;
        private System.Windows.Forms.RadioButton radio_weekEnd;
        private System.Windows.Forms.RadioButton radio_weekDay;
        private System.Windows.Forms.Button button_overnight;
        private System.Windows.Forms.Label lbl_totalHours;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbl_totalFees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_long;
        private System.Windows.Forms.Button btn_avg;
    }
}

