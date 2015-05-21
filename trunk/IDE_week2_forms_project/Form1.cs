using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDE_week2_forms_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Size = new System.Drawing.Size(100, 25);
            label1.BackColor = Color.White;
            label1.Text = "                               ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.Icon1;
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Icon = null;
        }
    }
}
