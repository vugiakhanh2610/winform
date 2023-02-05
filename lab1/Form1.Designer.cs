
namespace HelloWorld
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
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.red = new System.Windows.Forms.RadioButton();
            this.green = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.black = new System.Windows.Forms.RadioButton();
            this.bold = new System.Windows.Forms.CheckBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.underline = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.displayedTextBox = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.GroupBox();
            this.font = new System.Windows.Forms.GroupBox();
            this.color.SuspendLayout();
            this.font.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(635, 385);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuText;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // red
            // 
            this.red.AccessibleName = "red";
            this.red.AutoSize = true;
            this.red.ForeColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(15, 65);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(55, 21);
            this.red.TabIndex = 4;
            this.red.TabStop = true;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            this.red.CheckedChanged += new System.EventHandler(this.red_CheckedChanged);
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.ForeColor = System.Drawing.Color.YellowGreen;
            this.green.Location = new System.Drawing.Point(15, 112);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(69, 21);
            this.green.TabIndex = 5;
            this.green.TabStop = true;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = true;
            this.green.CheckedChanged += new System.EventHandler(this.green_CheckedChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.blue.Location = new System.Drawing.Point(15, 164);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(57, 21);
            this.blue.TabIndex = 6;
            this.blue.TabStop = true;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = true;
            this.blue.CheckedChanged += new System.EventHandler(this.blue_CheckedChanged);
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.BackColor = System.Drawing.Color.DimGray;
            this.black.Location = new System.Drawing.Point(15, 212);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(63, 21);
            this.black.TabIndex = 7;
            this.black.TabStop = true;
            this.black.Text = "Black";
            this.black.UseVisualStyleBackColor = false;
            this.black.CheckedChanged += new System.EventHandler(this.black_CheckedChanged);
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.ForeColor = System.Drawing.Color.Blue;
            this.bold.Location = new System.Drawing.Point(41, 55);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(91, 21);
            this.bold.TabIndex = 8;
            this.bold.Text = "Đậm Bold";
            this.bold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // italic
            // 
            this.italic.AutoSize = true;
            this.italic.ForeColor = System.Drawing.Color.Blue;
            this.italic.Location = new System.Drawing.Point(41, 103);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(115, 21);
            this.italic.TabIndex = 9;
            this.italic.Text = "Nghiêng Italic";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // underline
            // 
            this.underline.AutoSize = true;
            this.underline.ForeColor = System.Drawing.Color.Blue;
            this.underline.Location = new System.Drawing.Point(41, 154);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(99, 21);
            this.underline.TabIndex = 10;
            this.underline.Text = "Gạch chân";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.CheckedChanged += new System.EventHandler(this.underline_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(91, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lập trình bởi";
            // 
            // displayedTextBox
            // 
            this.displayedTextBox.AutoSize = true;
            this.displayedTextBox.Location = new System.Drawing.Point(210, 347);
            this.displayedTextBox.Name = "displayedTextBox";
            this.displayedTextBox.Size = new System.Drawing.Size(0, 17);
            this.displayedTextBox.TabIndex = 12;
            // 
            // color
            // 
            this.color.Controls.Add(this.black);
            this.color.Controls.Add(this.blue);
            this.color.Controls.Add(this.green);
            this.color.Controls.Add(this.red);
            this.color.Location = new System.Drawing.Point(22, 61);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(120, 255);
            this.color.TabIndex = 13;
            this.color.TabStop = false;
            this.color.Text = "Color";
            // 
            // font
            // 
            this.font.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.font.Controls.Add(this.underline);
            this.font.Controls.Add(this.italic);
            this.font.Controls.Add(this.bold);
            this.font.Location = new System.Drawing.Point(242, 61);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(176, 254);
            this.font.TabIndex = 14;
            this.font.TabStop = false;
            this.font.Text = "Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.font);
            this.Controls.Add(this.color);
            this.Controls.Add(this.displayedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Định dạng (Formatter)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.color.ResumeLayout(false);
            this.color.PerformLayout();
            this.font.ResumeLayout(false);
            this.font.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.RadioButton green;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton black;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox italic;
        private System.Windows.Forms.CheckBox underline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label displayedTextBox;
        private System.Windows.Forms.GroupBox color;
        private System.Windows.Forms.GroupBox font;
    }
}

