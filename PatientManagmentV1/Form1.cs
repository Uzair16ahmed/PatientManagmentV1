using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace PatientManagmentV1
{
    public partial class Form1 : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\PatientManagementSystemV1.mdf;Integrated Security=True;Connect Timeout=30");

        public Form1()
        {
            InitializeComponent();
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
            if (UsernameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter a Username and Password");
            }
            else
            {
                {
                    Con.Open();
                    string query = "SELECT DocId, DocName, Role FROM DoctorTbl WHERE DocName = @DocName AND DocPass = @DocPass";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@DocName", UsernameTb.Text);
                        cmd.Parameters.AddWithValue("@DocPass", PassTb.Text);

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
                                MessageBox.Show("Wrong Username or Password");
                            }
                        }
                    }
                } // The connection is automatically closed here due to the 'using' block
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
