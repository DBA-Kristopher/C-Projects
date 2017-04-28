using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace CIS170_Week_7_LAB_Derek_SMith_Fi
{
    public partial class Form1 : Form
    {
        // Kristopher Smith
        // 8/23/2014
        // 
        // Email Contact Form



        public StreamWriter outFile;
        public StreamReader inFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                outFile = new StreamWriter("cis_170.txt", true);
                outFile.WriteLine(txtName.Text);
                outFile.WriteLine(txtEmail.Text);
                outFile.WriteLine();
                outFile.Close();
                txtEmail.Text = "";
                txtName.Text = "";
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }

           listD.Items.Clear();
            string inVal;
            try
            {
                inFile = new StreamReader("cis_170.txt");
                while ((inVal = inFile.ReadLine()) != null)
                {
                    listD.Items.Add(inVal);
                }

                inFile.Close();
            }
            catch (System.IO.IOException exc)
            {
                listD.Items.Add(exc);
            }





            
        }
    }
}
