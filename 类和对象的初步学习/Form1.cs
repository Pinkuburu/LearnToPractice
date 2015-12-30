using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 类和对象的初步学习
{
    
    public partial class Form1 : Form
    {
        
        Student s1 = new Student();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textID.Text == "" || textName.Text == "" || textSex.Text == "")
            {
                return;
            }
            s1.ID = textID.Text;
            s1.Name = textName.Text;
            s1.Sex = textSex.Text;
            label4.Text = "設置完畢";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "学号:" + s1.ID + "  姓名：" + s1.Name + "   性别：" + s1.Sex;
        }
    }
    class Student
    {
        public string ID, Name, Sex;
    }
}
