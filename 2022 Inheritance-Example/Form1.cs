using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2022_Inheritance_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       


        private void btnEmployee_Click_1(object sender, EventArgs e)
        {
            double salary = 10000;
            double commission = salary * 0.25;
          
            CommissionEmployee empl = new CommissionEmployee();

            empl.Name = "Aviwe";
            empl.Surname = "Botoman";
            empl.DOB = "17 April 2001";
            empl.IDNumber = "0104175523083";
            empl.Salary = salary;
            empl.CommissionRate = commission;

            lblStudent.Text = empl.Name;
            lblSurname.Text = empl.Surname;
            lblDOB.Text = empl.DOB;
            lblId.Text = empl.IDNumber;
            lblSalaraFee.Text =empl.Salary.ToString("C");
            lblCommisionCalculated.Text =empl.CommissionRate.ToString("C");



        }

        private void btnStudent_Click_1(object sender, EventArgs e)
        {
            double fee = 1500;
            double calcuRate = 0;

            PartTimeStudent stu = new PartTimeStudent();

            stu.Name = "Aviwe";
            stu.Surname = "Botoman";
            stu.DOB = "17 April 2001";
            stu.IDNumber = "0104175523083";
            stu.Fees = fee;
            calcuRate = stu.CalculatedFee(fee);


            lblStudent.Text = stu.Name;
            lblSurname.Text = stu.Surname;
            lblDOB.Text = stu.DOB;
            lblId.Text = stu.IDNumber;
            lblSalaraFee.Text = stu.Fees.ToString("C");
            lblCommisionCalculated.Text =calcuRate.ToString("C");
        }
    }
}
