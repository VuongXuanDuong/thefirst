using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo.MODEL;
//using demo.CONTROLLER;



namespace demo.VIEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        form1model form1 = new form1model();
        public void clear()
        {
            tbxtensach.Text = "";
            tbxtacgia.Text = "";
            tbxnamxuatban.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = form1.Display();
        }

        private void btninstall_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = form1.install();
        }
    }
}
