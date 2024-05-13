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
            DoseCb.Text = "Dose";
            RouteCb.Text = "Route";
            FrequencyCb.Text = "Frequency";
            DaysCb.Text = "Days";
            InstructionCb.Text = "Instruction";
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
            if (MedId.Text == "" || MedicineName.Text == "" ||
                DoseCb.SelectedItem == null || RouteCb.SelectedItem == null ||
                FrequencyCb.SelectedItem == null || DaysCb.SelectedItem == null ||
                InstructionCb.SelectedItem == null)
            {
                MessageBox.Show("No Empty Values Accepted", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                try
                {
                    Con.Open();
                    string query = @"
                        INSERT INTO MedicineTbl 
                        (MedId, MedicineName, Dose, Route, Frequency, Days, Instruction) 
                        VALUES 
                        (@MedId, @MedicineName, @Dose, @Route, @Frequency, @Days, @Instruction)";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Adding parameters to prevent SQL Injection
                        cmd.Parameters.AddWithValue("@MedId", MedId.Text);  // Convert to integer if MedId is a numeric field
                        cmd.Parameters.AddWithValue("@MedicineName", MedicineName.Text);
                        cmd.Parameters.AddWithValue("@Dose", DoseCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Route", RouteCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Frequency", FrequencyCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Days", DaysCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Instruction", InstructionCb.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicine Successfully Added");
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
            if (MedId.Text == "" || MedicineName.Text == "" ||
                DoseCb.SelectedItem == null || RouteCb.SelectedItem == null ||
                FrequencyCb.SelectedItem == null || DaysCb.SelectedItem == null ||
                InstructionCb.SelectedItem == null)
            {
                MessageBox.Show("No Empty Values Accepted", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                try
                {
                    Con.Open();
                    string query = @"
                        UPDATE MedicineTbl 
                        SET 
                            MedicineName = @MedicineName, 
                            Dose = @Dose, 
                            Route = @Route, 
                            Frequency = @Frequency, 
                            Days = @Days, 
                            Instruction = @Instruction 
                        WHERE MedId = @MedId";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        // Add parameters to ensure safe query execution
                        cmd.Parameters.AddWithValue("@MedicineName", MedicineName.Text);
                        cmd.Parameters.AddWithValue("@MedId", MedId.Text); // Assuming MedId is a string, convert to int if necessary
                        cmd.Parameters.AddWithValue("@Dose", DoseCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Route", RouteCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Frequency", FrequencyCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Days", DaysCb.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Instruction", InstructionCb.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Medicine Successfully Updated");
                        
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
                Populate(); // Refresh data display
                Clear();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MedId.Text == "")
            {
                MessageBox.Show("Enter the Medicine Id", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Check if the logged-in user's role is "Admin"
                if (DoctorSession.Role != "Admin")
                {
                    MessageBox.Show("You are not authorized to delete medicines.", "Un-Authorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    
                    try
                    {
                        Con.Open();
                        string query = "DELETE FROM MedicineTbl WHERE MedId = @MedId";

                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@MedId", MedId.Text);  // Convert to integer if MedId is numeric

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Medicine Successfully Deleted");
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

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void MedicineGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MedId.Text = MedicineGV.SelectedRows[0].Cells[0].Value.ToString();
            MedicineName.Text = MedicineGV.SelectedRows[0].Cells[1].Value.ToString();
            DoseCb.Text = MedicineGV.SelectedRows[0].Cells[2].Value.ToString();
            RouteCb.Text = MedicineGV.SelectedRows[0].Cells[3].Value.ToString();
            FrequencyCb.Text = MedicineGV.SelectedRows[0].Cells[4].Value.ToString();
            DaysCb.Text = MedicineGV.SelectedRows[0].Cells[5].Value.ToString();
            InstructionCb.Text = MedicineGV.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
