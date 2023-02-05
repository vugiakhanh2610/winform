
namespace HelloWorld
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mssv = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.class_ = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ListView();
            this.listViewContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ilsLon = new System.Windows.Forms.ImageList(this.components);
            this.ilsNho = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(140, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lớp";
            // 
            // mssv
            // 
            this.mssv.Location = new System.Drawing.Point(268, 77);
            this.mssv.Name = "mssv";
            this.mssv.Size = new System.Drawing.Size(100, 22);
            this.mssv.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(268, 111);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 7;
            // 
            // class_
            // 
            this.class_.Location = new System.Drawing.Point(268, 220);
            this.class_.Name = "class_";
            this.class_.Size = new System.Drawing.Size(100, 22);
            this.class_.TabIndex = 8;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(268, 147);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 22);
            this.address.TabIndex = 9;
            // 
            // dob
            // 
            this.dob.CustomFormat = "MM/dd/yyyy";
            this.dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dob.Location = new System.Drawing.Point(268, 183);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(200, 22);
            this.dob.TabIndex = 10;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(558, 82);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(128, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Thêm mới";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.clear);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(558, 214);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Thoát";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.close);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(558, 168);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(128, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Xoá item";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.delete);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(558, 124);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(128, 23);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Cập nhật Item";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.add);
            // 
            // itemList
            // 
            this.itemList.ContextMenuStrip = this.listViewContextMenu;
            this.itemList.FullRowSelect = true;
            this.itemList.GridLines = true;
            this.itemList.HideSelection = false;
            this.itemList.Location = new System.Drawing.Point(104, 280);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(582, 143);
            this.itemList.TabIndex = 16;
            this.itemList.UseCompatibleStateImageBehavior = false;
            this.itemList.View = System.Windows.Forms.View.Details;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.listViewItemCLicked);
            // 
            // listViewContextMenu
            // 
            this.listViewContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listViewContextMenu.Name = "listViewContextMenu";
            this.listViewContextMenu.Size = new System.Drawing.Size(211, 32);
            // 
            // ilsLon
            // 
            this.ilsLon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilsLon.ImageSize = new System.Drawing.Size(48, 48);
            this.ilsLon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ilsNho
            // 
            this.ilsNho.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilsNho.ImageSize = new System.Drawing.Size(16, 16);
            this.ilsNho.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.address);
            this.Controls.Add(this.class_);
            this.Controls.Add(this.name);
            this.Controls.Add(this.mssv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "BÀI TẬP LISTVIEW";
            this.Load += new System.EventHandler(this.loadForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mssv;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox class_;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.ListView itemList;
        private System.Windows.Forms.ImageList ilsLon;
        private System.Windows.Forms.ImageList ilsNho;
        private System.Windows.Forms.ContextMenuStrip listViewContextMenu;
    }
}