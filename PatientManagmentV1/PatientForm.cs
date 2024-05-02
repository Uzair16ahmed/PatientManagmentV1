using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagmentV1
{
    public partial class PatientForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\PatientManagementSystemV1.mdf;Integrated Security=True;Connect Timeout=30");
        public PatientForm()
        {
            InitializeComponent();
        }

        private void Clear()
        {

            PatId.Text = "";
            PatName.Text = "";
            PatAddress.Text = "";
            PatPhone.Text = "";
            PatAge.Text = "";
            PatGender.Text = "";
            PatBlood.Text = "";
            PatDisease.Text = "";

        }

        void Populate()
        {
            Con.Open();
            string query = "select * from PatientTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAddress.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || PatDisease.Text == "")
                MessageBox.Show("No Empty Value Accepted");
            else
            {
                Con.Open();
                string query = "insert into PatientTbl values(" + PatId.Text + ",'" + PatName.Text + "','" + PatAddress.Text + "','" + PatPhone.Text + "'," + PatAge.Text + ",'" + PatGender.SelectedItem.ToString() + "','" + PatBlood.SelectedItem.ToString() + "','" + PatDisease.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Added");
                Con.Close();
                Populate();
                Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update PatientTbl set PatName = '" + PatName.Text + "', PatAddress='" + PatAddress.Text + "', PatPhone='" + PatPhone.Text + "', PatAge=" + PatAge.Text + ",PatGender='" + PatGender.SelectedItem.ToString() + "',PatBlood='" + PatBlood.SelectedItem.ToString() + "', PatDisease='" + PatDisease.Text + "'  where PatId=" + PatId.Text + " ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Successfully Updated");
            Con.Close();
            Populate();
            Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
                MessageBox.Show("Enter the Patient Id");
            else
            {
                Con.Open();
                string query = "delete from PatientTbl where PatId=" + PatId.Text + ""; SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Successfully Deleted");
                Con.Close();
                Populate();
                Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            Populate();
        }


        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAddress.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            PatGender.Text = PatientGV.SelectedRows[0].Cells[5].Value.ToString();
            PatBlood.Text = PatientGV.SelectedRows[0].Cells[6].Value.ToString();
            PatDisease.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
