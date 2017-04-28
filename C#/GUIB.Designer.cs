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
            this.lblguess = new System.Windows.Forms.Label();
            this.txtguess = new System.Windows.Forms.TextBox();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnTryagain = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtabout = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblguess
            // 
            this.lblguess.AutoSize = true;
            this.lblguess.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblguess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblguess.Location = new System.Drawing.Point(123, 158);
            this.lblguess.Name = "lblguess";
            this.lblguess.Size = new System.Drawing.Size(157, 20);
            this.lblguess.TabIndex = 0;
            this.lblguess.Text = "Enter a guess 0-100:";
            // 
            // txtguess
            // 
            this.txtguess.Location = new System.Drawing.Point(326, 158);
            this.txtguess.Multiline = true;
            this.txtguess.Name = "txtguess";
            this.txtguess.Size = new System.Drawing.Size(121, 39);
            this.txtguess.TabIndex = 1;
            this.txtguess.TextChanged += new System.EventHandler(this.txtguess_TextChanged);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEvaluate.Location = new System.Drawing.Point(326, 242);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(121, 39);
            this.btnEvaluate.TabIndex = 2;
            this.btnEvaluate.Text = "Press to Evluate your guess!";
            this.btnEvaluate.UseVisualStyleBackColor = false;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnTryagain
            // 
            this.btnTryagain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTryagain.Location = new System.Drawing.Point(326, 333);
            this.btnTryagain.Name = "btnTryagain";
            this.btnTryagain.Size = new System.Drawing.Size(121, 39);
            this.btnTryagain.TabIndex = 3;
            this.btnTryagain.Text = "Try Again";
            this.btnTryagain.UseVisualStyleBackColor = false;
            this.btnTryagain.Visible = false;
            this.btnTryagain.Click += new System.EventHandler(this.btnTryagain_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Yellow;
            this.lblWelcome.Location = new System.Drawing.Point(251, 23);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(173, 42);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome";
            // 
            // txtabout
            // 
            this.txtabout.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtabout.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtabout.Location = new System.Drawing.Point(1, 78);
            this.txtabout.Multiline = true;
            this.txtabout.Name = "txtabout";
            this.txtabout.Size = new System.Drawing.Size(88, 161);
            this.txtabout.TabIndex = 5;
            this.txtabout.Text = "About this game: rules are simple. Try to guess the randomly generated number bet" +
    "ween 0-100. The computer will tell you if you are too high or too low. GoodLuck!" +
    "";
            this.txtabout.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 384);
            this.Controls.Add(this.txtabout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnTryagain);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.txtguess);
            this.Controls.Add(this.lblguess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblguess;
        private System.Windows.Forms.TextBox txtguess;
        private System.Windows.Forms.Button btnEvaluate;
        private System.Windows.Forms.Button btnTryagain;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtabout;
    }
}

