﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace PatientManagmentV1
{
    public partial class DoctorForm : Form
    {
        SqlConnection Con;

        public DoctorForm()
        {
            InitializeComponent();
            Con = DatabaseConnection.GetConnection();  // Initialize the connection
            DoctorGV.CellFormatting += DoctorGV_CellFormatting;


        }

        private void Clear()
        {
            DocId.Text = "";
            DocName.Text = "";
            RoleCb.Text = "Role";
            DocPass.Text = "";
        }

        void Populate()
        {
            Con.Open();
            string query = "select * from DoctorTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DoctorGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if the logged-in doctor is an Admin
            if (DoctorSession.Role != "Admin")
            {
                MessageBox.Show("You are not allowed to Update data.", "Un-Authorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (DocId.Text == "")
            {
                MessageBox.Show("Enter the Doctor ID", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (DocName.Text == "" || RoleCb.SelectedItem == null || DocPass.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE DoctorTbl SET DocName = @DocName, Role = @Role, DocPass = @DocPass WHERE DocId = @DocId";

                    SqlCommand cmd = new SqlCommand(query, Con);

                    {
                        cmd.Parameters.AddWithValue("@DocName", DocName.Text);
                        cmd.Parameters.AddWithValue("@Role", RoleCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DocPass", DocPass.Text);
                        cmd.Parameters.AddWithValue("@DocId", DocId.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Successfully Updated");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is always closed, even if an error occurs
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


        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" || RoleCb.SelectedIndex == -1 || DocPass.Text == "")
            {
                MessageBox.Show("No Empty Values Accepted", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Con.Open();
                    // Assuming DocId is an integer. Adjust the type if it is not.
                    string query = "INSERT INTO DoctorTbl (DocName, Role, DocPass) VALUES (@DocName, @Role, @DocPass)";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    {
                        // Use proper type conversions to ensure data integrity
                        //cmd.Parameters.AddWithValue("@DocId", DocId.Text); // Convert to integer if DocId is an integer column
                        cmd.Parameters.AddWithValue("@DocName", DocName.Text);
                        cmd.Parameters.AddWithValue("@Role", RoleCb.SelectedItem);
                        cmd.Parameters.AddWithValue("@DocPass", DocPass.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Successfully Added");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Ensuring the connection is closed even if an error occurs
                    if (Con.State == ConnectionState.Open)
                    {
                        Con.Close();
                    }
                }

                // Assuming Populate() is a method to update the UI with the latest data
                Populate();
                Clear();
            }
        }


        private void DoctorForm_Load(object sender, EventArgs e)
        {
            Populate();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "")
            {
                MessageBox.Show("Enter the Doctor Id", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Check if the logged-in doctor is an Admin
                if (DoctorSession.Role != "Admin")
                {
                    MessageBox.Show("You are not allowed to delete data.", "Un-Authorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    Con.Open();
                    // Use parameterized queries to prevent SQL Injection
                    string query = "DELETE FROM DoctorTbl WHERE DocId = @DocId";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    {
                        cmd.Parameters.AddWithValue("@DocId", DocId.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Doctor Successfully Deleted");

                    }
                    Con.Close();
                    Populate();
                    Clear();
                }
            }

        }

        private void DocName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DoctorGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocId.Text = DoctorGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DoctorGV.SelectedRows[0].Cells[1].Value.ToString();
            RoleCb.SelectedItem = DoctorGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DoctorGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DoctorGV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Assuming 'guna2DataGridView1' is your DataGridView and 'passwordColumn' is the name of the password column
            if (DoctorGV.Columns[e.ColumnIndex].Name == "DocPass" && e.Value != null)
            {
                // You can either mask the actual length of the password
                e.Value = new string('*', e.Value.ToString().Length);

                // Or use a fixed length, like 5 asterisks:
                // e.Value = "*****";

                e.FormattingApplied = true;  // Indicates that the formatting was handled
            }
        }
    }
}
