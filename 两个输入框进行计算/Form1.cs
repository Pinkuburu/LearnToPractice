using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace 两个输入框进行计算
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int number1, number2, number3;
            number1 = Convert.ToInt32(inputNumber1.Text);
            number2 = Convert.ToInt32(inputNumber2.Text);

            result.Text = "计算结果如下：\n";
            number3 = number1 + number2;
            result.Text +=("两个数的和为："+number3+"\n");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputNumber1.Clear();
            inputNumber1.Focus();
            inputNumber2.Clear();
            result.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //linkLabel1.LinkVisited = true;
            Process.Start(linkLabel1.Text.Substring(0));
        }
    }
}
