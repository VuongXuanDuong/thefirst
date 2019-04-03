using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using demo.MODEL;
using demo.CONTROLLER;



namespace demo.VIEW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void clear()
        {
            tbxid.Text = "";
            tbxtensach.Text = "";
            tbxtacgia.Text = "";
            tbxnamxuatban.Text = "";
        }
        private void danhsach_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbxid.Text = danhsach.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbxtensach.Text = danhsach.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxtacgia.Text = danhsach.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxnamxuatban.Text = danhsach.Rows[e.RowIndex].Cells[3].Value.ToString();

        }


        form1controller form1 = new form1controller();
        private void Form1_Load(object sender, EventArgs e)
        {
            danhsach.DataSource = form1.Display();
        }

        private void btxinsert_Click(object sender, EventArgs e)
        {
            form1.Insert(tbxid.Text, tbxtensach.Text, tbxtacgia.Text, tbxnamxuatban.Text);
            Form1_Load(sender, e);
            clear();

        }

        

        private void btndelete_Click(object sender, EventArgs e)
        {
            form1.Delete(tbxid.Text);
            Form1_Load(sender, e);
            clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            form1.Update(tbxid.Text, tbxtensach.Text, tbxtacgia.Text, tbxnamxuatban.Text);
            Form1_Load(sender, e);
            clear();
        }
    }
}
