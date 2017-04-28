namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNext = new System.Windows.Forms.Button();
            this.Btncontinue = new System.Windows.Forms.Button();
            this.lblpassword1 = new System.Windows.Forms.Label();
            this.lblpassword2 = new System.Windows.Forms.Label();
            this.txtpassword1 = new System.Windows.Forms.TextBox();
            this.txtpassword2 = new System.Windows.Forms.TextBox();
            this.lblnote1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(199, 153);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Btncontinue
            // 
            this.Btncontinue.Location = new System.Drawing.Point(199, 292);
            this.Btncontinue.Name = "Btncontinue";
            this.Btncontinue.Size = new System.Drawing.Size(75, 23);
            this.Btncontinue.TabIndex = 2;
            this.Btncontinue.Text = "Continue";
            this.Btncontinue.UseVisualStyleBackColor = true;
            this.Btncontinue.Visible = false;
            this.Btncontinue.Click += new System.EventHandler(this.Btncontinue_Click);
            // 
            // lblpassword1
            // 
            this.lblpassword1.AutoSize = true;
            this.lblpassword1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword1.Location = new System.Drawing.Point(109, 93);
            this.lblpassword1.Name = "lblpassword1";
            this.lblpassword1.Size = new System.Drawing.Size(79, 20);
            this.lblpassword1.TabIndex = 4;
            this.lblpassword1.Text = "Password";
            // 
            // lblpassword2
            // 
            this.lblpassword2.AutoSize = true;
            this.lblpassword2.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword2.Location = new System.Drawing.Point(109, 239);
            this.lblpassword2.Name = "lblpassword2";
            this.lblpassword2.Size = new System.Drawing.Size(79, 20);
            this.lblpassword2.TabIndex = 5;
            this.lblpassword2.Text = "Password";
            this.lblpassword2.Visible = false;
            // 
            // txtpassword1
            // 
            this.txtpassword1.Location = new System.Drawing.Point(188, 93);
            this.txtpassword1.Name = "txtpassword1";
            this.txtpassword1.PasswordChar = '*';
            this.txtpassword1.Size = new System.Drawing.Size(100, 20);
            this.txtpassword1.TabIndex = 7;
            this.txtpassword1.TextChanged += new System.EventHandler(this.txtpassword1_TextChanged);
            // 
            // txtpassword2
            // 
            this.txtpassword2.Location = new System.Drawing.Point(188, 239);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.PasswordChar = '*';
            this.txtpassword2.Size = new System.Drawing.Size(100, 20);
            this.txtpassword2.TabIndex = 8;
            this.txtpassword2.Visible = false;
            // 
            // lblnote1
            // 
            this.lblnote1.AutoSize = true;
            this.lblnote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnote1.Location = new System.Drawing.Point(156, 206);
            this.lblnote1.Name = "lblnote1";
            this.lblnote1.Size = new System.Drawing.Size(173, 13);
            this.lblnote1.TabIndex = 9;
            this.lblnote1.Text = "To confirm, re-enter your password.";
            this.lblnote1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(546, 433);
            this.Controls.Add(this.lblnote1);
            this.Controls.Add(this.txtpassword2);
            this.Controls.Add(this.txtpassword1);
            this.Controls.Add(this.lblpassword2);
            this.Controls.Add(this.lblpassword1);
            this.Controls.Add(this.Btncontinue);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button Btncontinue;
        private System.Windows.Forms.Label lblpassword1;
        private System.Windows.Forms.Label lblpassword2;
        private System.Windows.Forms.TextBox txtpassword1;
        private System.Windows.Forms.TextBox txtpassword2;
        private System.Windows.Forms.Label lblnote1;
    }
}

