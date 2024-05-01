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
    public partial class DiagnosisForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\PatientManagementSystemV1.mdf;Integrated Security=True;Connect Timeout=30");

        public DiagnosisForm()
        {
            InitializeComponent();
        }
        void PopulateCombo()
        {
            string sql = "select * from PatientTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        string patientName;
        void FetchPatientName()
        {
            Con.Open();
            string sql = "select * from PatientTbl where PatId=" + PatientIdCb.SelectedValue.ToString() + " ";
            SqlCommand cmd = new SqlCommand(sql, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patientName = dr["PatName"].ToString();
                PatientTb.Text = patientName;
            }
            Con.Close();
        }
        void Populate()
        {
            Con.Open();
            string query = "select * from DiagnosisTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        /* void Visible()
         {
             Medicineslbl.Visible = true;
             PatientNamelbl.Visible = true;
             Diagnosislbl.Visible = true;
             Symptoms.Visible = true;
         }*/

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            PopulateCombo();
            Populate();
            label9.Text = DateTime.Now.ToString();
            //Visible();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptoms.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnosis.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Medicines.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "" || Medicines.Text == "" || Diagnosis.Text == "" || Symptoms.Text == "" || PatientTb.Text == "")
                MessageBox.Show("No Empty Value Accepted");
            else
            {
                Con.Open();
                string query = "insert into DiagnosisTbl values(" + DiagId.Text + ", '" + PatientIdCb.SelectedValue.ToString() + "', '" + PatientTb.Text + "', '" + Symptoms.Text + "', '" + Diagnosis.Text + "', '" + Medicines.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Added");
                Con.Close();
                Populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
                MessageBox.Show("Enter the Diagnosis Id");
            else
            {
                Con.Open();
                string query = "delete from DiagnosisTbl where DiagId=" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Deleted");
                Con.Close();
                Populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "update DiagnosisTbl set PatId = " + PatientIdCb.SelectedValue.ToString() + ", PatName='" + PatientTb.Text + "', Symptoms='" + Symptoms.Text + "', Diagnosis='" + Diagnosis.Text + "', Medicines='" + Medicines.Text + "'  where DiagId=" + DiagId.Text + " ";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Successfully Updated");
            Con.Close();
            Populate();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchPatientName();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString(label4.Text + "\n\n\n\n\n\n\n\n\n\n", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(label4.Text, new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString(PatientNamelbl.Text + "\n" + Diagnosislbl.Text + "\n" + Symptomslbl.Text + "\n" + Medicineslbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Black, new Point(130, 150));
            e.Graphics.DrawString(label4.Text + "\n", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230, 500));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
