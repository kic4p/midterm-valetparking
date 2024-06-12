using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace midterm_valetparking
{
    public partial class Form1 : Form
    {
        //declare all variable and array to store to calculate average and longest hour parked
        private int totalHours = 0;
        private double totalFees = 0;

        private List<int> allHours = new List<int>();
        private List<double> allFees = new List<double>();
        private List<string> allPlates = new List<string>();

        public Form1()
        {
            InitializeComponent();
            radio_premier.Enabled = false;
            radio_vip.Enabled = false;
            radio_weekDay.Enabled = false;
            radio_weekEnd.Enabled = false;
            txtBox_hour.Enabled = false;
            button_hours.Enabled = false;
            button_overnight.Enabled = false;

            txtBox_plate.TextChanged += (s, e) =>
            {
                txtBox_plate.Text = txtBox_plate.Text.ToUpper();
                txtBox_plate.SelectionStart = txtBox_plate.Text.Length;
            };

            txtBox_hour.KeyPress += (s, e) =>
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            };

            //for enable series of input after each input is typed in
            txtBox_plate.TextChanged += (s, e) =>
            {
                if (!string.IsNullOrEmpty(txtBox_plate.Text))
                {
                    radio_premier.Enabled = true;
                    radio_vip.Enabled = true;
                }
                else
                {
                    radio_premier.Enabled = false;
                    radio_vip.Enabled = false;
                    radio_weekDay.Enabled = false;
                    radio_weekEnd.Enabled = false;
                    txtBox_hour.Enabled = false;
                    button_hours.Enabled = false;
                    button_overnight.Enabled = false;
                }
            };

            radio_premier.CheckedChanged += (s, e) =>
            {
                if (radio_premier.Checked)
                {
                    radio_weekDay.Enabled = true;
                    radio_weekEnd.Enabled = true;
                }
            };

            radio_vip.CheckedChanged += (s, e) =>
            {
                if (radio_vip.Checked)
                {
                    radio_weekDay.Enabled = true;
                    radio_weekEnd.Enabled = true;
                }
            };

            radio_weekDay.CheckedChanged += (s, e) =>
            {
                if (radio_weekDay.Checked)
                {
                    txtBox_hour.Enabled = true;
                    button_hours.Enabled = true;
                    button_overnight.Enabled = true;
                }
            };

            radio_weekEnd.CheckedChanged += (s, e) =>
            {
                if (radio_weekEnd.Checked)
                {
                    txtBox_hour.Enabled = true;
                    button_hours.Enabled = true;
                    button_overnight.Enabled = true;
                }
            };

            button_hours.Click += (s, e) =>
            {
                int hoursParked;
                
                if (int.TryParse(txtBox_hour.Text, out hoursParked))
                {
                    totalHours += hoursParked;
                    lbl_totalHours.Text = "Total Hours: " + totalHours.ToString();



                    if (radio_premier.Checked)
                    {
                        totalFees += hoursParked * 3;
                    }
                    else if (radio_vip.Checked)
                    {
                        totalFees += hoursParked * 10;
                    }

                    if (radio_weekEnd.Checked && radio_premier.Checked)
                    {
                        totalFees *= 2;
                    }
                }

                else
                {
                    MessageBox.Show("Please enter a valid number in Hours Parked.");
                }
            };

            button_overnight.Click += (s, e) =>
            {
                totalHours += 24;
                lbl_totalHours.Text = "Total Hours: " + totalHours.ToString();
                totalFees += 50;
            };

            btnCalculate.Click += (s, e) =>
            {
                if (radio_premier.Checked && radio_weekDay.Checked) 
                {
                    totalFees += 2;
          
                } else if (radio_premier.Checked && radio_weekEnd.Checked)
                {
                    totalFees += 4;
                } else if (radio_vip.Checked && radio_weekDay.Checked)
                {
                    totalFees += 5;
                } else if (radio_vip.Checked && radio_weekEnd.Checked)
                {
                    totalFees += 10;
                }

                allHours.Add(totalHours);
                allFees.Add(totalFees);
                allPlates.Add(txtBox_plate.Text);

                lbl_totalFees.Text = "Total Fees: RM" + totalFees.ToString("F2");
            };

            btn_avg.Click += (s, e) =>
            {
                
                double averageTotalFee = allFees.Average();
                MessageBox.Show("The average total fee is: " + averageTotalFee.ToString("F2"));
            };

            btn_long.Click += (s, e) =>
            {         
                int longestIndex = allHours.IndexOf(allHours.Max());

                string longestPlate = allPlates[longestIndex];
                int longestHours = allHours[longestIndex];
                double longestFee = allFees[longestIndex];

                MessageBox.Show("The car with the longest parking time is: " + longestPlate +
                    "\nTotal Hours: " + longestHours.ToString() +
                    "\nTotal Fee: RM" + longestFee.ToString("F2"));
            };


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_hours_Click(object sender, EventArgs e)
        {

        }

        private void button_overnight_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_hour_TextChanged(object sender, EventArgs e)
        {

        }

        private void radio_weekDay_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_weekEnd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_premier_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_vip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_plate_TextChanged(object sender, EventArgs e)
        {

        }

        private void x(object sender, EventArgs e)
        {

        }

        private void lbl_totalHours_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void A(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Clear(object sender, EventArgs e)
        {
            //clearing all values
            
            txtBox_plate.Text = string.Empty;
            txtBox_hour.Text = string.Empty;
            
            radio_premier.Checked = false;
            radio_vip.Checked = false;
            radio_weekDay.Checked = false;
            radio_weekEnd.Checked = false;
           
            totalHours = 0;
            totalFees = 0;

            lbl_totalHours.Text = "";
            lbl_totalFees.Text = "";
        }
    }
}
