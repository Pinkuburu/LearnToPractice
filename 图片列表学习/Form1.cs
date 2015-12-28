using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图片列表学习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.ImageList = imageList1;

            label1.ImageIndex = 0;
            this.BackgroundImage = imageList1.Images[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Show();
            label2.ImageList = imageList1;
            label2.ImageIndex = 1;
            this.BackgroundImage = imageList1.Images[1];
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Show();
            label3.ImageList = imageList1;
            label3.ImageIndex = 2;
            this.BackgroundImage = imageList1.Images[2];
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label1.Show();
            label1.ImageList = imageList1;
            label1.ImageIndex = 0;
            this.BackgroundImage = imageList1.Images[0];
        }
    }
}
