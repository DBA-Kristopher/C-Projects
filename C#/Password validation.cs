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
        //Kristopher Smith
        
        //8-17-2014
        //Password Confirm Program
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtpassword1.Text))
            {
                MessageBox.Show("Please enter a password");
            }
            else
            {
                
                lblpassword2.Visible = true;
                txtpassword2.Visible = true;
                Btncontinue.Visible = true;
                lblnote1.Visible = true;

            }




        }

        private void txtpassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btncontinue_Click(object sender, EventArgs e)
        {
            String pass1, pass2;
            pass1 = txtpassword1.Text;
            pass2 = txtpassword2.Text;



            if (String.IsNullOrEmpty(txtpassword1.Text))

            {
                  MessageBox.Show("Please enter a password again");
            }
            else if (pass1 == pass2)
            {
                MessageBox.Show("Passwords are the same.");



            }
            else
            {
                MessageBox.Show("Passwords are different");
            }

        }
    }
}
