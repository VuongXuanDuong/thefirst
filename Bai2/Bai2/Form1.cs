using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=hocwinform;Uid=root;Pwd=");
        MySqlCommand cmd;
        MySqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record
        int id = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void DisplayData()
        {
            connection.Open();
            DataTable dt = new DataTable();
            adapt = new MySqlDataAdapter("SELECT * FROM quanlysach1", connection);
            adapt.Fill(dt);
            //danhsach.DataSource = dt;
            danhsach.Rows.Clear();

            foreach(DataRow row in dt.Rows)
            {
                int n = danhsach.Rows.Add();
                danhsach.Rows[n].Cells["dgvid"].Value = row["id"];
                danhsach.Rows[n].Cells["dgvtensach"].Value = row["tensach"];
                danhsach.Rows[n].Cells["dgvtacgia"].Value = row["tacgia"];
                danhsach.Rows[n].Cells["dgvnamxuatban"].Value = row["namxuatban"];

            }
            this.danhsach.Columns["dgvid"].SortMode = DataGridViewColumnSortMode.Automatic;
            connection.Close();
        }
        //Clear Data
        private void Clear()
        {
            tbxtensach.Text = "";
            tbxtacgia.Text = "";
            tbxnamxuatban.Text = "";
            id = 0;
        }

        private void btninstall_Click(object sender, EventArgs e)
        {   
            if (tbxtensach.Text != " " && tbxtacgia.Text != "" && tbxnamxuatban.Text != "")
            {
                cmd = new MySqlCommand("INSERT INTO quanlysach1(tensach,tacgia,namxuatban) VALUES(@tensach,@tacgia,@namxuatban)", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@tensach", tbxtensach.Text);
                cmd.Parameters.AddWithValue("@tacgia", tbxtacgia.Text);
                cmd.Parameters.AddWithValue("@namxuatban", tbxnamxuatban.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                MessageBox.Show("Record Inserted Successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        private void danhsach_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(danhsach.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxtensach.Text = danhsach.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxtacgia.Text = danhsach.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxnamxuatban.Text = danhsach.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                cmd = new MySqlCommand("DELETE FROM quanlysach1 WHERE id=@id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                MessageBox.Show("Deleted Successfully!");
                Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tbxtensach.Text != " " && tbxtacgia.Text != "" && tbxnamxuatban.Text != "")
            {
                cmd = new MySqlCommand("UPDATE quanlysach1 SET tensach=@tensach,tacgia=@tacgia, namxuatban=@namxuatban WHERE id=@id", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@tensach", tbxtensach.Text);
                cmd.Parameters.AddWithValue("@tacgia", tbxtacgia.Text);
                cmd.Parameters.AddWithValue("@namxuatban", tbxnamxuatban.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
                DisplayData();
                MessageBox.Show("Record Updated Successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btntacgia_Click(object sender, EventArgs e)
        {
            this.Hide();
            tacgia tg = new tacgia();
            tg.Show();
        }
    }
}
