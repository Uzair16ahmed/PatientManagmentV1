using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace PatientManagmentV1
{
    public partial class Form1 : Form
    {
        SqlConnection Con;

        public Form1()
        {
            InitializeComponent();
            Con = DatabaseConnection.GetConnection();  // Initialize the connection

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            UsernameTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (UsernameTb.Text == "" || PassTb.Text == "")
            //{
            //    MessageBox.Show("Enter a Username and Password");
            //}
            //else
            //{
            //    Con.Open();
            //    string query = "select Count(*) from DoctorTbl where DocName='" + UsernameTb.Text + "' and DocPass='" + PassTb.Text + "'";
            //    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            //    if (dt.Rows[0][0].ToString() == "1")
            //    {
            //        Home H = new Home();
            //        H.Show();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Wrong Username or Password");
            //    }
            //    Con.Close();
            //    /*  */
            //}
            // Check for empty username or password fields
            if (string.IsNullOrWhiteSpace(UsernameTb.Text) || string.IsNullOrWhiteSpace(PassTb.Text))
            {
                MessageBox.Show("Please enter a username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Con.Open();
                string query = "SELECT DocId, DocName, Role FROM DoctorTbl WHERE DocName = @DocName AND DocPass = @DocPass COLLATE SQL_Latin1_General_CP1_CS_AS";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    // Use parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@DocName", UsernameTb.Text.Trim());
                    cmd.Parameters.AddWithValue("@DocPass", PassTb.Text); // Consider using hashed passwords in the future

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // If any row is returned
                        {
                            // Assuming you have the DoctorSession static class as discussed previously
                            DoctorSession.DoctorId = reader.GetInt32(0); // Adjust the column index based on your query
                            DoctorSession.DoctorName = reader.GetString(1);
                            DoctorSession.Role = reader.GetString(2);

                            Home H = new Home();
                            H.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Username or Password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while attempting to log in: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
