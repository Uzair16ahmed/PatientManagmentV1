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
    public partial class ExaminationForm : Form
    {
        readonly SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\PatientManagementSystemV1.mdf;Integrated Security=True;Connect Timeout=30");

        public ExaminationForm()
        {
            InitializeComponent();
        }
        void Clear()
        {
            ExamId.Text = "";
            Symptoms.Text = "";
            Diagnosis.Text = "";
            Examination.Text = "";
            LabNameCb.Text = "LabName";
        }

        void Populate()
        {
            Con.Open();
            string query = "select * from ExaminationTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ExaminationGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        void PopulateLabCombo()
        {
            string sql = "select * from LabTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("LabName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                LabNameCb.ValueMember = "LabName";
                LabNameCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        private void ExaminationForm_Load(object sender, EventArgs e)
        {
            PopulateLabCombo();
            Populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ExamId.Text == "" || Diagnosis.Text == "" || Symptoms.Text == "" || Examination.Text == "" || LabNameCb.SelectedItem == null)
            {
                MessageBox.Show("No Empty Value Accepted");
            }
            else
            {

                try
                {
                    Con.Open();
                    string query = @"
                            INSERT INTO ExaminationTbl (ExamId, Diagnosis, Symptoms, Examination, LabName) 
                            VALUES (@ExamId, @Diagnosis, @Symptoms, @Examination, @LabName)";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Add parameters to ensure safe query execution
                        cmd.Parameters.AddWithValue("@ExamId", ExamId.Text);  // Convert to int if ExamId is an integer field
                        cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis.Text);
                        cmd.Parameters.AddWithValue("@Symptoms", Symptoms.Text);
                        cmd.Parameters.AddWithValue("@Examination", Examination.Text);
                        cmd.Parameters.AddWithValue("@LabName", LabNameCb.SelectedItem);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Examination record successfully added");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
                Populate(); // Assuming Populate() refreshes data display on form
                Clear();    // Assuming Clear() clears all form fields
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ExamId.Text == "" || Diagnosis.Text == "" || Symptoms.Text == "" || Examination.Text == "" || LabNameCb.SelectedItem == null)
            {
                MessageBox.Show("No Empty Value Accepted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = @"
                            UPDATE ExaminationTbl 
                            SET Diagnosis = @Diagnosis, 
                                Symptoms = @Symptoms, 
                                Examination = @Examination, 
                                LabName = @LabName 
                            WHERE ExamId = @ExamId";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Add parameters to ensure safe query execution
                        cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis.Text);
                        cmd.Parameters.AddWithValue("@Symptoms", Symptoms.Text);
                        cmd.Parameters.AddWithValue("@Examination", Examination.Text);
                        cmd.Parameters.AddWithValue("@LabName", LabNameCb.SelectedItem);
                        cmd.Parameters.AddWithValue("@ExamId", int.Parse(ExamId.Text)); // Convert to int if ExamId is an integer field

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Examination record successfully updated");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
                Populate(); // Assuming Populate() refreshes data display on form
                Clear();    // Assuming Clear() clears all form fields
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (ExamId.Text == "")
            {
                MessageBox.Show("Enter the Examination Id");
            }
            else
            {
                // Check if the logged-in user's role allows for deletion
                if (DoctorSession.Role != "Admin")
                {
                    MessageBox.Show("You are not authorized to delete diagnosis records.");
                }
                else
                {

                    try
                    {
                        Con.Open();
                        string query = "DELETE FROM ExaminationTbl WHERE ExamId = @ExamId";

                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@ExamId", ExamId.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Examination Successfully Deleted");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        if (Con.State == ConnectionState.Open)
                        {
                            Con.Close();
                        }
                    }
                    Populate(); // Refresh the data display
                    Clear();    // Clear any form fields
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExaminationGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ExamId.Text = ExaminationGV.SelectedRows[0].Cells[0].Value.ToString();
            Diagnosis.Text = ExaminationGV.SelectedRows[0].Cells[1].Value.ToString();
            Symptoms.Text = ExaminationGV.SelectedRows[0].Cells[2].Value.ToString();
            Examination.Text = ExaminationGV.SelectedRows[0].Cells[3].Value.ToString();
            LabNameCb.SelectedValue = ExaminationGV.SelectedRows[0].Cells[4].Value.ToString();

        }
    }
}
