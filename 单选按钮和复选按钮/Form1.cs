using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 单选按钮和复选按钮
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Year + "年";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Hour + "时";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.Year + "年";
        }
    }
}
