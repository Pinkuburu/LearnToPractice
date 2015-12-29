using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 列表框和组合框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("请认真校对是否都选择了……");
                return;
            }
            int yearStart = int.Parse(comboBox1.SelectedItem.ToString());
            int yearEnd = int.Parse(comboBox2.SelectedItem.ToString());
            if (yearStart > yearEnd)
            {
                MessageBox.Show("你他妈在逗我吗？");
                return;
            }
            listBox1.Items.Clear();
            for(int i= yearStart; i <= yearEnd; i = i + 1)
            {
                if(i%4==0 && i / 100 != 0 || i % 400 == 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
