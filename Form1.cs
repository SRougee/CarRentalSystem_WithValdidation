using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalSystem_WithValdidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //---Validate---
            //Validate the Customer name

            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("Custemer name is empty please enter a valid string.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error); 
                return;
            }

            //Validate Date in and Out

            if (dateRented.Value.Date > dateReturned.Value.Date)
            {
                MessageBox.Show("Date Rented cannot be after the date returned.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //Validate the Type of car

            if (string.IsNullOrEmpty(coboxTypeOfCar.Text))
            {
                MessageBox.Show("A type of car must be selected",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //Validate Rental Amount

            if (!double.TryParse(txtRentalCost.Text,out double amount) || amount <= 0)
            {
                MessageBox.Show("A Valid amount larger than 0 must be entered",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //---Name changing---
            string customerName = txtCustomerName.Text;
            string dateOut = dateRented.Value.ToShortDateString();
            string dateIn = dateReturned.Value.ToShortDateString();
            string typecar = coboxTypeOfCar.SelectedItem.ToString(); 


            //---MessageBox---

            MessageBox.Show($"Thank you {customerName} for renting from us \n" +
                            $"Car rented: {typecar}\n" +
                            $"Rented Period:  {dateOut} to {dateIn}\n" +
                            $"The amount is R{amount}",
                            "Submitted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                                                    


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = string.Empty;
            coboxTypeOfCar.Text = string.Empty;
            txtRentalCost.Text = string.Empty;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
