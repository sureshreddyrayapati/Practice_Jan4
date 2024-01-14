using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jan4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hii i am a box");

            Button b=new Button();
            b.Text= "OK";
            b.ForeColor = Color.Aqua;
            b.BackColor = Color.White;
            b.Click += button1_Click;
            b.Location=new Point(100,200);
            b.FlatStyle = FlatStyle.Flat;

            this.Controls.Add(b);
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hii suresh");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hii Raa");
        }
    }
}
