namespace HotelManagerForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closebutton = new System.Windows.Forms.Button();
            this.labelerror = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.closebutton);
            this.panel1.Controls.Add(this.labelerror);
            this.panel1.Controls.Add(this.Login);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(542, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 391);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // closebutton
            // 
            this.closebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebutton.BackgroundImage")));
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closebutton.Location = new System.Drawing.Point(0, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(52, 34);
            this.closebutton.TabIndex = 5;
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelerror.ForeColor = System.Drawing.Color.DarkRed;
            this.labelerror.Location = new System.Drawing.Point(338, 361);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(203, 14);
            this.labelerror.TabIndex = 4;
            this.labelerror.Text = "Wrong usernameor Password";
            this.labelerror.Visible = false;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.DarkGreen;
            this.Login.ForeColor = System.Drawing.SystemColors.Info;
            this.Login.Location = new System.Drawing.Point(362, 292);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(151, 46);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Location = new System.Drawing.Point(314, 184);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.Size = new System.Drawing.Size(257, 24);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpassword.UseWaitCursor = true;
            // 
            // txtusername
            // 
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Location = new System.Drawing.Point(314, 131);
            this.txtusername.Name = "txtusername";
            this.txtusername.PlaceholderText = "Username";
            this.txtusername.Size = new System.Drawing.Size(257, 24);
            this.txtusername.TabIndex = 2;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusername.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(349, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1436, 659);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label labelerror;
        private System.Windows.Forms.Button closebutton;
    }
}

