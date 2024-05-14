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
        SqlConnection Con;

        public PatientForm()
        {
            InitializeComponent();
            Con = DatabaseConnection.GetConnection();  // Initialize the connection

        }

        private void Clear()
        {
            PatId.Text = "";
            PatName.Text = "";
            PatAddress.Text = "";
            PatPhone.Text = "";
            PatAge.Text = "";
            PatGender.Text = "Gender";
            PatBlood.Text = "BloodGroup";
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
            if (PatId.Text == "" || PatName.Text == "" || PatAddress.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || PatGender.SelectedItem == null || PatBlood.SelectedItem == null || PatDisease.Text == "")
            {
                MessageBox.Show("No Empty Values Accepted", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = @"
                    INSERT INTO PatientTbl (PatId, PatName, PatAddress, PatPhone, PatAge, PatGender, PatBlood, PatDisease) 
                    VALUES (@PatId, @PatName, @PatAddress, @PatPhone, @PatAge, @PatGender, @PatBlood, @PatDisease)";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Add parameters to ensure safe query execution
                        cmd.Parameters.AddWithValue("@PatId", PatId.Text);
                        cmd.Parameters.AddWithValue("@PatName", PatName.Text);
                        cmd.Parameters.AddWithValue("@PatAddress", PatAddress.Text);
                        cmd.Parameters.AddWithValue("@PatPhone", PatPhone.Text);
                        cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                        cmd.Parameters.AddWithValue("@PatGender", PatGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PatBlood", PatBlood.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PatDisease", PatDisease.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient Successfully Added");
                         
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if(Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
                Populate(); // Refresh the data display
                Clear();    // Clear any form fields

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "" || PatName.Text == "" || PatAddress.Text == "" || PatPhone.Text == "" ||
                PatAge.Text == "" || PatGender.SelectedItem == null || PatBlood.SelectedItem == null || PatDisease.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                try
                {
                    Con.Open();
                    string query = @"
                    UPDATE PatientTbl 
                    SET PatName = @PatName, 
                        PatAddress = @PatAddress, 
                        PatPhone = @PatPhone, 
                        PatAge = @PatAge, 
                        PatGender = @PatGender, 
                        PatBlood = @PatBlood, 
                        PatDisease = @PatDisease 
                    WHERE PatId = @PatId";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@PatName", PatName.Text);
                        cmd.Parameters.AddWithValue("@PatAddress", PatAddress.Text);
                        cmd.Parameters.AddWithValue("@PatPhone", PatPhone.Text);
                        cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                        cmd.Parameters.AddWithValue("@PatGender", PatGender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PatBlood", PatBlood.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@PatDisease", PatDisease.Text);
                        cmd.Parameters.AddWithValue("@PatId", PatId.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient Successfully Updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    if(Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }
                Populate(); // Refresh the data display
                Clear();    // Clear any form fields
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
            {
                MessageBox.Show("Enter the Patient Id", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Check if the logged-in user's role is "Admin"
                if (DoctorSession.Role != "Admin")
                {
                    MessageBox.Show("You are not authorized to delete patient records.", "Un-Authorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "DELETE FROM PatientTbl WHERE PatId = @PatId";

                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@PatId", PatId.Text);  // Ensure that PatId is properly typed to match your database schema

                            int result = cmd.ExecuteNonQuery();
                            MessageBox.Show("Patient Successfully Deleted");
                         
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        if(Con.State == ConnectionState.Open)
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
