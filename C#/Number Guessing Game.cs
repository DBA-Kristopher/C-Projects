using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        /* 
        Kristopher Smith
        
        Number Guessing Game */
        Random r = new Random();
        int target;
        int numGuesses=0;

        public Form1()
        {
            InitializeComponent();
            target = r.Next(0 - 100); //target is the comupter pick random
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {

            
            if (!String.IsNullOrEmpty(txtguess.Text))
            {
                int num;
                numGuesses++;
                num = Convert.ToInt32(txtguess.Text);
                if (num < 0 || num > 100)
                {
                    btnEvaluate.Visible = false;
                    MessageBox.Show("Out of range. Enter a number between 0-100");
                    btnTryagain.Visible = true;

                }
                else if (num > target)
                {
                    btnEvaluate.Visible = false;
                    lblguess.Text = "Too high!";
                    this.BackColor = Color.Blue;
                    btnTryagain.Visible = true;
                }
                else if (num < target)
                {
                    btnEvaluate.Visible = false;
                    lblguess.Text = "Too Low!!";
                    this.BackColor = Color.Red;
                    btnTryagain.Visible = true;
                    


                }
                else if (num == target)
                {
                    MessageBox.Show("You guess right in " + numGuesses + " guesses");
                    this.BackColor = Color.Green;

                }

            }
        }

        private void btnTryagain_Click(object sender, EventArgs e)
        {
            txtguess.Clear();
            btnTryagain.Visible = false;
            lblguess.Text = "Enter a guess 0-100";
            btnEvaluate.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtguess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
