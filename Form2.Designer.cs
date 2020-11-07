namespace HotelManagerForm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Employee = new System.Windows.Forms.Button();
            this.CustomerDetails = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.movingpanel = new System.Windows.Forms.Panel();
            this.CustomerRegistration = new System.Windows.Forms.Button();
            this.AddRoom = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Employee);
            this.panel1.Controls.Add(this.CustomerDetails);
            this.panel1.Controls.Add(this.Checkout);
            this.panel1.Controls.Add(this.movingpanel);
            this.panel1.Controls.Add(this.CustomerRegistration);
            this.panel1.Controls.Add(this.AddRoom);
            this.panel1.Location = new System.Drawing.Point(59, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 208);
            this.panel1.TabIndex = 0;
            // 
            // Employee
            // 
            this.Employee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Employee.Location = new System.Drawing.Point(1058, 38);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(146, 82);
            this.Employee.TabIndex = 3;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = false;
            this.Employee.Click += new System.EventHandler(this.button4_Click);
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomerDetails.Location = new System.Drawing.Point(867, 38);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(155, 82);
            this.CustomerDetails.TabIndex = 2;
            this.CustomerDetails.Text = "CustomerDetails";
            this.CustomerDetails.UseVisualStyleBackColor = false;
            this.CustomerDetails.Click += new System.EventHandler(this.CustomerDetails_Click);
            // 
            // Checkout
            // 
            this.Checkout.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Checkout.Location = new System.Drawing.Point(631, 38);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(146, 82);
            this.Checkout.TabIndex = 1;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = false;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // movingpanel
            // 
            this.movingpanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.movingpanel.Location = new System.Drawing.Point(62, 140);
            this.movingpanel.Name = "movingpanel";
            this.movingpanel.Size = new System.Drawing.Size(140, 5);
            this.movingpanel.TabIndex = 0;
            // 
            // CustomerRegistration
            // 
            this.CustomerRegistration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomerRegistration.Location = new System.Drawing.Point(268, 38);
            this.CustomerRegistration.Name = "CustomerRegistration";
            this.CustomerRegistration.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustomerRegistration.Size = new System.Drawing.Size(275, 82);
            this.CustomerRegistration.TabIndex = 0;
            this.CustomerRegistration.Text = "Customer Registration";
            this.CustomerRegistration.UseVisualStyleBackColor = false;
            this.CustomerRegistration.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddRoom
            // 
            this.AddRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddRoom.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddRoom.Location = new System.Drawing.Point(62, 38);
            this.AddRoom.Name = "AddRoom";
            this.AddRoom.Size = new System.Drawing.Size(138, 82);
            this.AddRoom.TabIndex = 0;
            this.AddRoom.Text = "AddRoom";
            this.AddRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddRoom.UseVisualStyleBackColor = false;
            this.AddRoom.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(-2, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1324, 463);
            this.panel2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(-2, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CustomerRegistration;
        private System.Windows.Forms.Panel movingpanel;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Button CustomerDetails;
        private System.Windows.Forms.Button Checkout;
    }
}