﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerSYS
{
    public partial class frmSetCategory : Form
    {

        public frmSetCategory()
        {
            InitializeComponent();
        }

        internal class Show
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu to = new frmMainMenu();
            to.Show();
            this.Close();
        }



        private void btnSetCategory_Click(object sender, EventArgs e)
        {

            HashSet<string> enteredData = new HashSet<string>();

            while (true)
            {
                Console.Write("Enter data: ");
                string userInput = Console.ReadLine();

                if (enteredData.Contains(userInput))
                {
                    Console.WriteLine("This data has already been entered.");
                }
                else
                {
                    enteredData.Add(userInput);
                    Console.WriteLine("Data saved.");
                }
            }

            // Validate form inputs
            if (txtdescription.Text.Equals(""))
                {
                    MessageBox.Show("Description must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdescription.Focus();
                    return;
                }

                decimal price;
                if (!decimal.TryParse(txtPrice.Text, out price))
                {
                    MessageBox.Show("Price must be a decimal value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return;
                }

                int noSeats, seatFrom, seatTo;
                if (!int.TryParse(txtNoSeats.Text, out noSeats) || noSeats <= 0)
                {
                    MessageBox.Show("Number of Seats must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoSeats.Focus();
                    return;
                }
                int TotalSeats = 10000;
                if (noSeats > TotalSeats)
                {
                    MessageBox.Show("Number of Seats of the Categories must not exceed the Total Seats of the stadium of 10000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                if (!int.TryParse(txtNoSeatsFrom.Text, out seatFrom) || seatFrom <= 0)
                {
                    MessageBox.Show("Number of Seats from must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoSeatsFrom.Focus();
                    return;
                }
                if (!int.TryParse(txtNoSeatsTo.Text, out seatTo) || seatTo <= 0)
                {
                    MessageBox.Show("Number of Seats to must be a positive integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoSeatsTo.Focus();
                    return;
                }
                if (seatTo < seatFrom)
                {
                    MessageBox.Show("Number of Seats To must be greater than or equal to Number of Seats from", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNoSeatsTo.Focus();
                    return;


                }
                Category ticketIDCat = new Category();
                int ticketId = ticketIDCat.setTicketID();

                Category aCategory = new Category(ticketId, txtCatCode.Text, txtdescription.Text, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtNoSeats.Text),
                        Convert.ToInt32(txtNoSeatsFrom.Text), Convert.ToInt32(txtNoSeatsTo.Text), 'A');

                Console.WriteLine(aCategory.getTicketID());


                aCategory.SetCategory();

                MessageBox.Show("Category Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtCatCode.Clear();
                txtdescription.Clear();
                txtPrice.Clear();
                txtNoSeats.Clear();
                txtNoSeatsFrom.Clear();
                txtNoSeatsTo.Clear();
            }
        }
    }

       
    
