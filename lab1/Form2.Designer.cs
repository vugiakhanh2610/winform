
namespace HelloWorld
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.link = new System.Windows.Forms.LinkLabel();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.qualification = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.address_ = new System.Windows.Forms.MaskedTextBox();
            this.dob = new System.Windows.Forms.MaskedTextBox();
            this.doj = new System.Windows.Forms.MaskedTextBox();
            this.country = new System.Windows.Forms.ComboBox();
            this.city_ = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name:";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date of Birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qualification:";
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Location = new System.Drawing.Point(175, 175);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(35, 17);
            this.city.TabIndex = 3;
            this.city.Text = "City:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(146, 140);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(64, 17);
            this.address.TabIndex = 4;
            this.address.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "(mm/dd/yyyy)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Country:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date of Joining:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 461);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "(mm/dd/yyyy)";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(138, 499);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(121, 17);
            this.link.TabIndex = 11;
            this.link.TabStop = true;
            this.link.Text = "Link to VnExpress";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(274, 499);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(105, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(385, 499);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(274, 56);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(206, 22);
            this.name.TabIndex = 14;
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // qualification
            // 
            this.qualification.Location = new System.Drawing.Point(274, 285);
            this.qualification.Multiline = true;
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(206, 61);
            this.qualification.TabIndex = 18;
            this.qualification.Leave += new System.EventHandler(this.qualification_Leave);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(274, 405);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(206, 22);
            this.email.TabIndex = 20;
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(274, 368);
            this.phone.Mask = "000-0000000";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(206, 22);
            this.phone.TabIndex = 21;
            this.phone.Leave += new System.EventHandler(this.phone_Leave);
            // 
            // address_
            // 
            this.address_.Location = new System.Drawing.Point(274, 140);
            this.address_.Name = "address_";
            this.address_.Size = new System.Drawing.Size(206, 22);
            this.address_.TabIndex = 22;
            this.address_.Leave += new System.EventHandler(this.address__Leave);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(274, 89);
            this.dob.Mask = "00/00/0000";
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(206, 22);
            this.dob.TabIndex = 23;
            this.dob.Leave += new System.EventHandler(this.dob_Leave);
            // 
            // doj
            // 
            this.doj.Location = new System.Drawing.Point(274, 444);
            this.doj.Mask = "00/00/0000";
            this.doj.Name = "doj";
            this.doj.Size = new System.Drawing.Size(206, 22);
            this.doj.TabIndex = 24;
            this.doj.Leave += new System.EventHandler(this.doj_Leave);
            // 
            // country
            // 
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "VietNam",
            "ThaiLan"});
            this.country.Location = new System.Drawing.Point(274, 246);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(121, 24);
            this.country.TabIndex = 25;
            this.country.Text = "(Select)";
            this.country.Leave += new System.EventHandler(this.country_Leave);
            // 
            // city_
            // 
            this.city_.Location = new System.Drawing.Point(274, 175);
            this.city_.Multiline = true;
            this.city_.Name = "city_";
            this.city_.Size = new System.Drawing.Size(206, 60);
            this.city_.TabIndex = 17;
            this.city_.Leave += new System.EventHandler(this.city__Leave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 552);
            this.Controls.Add(this.country);
            this.Controls.Add(this.doj);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.address_);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.qualification);
            this.Controls.Add(this.city_);
            this.Controls.Add(this.name);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.link);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.address);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Employee Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox qualification;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.MaskedTextBox address_;
        private System.Windows.Forms.MaskedTextBox dob;
        private System.Windows.Forms.MaskedTextBox doj;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.TextBox city_;
    }
}