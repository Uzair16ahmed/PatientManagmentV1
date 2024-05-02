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
    public partial class MedicineForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\PatientManagementSystemV1.mdf;Integrated Security=True;Connect Timeout=30");

        public MedicineForm()
        {
            InitializeComponent();
        }

        void Clear()
        {
            MedId.Text = "";
            MedicineName.Text = "";
        }

        void Populate()
        {
            Con.Open();
            string query = "select * from MedicineTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            MedicineGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MedId.Text == "" || MedicineName.Text == "")
                MessageBox.Show("No Empty Value Accepted");
            else
            {
                Con.Open();
                string query = "insert into MedicineTbl values(" + MedId.Text + ",'" + MedicineName.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Added");
                Con.Close();
                Populate();
                Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update MedicineTbl set MedicineName = '" + MedicineName.Text + "' where MedId=" + MedId.Text + " ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Successfully Updated");
            Con.Close();
            Populate();
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MedId.Text == "")
                MessageBox.Show("Enter the Medicine Id");
            else
            {
                Con.Open();
                string query = "delete from MedicineTbl where MedId=" + MedId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Deleted");
                Con.Close();
                Populate();
                Clear();
            }
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void MedicineGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedId.Text = MedicineGV.SelectedRows[0].Cells[0].Value.ToString();
            MedicineName.Text = MedicineGV.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
