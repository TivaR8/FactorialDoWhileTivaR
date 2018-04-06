using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 6-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Factorial Do While
 * This program calculates the factroial of any number the user enters
*/

namespace FactorialDoWhileTivaR
{
    public partial class frmFactorialWhile : Form
    {
        public frmFactorialWhile()
        {
            InitializeComponent();

            // Hide the answer text
            lblAnswer.Hide();
        }

        private void btnGetAnswer_Click(object sender, EventArgs e)
        {
            // Declare the variables
            Double factorialAnswer;
            Double factorialNumber;
            int factorialCounter;

            // Clear the list box
            this.lstFactorial.Items.Clear();

            // Set final answer to 1
            factorialNumber = 1;

            // Set counter to 0
            factorialCounter = 0;

            // Get the users number from thw text box
            factorialAnswer = Convert.ToDouble(this.txtNumber.Text);

            // Start to do the calculations of the factorials
            do
            {
                // Increment the counter
                factorialCounter = factorialCounter + 1;

                // Show the counter number in the list box for the user
                this.lstFactorial.Items.Add(factorialCounter);

                // Get previous number 
                factorialNumber =  
                // Multiply the factorial counter by answer
                factorialAnswer = factorialCounter * factorialAnswer;

            } while (factorialCounter <+ factorialAnswer);

            // Display the answer
            lblAnswer.Show();
            this.lblAnswer.Text = this.txtNumber.Text + "! =" + Convert.ToString(factorialAnswer);
        }
    }
}
