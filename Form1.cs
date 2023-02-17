using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double monday1 = 0.00, tuesday1 = 0.00, wednesday1 = 0.00, thursday = 0.00, friday = 0.00, saturday1 = 0.00, sunday1 = 0.00,monday2 = 0.00,tuesday2 =0.00,wednesday2 =0.00,thursday2 =0.00, friday2 = 0.00, saturday2 = 0.00, sunday2 = 0.00;
            double totalhourweek1, totalhourweek2;
            double reghours1 = 0.00, reghour2 = 0.00, overtimehours1 = 0.00, overtimehours2 = 0.00;
            double regularamount1 = 0.00, regularamount2 = 0.00, overtimeamount1 = 0.00, overtimeamount2 = 0.00;
            double regularhours, overtimehours;
            double regularamount, overtimamount, totalearnings;

            double hourlysalary = 0.00;
            try
            {
                hourlysalary = double.Parse(txtHourlySalary.Text);
            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtHourlySalary.Focus();
            }
            try
            {
                monday1 = double.Parse(txtMonday.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtMonday.Focus();

            }
            try
            {
                tuesday1 = double.Parse(txtTuesday.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                this.txtTuesday.Focus();
            }
            try
            {
                wednesday1 = double.Parse(txtWednesday.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtWednesday.Focus();
            }
            try
            {
                thursday = double.Parse(txtThursday.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtThursday.Focus();
            }
            try
            {
                friday = double.Parse(txtFriday.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtFriday.Focus();
            }
            try
            {
                saturday1 = double.Parse(txtSaturday.Text);
            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtFriday.Focus();

            }
            try
            {
                sunday1 = double.Parse(txtSunday.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtSunday.Focus();
            }
            try
            {
                monday2 = double.Parse(txtMonday2.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                this.txtMonday2.Focus();
            }
            try
            {
                tuesday2 = double.Parse(txtTuesday2.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtTuesday2.Focus();
            }
            try
            {
                wednesday2 = double.Parse(txtWednesday2.Text);
            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtWednesday2.Focus();
            }
            try
            {
                thursday2 = double.Parse(txtThursday2.Text);
            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtThursday2.Focus();

            }
            try
            {
                friday2 = double.Parse(txtFriday2.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtFriday2.Focus();
            }
            try
            {
                saturday2 = double.Parse(txtSaturday2.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtSaturday2.Focus();
            }
            try
            {
                sunday2 = double.Parse(txtSunday2.Text);

            }catch(FormatException)
            {
                MessageBox.Show("The value you typed for the salary is invalid \n" + "Please try again");
                txtSunday2.Focus();
            }
            totalhourweek1 = monday1 + tuesday1 + wednesday1 + thursday + friday + saturday1 + sunday1;
            totalhourweek2 = monday2 + thursday2 + wednesday2 + thursday2 + friday2 + saturday2 + sunday2;
            double ovtsalary = hourlysalary * 1.5;
            // If Employee worked under 40 hours.
            if(totalhourweek1 <40)
            {
                reghours1 = totalhourweek1;
                regularamount1 = hourlysalary * reghours1;
                overtimehours1 = 0.00;
                overtimeamount1 = 0.00;

            }
            else if(totalhourweek1 >= 40)
            {
                reghours1 = 40;
                regularamount1 = hourlysalary * 40;
                overtimehours1 = totalhourweek1 - 40;
                overtimeamount1 = overtimehours1 * ovtsalary;
            }
            if(totalhourweek2 <40)
            {
                reghour2 = totalhourweek2;
                regularamount2 = hourlysalary * reghour2;
                overtimehours2 = 0.00;
                overtimeamount2 = 0.00;
            }
            else if(totalhourweek2 >=40)
            {
                reghour2 = 40;
                regularamount2 = hourlysalary * 40;
                overtimehours2 = totalhourweek2 - 40;
                overtimeamount2 = overtimehours2 * ovtsalary;

                regularhours = reghours1 + reghour2;
                overtimehours = overtimeamount1 + overtimehours2;
                regularamount = regularamount1 + regularamount2;
                overtimamount = overtimeamount1 + overtimeamount2;
                totalearnings = regularamount + overtimamount;

                txtRegularTime.Text = regularhours.ToString("F");
                txtOverTime.Text = overtimehours.ToString("F");
                txtRegularAmount.Text = regularamount.ToString("F");
                txtOverTimeAmount.Text = overtimamount.ToString("F");
                txtNetPay.Text = totalearnings.ToString("F");
            }
            


        }
    }
}
