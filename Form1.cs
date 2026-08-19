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

            
            //Validate Date in and Out



            //Validate the Type of car



            //---MessageBox---

            MessageBox.Show($"Thank you {txtCustomerName.Text} for renting from us \n" +
                            $"Car rented: {coboxTypeOfCar.Text}\n" +
                            $"Rented Period:  {dateRented.Text} to {dateReturned.Text}",
                            "Submitted",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                                                    


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerName.Text = "";
            coboxTypeOfCar.Text = string.Empty;


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
