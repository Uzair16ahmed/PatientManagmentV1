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
            {
                MessageBox.Show("No Empty Value Accepted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO LabTbl (LabId, LabName) VALUES (@LabId, @LabName)";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@LabId", LabId.Text);  // Assuming LabId is a text that can be directly used, convert to integer if it's numeric
                        cmd.Parameters.AddWithValue("@LabName", LabName.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lab Successfully Added");
                            
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
                Populate();
                Clear();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LabId.Text == "" || LabName.Text == "")
            {
                MessageBox.Show("No Empty Value Accepted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE LabTbl SET LabName = @LabName WHERE LabId = @LabId";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@LabName", LabName.Text);
                        cmd.Parameters.AddWithValue("@LabId", LabId.Text);  // Assuming LabId is a string that can be directly used, convert to integer if it's numeric

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Lab Successfully Updated");
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
                Populate();
                Clear();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LabId.Text == "")
            {
                MessageBox.Show("Enter the Lab Id");
            }
            else
            {
                // Check if the logged-in user's role is "Admin"
                if (DoctorSession.Role != "Admin")
                {
                    MessageBox.Show("You are not authorized to delete lab records.");
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "DELETE FROM LabTbl WHERE LabId = @LabId";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        {
                            cmd.Parameters.AddWithValue("@LabId", LabId.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Lab Successfully Deleted");
                            
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

                    // Assuming Populate() is a method to refresh or update the data displayed
                    Populate();
                    Clear();
                }
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
