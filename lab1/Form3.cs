using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void exitButtonCLicked(object sender, EventArgs eventArgs)
        {
            this.Close();
        }
        private void calcelButtonCLicked(object sender, EventArgs eventArgs)
        {
            mssv.Text = string.Empty;
            name.Text = string.Empty;
            year.Text = string.Empty;
            class_.Text = string.Empty;

            foreach (Control control in groupBoxSemester.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    radioButton.Checked = false;
                }
            }

            foreach (Control control in groupBoxCourse.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = control as CheckBox;
                    checkBox.Checked = false;
                }
            }
            formLoad(sender, eventArgs);
        }

        private string getAllCheckedCourses()
        {
            string result = "";
            int stt = 1;
            foreach (Control control in groupBoxCourse.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = control as CheckBox;
                    if (checkBox.Checked == true)
                    {
                        result += $"{stt}. {checkBox.Text}\n";
                        stt += 1;
                    }
                }
            }
            return result;
        }

        private string getSemester()
        {
            foreach(Control control in groupBoxSemester.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = control as RadioButton;
                    if (radioButton.Checked == true)
                    {
                        return radioButton.Text;
                    }
                }
            }
            return "";
        }


        private void submitButtonClicked(object sender, EventArgs eventArgs)
        {
            MessageBox.Show(
                    $"Sinh viên: {name.Text}\n" +
                    $"Lớp: {class_.Text}\n" +
                    $"Niên khoá: {year.Text}\n" +
                    $"Đã đăng ký học Học kỳ {getSemester()} các môn học sau:\n" +
                    $"{getAllCheckedCourses()}",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            calcelButtonCLicked(sender, eventArgs);

        }
        private void formLoad(object sender, EventArgs eventArgs)
        {
            radioButton1.Checked = true;
        }
    } 
}
