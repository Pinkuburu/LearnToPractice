using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picturebox的使用
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 450;
            this.Height = 450;

            pictureBox1.Width = this.Width - 30;
            pictureBox1.Height = this.Height - 120;

            button1.Top = button2.Top = button3.Top = this.Height - button1.Height - 60;
            button1.Left = button2.Left = button3.Left = (this.Width - button1.Width) / 2;

            label1.Top = this.Height - label1.Height - 90;
            label1.Text = "当前显示为第一张图片";
            label1.Left = (this.Width - label1.Width) / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = false;

            pictureBox1.Image = new Bitmap("D:\\Pictures\\1152625 - 副本.jpg");
            label1.Text = "当前显示为第一张图片";
        }

        private void button2_Click(object sender, EventArgs e)
        {
                            button3.Visible = true;
            button2.Visible = false;

            pictureBox1.Image = new Bitmap("D:\\Pictures\\1152625.jpg");
            label1.Text = "当前显示为第二张图片";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = false;

            pictureBox1.Image = new Bitmap("D:\\Pictures\\壁纸.png");
            label1.Text = "当前显示为第三张图片";
        }
    }
}
