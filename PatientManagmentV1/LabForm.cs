using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagmentV1
{
    public partial class LabForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\PatientManagementSystemV1.mdf;Integrated Security=True;Connect Timeout=30");

        public LabForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void Clear()
        {
            LabId.Text = "";
            LabName.Text = "";
        }

        void Populate()
        {
            Con.Open();
            string query = "select * from LabTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LabGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LabId.Text == "" || LabName.Text == "")
                MessageBox.Show("No Empty Value Accepted");
            else
            {
                Con.Open();
                string query = "insert into LabTbl values(" + LabId.Text + ",'" + LabName.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lab Successfully Added");
                Con.Close();
                Populate();
                Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update LabTbl set LabName = '" + LabName.Text + "' where LabId=" + LabId.Text + " ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Lab Successfully Updated");
            Con.Close();
            Populate();
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LabId.Text == "")
                MessageBox.Show("Enter the Lab Id");
            else
            {
                Con.Open();
                string query = "delete from LabTbl where LabId=" + LabId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Lab Successfully Deleted");
                Con.Close();
                Populate();
                Clear();
            }
        }

        private void LabForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void LabGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LabId.Text = LabGV.SelectedRows[0].Cells[0].Value.ToString();
            LabName.Text = LabGV.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
