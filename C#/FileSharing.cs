﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreatingFilesCSharp
{
    public partial class Form1 : Form
    {
        public StreamWriter outFile;
        public StreamReader inFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (File.Exists("cis170.txt"))
            {
                MessageBox.Show("File cis170 Exists ");
            }
            else
            {

                FileStream fs = File.Create("cis170.txt");
                MessageBox.Show("File cis170 created ");
                MessageBox.Show("File Creation Time " + File.GetCreationTime("cis170.txt"));

            }

        }

        private void btnPrintDirectory_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            string msg = "";
            msg += dir;
            string[] files = Directory.GetFiles(dir);
            foreach (string val in files)
            {
                msg += val;
                msg += "\n";

            }
            MessageBox.Show(msg);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {


            }
            catch (DirectoryNotFoundException exc)
            {
                MessageBox.Show(exc.Message);
            }
            catch (System.IO.IOException err)
            {
                MessageBox.Show(err.Message);
            }

        }

        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                outFile.Close();
                inFile.Close();
            }
            catch
            {
                MessageBox.Show("File did not close properly");
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                outFile = new StreamWriter("cis170.txt", true);
                outFile.WriteLine(txtName.Text);
                outFile.WriteLine(txtMessage.Text);
                outFile.Close();
                txtMessage.Text = "";
                txtName.Text = "";
            }
            catch (System.IO.IOException exc)
            {
                MessageBox.Show(exc.Message);
            }


        


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            string inVal;
            try
            {
                inFile = new StreamReader("cis170.txt");
                while ((inVal = inFile.ReadLine()) != null)
                {
                    lstDisplay.Items.Add(inVal);
                }

                inFile.Close();
            }
            catch (System.IO.IOException exc)
            {
                lstDisplay.Items.Add(exc);
            }
        }





    }
}
