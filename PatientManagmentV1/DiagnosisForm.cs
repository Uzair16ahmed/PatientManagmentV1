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

        private void PopulateMedicines()
        {
            string query = "SELECT MedicineName FROM MedicineTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Assuming medComboBox is your multi-select combobox or CheckedListBox
            medComboBox.Items.Clear();
            while (reader.Read())
            {
                medComboBox.Items.Add(reader["MedicineName"].ToString());
            }
            reader.Close();
            Con.Close();
        }

        private List<string> GetSelectedMedicines()
        {
            List<string> selectedMeds = new List<string>();
            foreach (object itemChecked in medComboBox.CheckedItems)
            {
                selectedMeds.Add(itemChecked.ToString());
            }
            return selectedMeds;
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
        private void ClearMedicineSelections()
        {
            for (int i = 0; i < medComboBox.Items.Count; i++)
            {
                medComboBox.SetItemChecked(i, false);
            }
        }

        private void PreselectMedicinesInList()
        {
            // Clear any existing selections first
            for (int i = 0; i < medComboBox.Items.Count; i++)
            {
                medComboBox.SetItemChecked(i, false);
            }

            // Check if any row is selected in the DataGridView
            if (DiagnosisGV.SelectedRows.Count > 0)
            {
                string medicineNames = DiagnosisGV.SelectedRows[0].Cells[8].Value.ToString();
                string[] medicines = medicineNames.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                // Trim spaces and preselect the matching items in the CheckedListBox
                foreach (string med in medicines)
                {
                    string trimmedMed = med.Trim();
                    int index = medComboBox.Items.IndexOf(trimmedMed);
                    if (index != -1)
                    {
                        medComboBox.SetItemChecked(index, true);
                    }
                }
            }
        }

        void Clear()
        {
            DiagId.Text = "";
            PatientTb.Text = "";
            PatGender.Text = "";
            PatAge.Text = "";
            Symptoms.Text = "";
            Diagnosis.Text = "";
            Assessment.Text = "";
            MedDose.Text = "";
            MedIntake.Text = "";
            MedSchedule.Text = "";
        }

        string patientName;
        string patientGender;
        string patientAge;
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
                patientGender = dr["PatGender"].ToString();
                patientAge = dr["PatAge"].ToString();
                PatientTb.Text = patientName;
                PatGender.Text = patientGender;
                PatAge.Text = patientAge;
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
            PopulateLabCombo();
            PopulateMedicines();
            Populate();
            label9.Text = DateTime.Now.ToString();
            //Visible();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PreselectMedicinesInList();
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            PatGender.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Symptoms.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            Diagnosis.Text = DiagnosisGV.SelectedRows[0].Cells[6].Value.ToString();
            Assessment.Text = DiagnosisGV.SelectedRows[0].Cells[7].Value.ToString();
            MedDose.Text = DiagnosisGV.SelectedRows[0].Cells[9].Value.ToString();
            MedIntake.Text = DiagnosisGV.SelectedRows[0].Cells[10].Value.ToString();
            MedSchedule.Text = DiagnosisGV.SelectedRows[0].Cells[11].Value.ToString();
            LabNameCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[12].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> selectedMeds = GetSelectedMedicines();
            string medNames = String.Join(", ", selectedMeds); // Combine all selected medicine names with a comma

            if (DiagId.Text == "" || medComboBox.Text == "" || Diagnosis.Text == "" || Symptoms.Text == "" || PatientTb.Text == "" || PatGender.Text == "" || Assessment.Text == "" || MedDose.Text == "" || MedIntake.Text == "" || MedSchedule.Text == "")
            {
                MessageBox.Show("No Empty Value Accepted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO DiagnosisTbl (DiagId, PatId, PatName, PatGender, PatAge, Symptoms, Diagnosis, Assessment, Medicines, MedDose, MedIntake, MedSchedule, LabName) VALUES (@DiagId, @PatId, @PatName, @PatGender,@PatAge, @Symptoms, @Diagnosis, @Assessment, @Medicines, @MedDose, @MedIntake, @MedSchedule, @LabName)";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Adding parameters to avoid SQL Injection
                    cmd.Parameters.AddWithValue("@DiagId", int.Parse(DiagId.Text));
                    cmd.Parameters.AddWithValue("@PatId", int.Parse(PatientIdCb.SelectedValue.ToString())); // Assuming PatientIdCb is a ComboBox
                    cmd.Parameters.AddWithValue("@PatName", PatientTb.Text);
                    cmd.Parameters.AddWithValue("@PatGender", PatGender.Text);
                    cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", Symptoms.Text);
                    cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis.Text);
                    cmd.Parameters.AddWithValue("@Assessment", Assessment.Text);
                    cmd.Parameters.AddWithValue("@Medicines", medNames);
                    cmd.Parameters.AddWithValue("@MedDose", MedDose.Text);
                    cmd.Parameters.AddWithValue("@MedIntake", MedIntake.Text);
                    cmd.Parameters.AddWithValue("@MedSchedule", MedSchedule.Text);
                    cmd.Parameters.AddWithValue("@LabName", LabNameCb.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Diagnosis Successfully Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while inserting data: " + ex.Message);
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
                ClearMedicineSelections();
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
                Clear();
                ClearMedicineSelections();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> selectedMeds = GetSelectedMedicines();
            string medNames = String.Join(", ", selectedMeds);

            try
            {
                Con.Open();
                // Update SQL query to include all necessary columns
                string query = "UPDATE DiagnosisTbl SET PatId = @PatId, PatName = @PatName, PatGender = @PatGender, PatAge = @PatAge, Symptoms = @Symptoms, Diagnosis = @Diagnosis, Assessment = @Assessment, Medicines = @Medicines, MedDose = @MedDose, MedIntake = @MedIntake, MedSchedule = @MedSchedule, LabName = @LabName WHERE DiagId = @DiagId";
                SqlCommand cmd = new SqlCommand(query, Con);

                // Add parameters to SqlCommand object
                cmd.Parameters.AddWithValue("@DiagId", int.Parse(DiagId.Text));
                cmd.Parameters.AddWithValue("@PatId", int.Parse(PatientIdCb.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@PatName", PatientTb.Text);
                cmd.Parameters.AddWithValue("@PatGender", PatGender.Text);
                cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                cmd.Parameters.AddWithValue("@Symptoms", Symptoms.Text);
                cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis.Text);
                cmd.Parameters.AddWithValue("@Assessment", Assessment.Text);
                cmd.Parameters.AddWithValue("@Medicines", medNames);
                cmd.Parameters.AddWithValue("@MedDose", MedDose.Text);
                cmd.Parameters.AddWithValue("@MedIntake", MedIntake.Text);
                cmd.Parameters.AddWithValue("@MedSchedule", MedSchedule.Text);
                cmd.Parameters.AddWithValue("@LabName", LabNameCb.SelectedValue.ToString());

                // Execute the command
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Successfully Updated");
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
            ClearMedicineSelections();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchPatientName();
        }

        private string GetFormattedCreationDate(DataGridView dataGridView)
        {
            // Check if there is a selected row
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected!");
                return string.Empty; // Or handle differently depending on your needs
            }

            // Attempt to retrieve and format the CreationDate
            try
            {
                int creationDateColumnIndex = dataGridView.Columns["CreationDate"].Index; // Ensure the column name matches your DataGridView setup
                var selectedRow = dataGridView.SelectedRows[0];
                DateTime creationDate = Convert.ToDateTime(selectedRow.Cells[creationDateColumnIndex].Value);
                string formattedDate = creationDate.ToString("dd MMM yyyy HH:mm:ss"); // Format can be adjusted as needed
                return formattedDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving date: " + ex.Message);
                return string.Empty; // Or rethrow the exception to handle it higher up in the call stack
            }
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<string> selectedMeds = GetSelectedMedicines();
            string medNames = String.Join(", ", selectedMeds);

            string formattedDate = GetFormattedCreationDate(DiagnosisGV);

            //e.Graphics.DrawString(label4.Text + "\n\n\n\n\n\n\n\n\n\n", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Patient Report", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(280));

            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);  // Choose appropriate font
            float fontHeight = font.GetHeight();
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            int startX = 40;
            int startY = 40;
            int offset = 40;

            // Draw headers
            graphic.DrawString("Doctor Information", headerFont, Brushes.Black, startX, startY + 20);
            offset = offset + (int)fontHeight + 5;  // Adjust space between lines

            graphic.DrawString("Name: Doctor Zubair", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Specialization: Specialist", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString("Information: info", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + (int)fontHeight + 30;  // Increase offset for new section
            graphic.DrawString("Patient Information", headerFont, Brushes.Black, startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            graphic.DrawString($"Patient Id: {PatientIdCb.SelectedValue.ToString()}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Name: {PatientTb.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Age: {PatAge.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Gender: {PatGender.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;

            // Check if we actually got a date
            if (!string.IsNullOrEmpty(formattedDate))
            {
                graphic.DrawString($"Diagnosis Date-time: {formattedDate}", font, new SolidBrush(Color.Black), startX, startY + offset);
            }
            else
            {
                graphic.DrawString("No valid date available.", font, new SolidBrush(Color.Black), startX, startY + offset);
            }
            // Increment the offset for a new section
            offset = offset + (int)fontHeight + 30;
            graphic.DrawString("Lab Recommended", headerFont, Brushes.Black, startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            // Continuing Lab results
            graphic.DrawString($"Lab Name: {LabNameCb.SelectedValue.ToString()}", font, new SolidBrush(Color.Black), startX, startY + offset);
            //offset = offset + (int)fontHeight + 5;
            //graphic.DrawString("Hemoglobin: 13.8 g/dL", font, new SolidBrush(Color.Black), startX, startY + offset);

            // Increment the offset for a new section
            offset = offset + (int)fontHeight + 30;
            graphic.DrawString("Medications", headerFont, Brushes.Black, startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            // Example Medication Prescriptions
            graphic.DrawString($"Medicine: {medNames}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Dose: {MedDose.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Intake: {MedIntake.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Schedule: {MedSchedule.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);

            // Increment the offset for a new section
            offset = offset + (int)fontHeight + 30;
            graphic.DrawString("Diagnosis", headerFont, Brushes.Black, startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            graphic.DrawString($"Patient Symptons: {Symptoms.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Doctor Diagnosis: {Diagnosis.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Doctor Assessment: {Assessment.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);

            // Check to see if another PrintPage event should be raised
            e.HasMorePages = false;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
