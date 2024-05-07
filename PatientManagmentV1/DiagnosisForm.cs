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
        readonly SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\PatientManagementSystemV1.mdf;Integrated Security=True;Connect Timeout=30");

        public class MedicineDetails
        {
            public string? Name { get; set; }
            public string? Dose { get; set; }
            public string? Route { get; set; }
            public string? Frequency { get; set; }
            public string? Days { get; set; }
            public string? Instruction { get; set; }
        }
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

        void PopulateExamCombo()
        {
            string sql = "select * from ExaminationTbl";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("ExamId", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                ExaminationCb.ValueMember = "ExamId";
                ExaminationCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
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
            ClearMedicineSelections();

            // Check if any row is selected in the DataGridView
            if (DiagnosisGV.SelectedRows.Count > 0)
            {
                string medicineNames = DiagnosisGV.SelectedRows[0].Cells[9].Value.ToString();
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
                    else
                    {
                        // For debugging: output to the debug window the medicine that wasn't found
                        System.Diagnostics.Debug.WriteLine("Medicine not found in ComboBox: " + trimmedMed);
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
            LabName.Text = "";
        }

        void FetchPatientName()
        {
            if (PatientIdCb.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid patient ID.");
                return;
            }

            try
            {
                Con.Open();
                string sql = "SELECT * FROM PatientTbl WHERE PatId = @PatId";
                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    // Safely add the patient ID as a parameter to avoid SQL injection
                    cmd.Parameters.AddWithValue("@PatId", PatientIdCb.SelectedValue.ToString());

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            DataRow dr = dt.Rows[0];  // Assuming you expect only one row since IDs should be unique
                            PatientTb.Text = dr["PatName"].ToString();
                            PatGender.Text = dr["PatGender"].ToString();
                            PatAge.Text = dr["PatAge"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No patient found with the specified ID.");
                            // Optionally clear any previous data displayed
                            PatientTb.Text = "";
                            PatGender.Text = "";
                            PatAge.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Connection will be closed by the using statement
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        void FetchExamination()
        {
            if (ExaminationCb.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid Examination ID.");
                return;
            }

            try
            {
                Con.Open();
                string sql = "SELECT * FROM ExaminationTbl WHERE ExamId = @ExamId";
                using (SqlCommand cmd = new SqlCommand(sql, Con))
                {
                    // Safely add the patient ID as a parameter to avoid SQL injection
                    cmd.Parameters.AddWithValue("@ExamId", ExaminationCb.SelectedValue.ToString());

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            DataRow dr = dt.Rows[0];  // Assuming you expect only one row since IDs should be unique
                            Symptoms.Text = dr["Symptoms"].ToString();
                            Diagnosis.Text = dr["Diagnosis"].ToString();
                            Assessment.Text = dr["Examination"].ToString();
                            LabName.Text = dr["LabName"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No patient found with the specified ID.");
                            // Optionally clear any previous data displayed
                            Symptoms.Text = "";
                            Diagnosis.Text = "";
                            Assessment.Text = "";
                            LabName.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Connection will be closed by the using statement
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
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

        private void DiagnosisForm_Load(object sender, EventArgs e)
        {
            PopulateCombo();
            PopulateExamCombo();
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
            ExaminationCb.SelectedValue = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            Symptoms.Text = DiagnosisGV.SelectedRows[0].Cells[6].Value.ToString();
            Diagnosis.Text = DiagnosisGV.SelectedRows[0].Cells[7].Value.ToString();
            Assessment.Text = DiagnosisGV.SelectedRows[0].Cells[8].Value.ToString();
            LabName.Text = DiagnosisGV.SelectedRows[0].Cells[11].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[6].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[7].Value.ToString();
            Examinationlbl.Text = DiagnosisGV.SelectedRows[0].Cells[8].Value.ToString();
            Medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> selectedMeds = GetSelectedMedicines();

            if (selectedMeds.Count == 0)
            {
                MessageBox.Show("Please select at least one medicine.");
                return;
            }

            string medNames = String.Join(", ", selectedMeds); // Combine all selected medicine names with a comma
            
            if (DiagId.Text == "" || medComboBox.Text == "" || Diagnosis.Text == "" || Symptoms.Text == "" || PatientTb.Text == "" || PatGender.Text == "" || Assessment.Text == "")
            {
                MessageBox.Show("No Empty Value Accepted");
            }
            else
            {
                try
                {
                    Con.Open();
                    // Fetch additional medicine data
                    List<string> medDetails = new List<string>();
                    foreach (var med in selectedMeds)
                    {
                        string medQuery = "SELECT Dose, Route, Frequency, Days, Instruction FROM MedicineTbl WHERE MedicineName = @MedName";
                        SqlCommand medCmd = new SqlCommand(medQuery, Con);
                        medCmd.Parameters.AddWithValue("@MedName", med);
                        SqlDataReader medReader = medCmd.ExecuteReader();
                        while (medReader.Read())
                        {
                            string details = $"{med} - Dose: {medReader["Dose"]}, Route: {medReader["Route"]}, Frequency: {medReader["Frequency"]}, Days: {medReader["Days"]}, Instruction: {medReader["Instruction"]}";
                            medDetails.Add(details);
                        }
                        medReader.Close();
                    }

                    string query = "INSERT INTO DiagnosisTbl (DiagId, PatId, PatName, PatGender, PatAge, ExamId, Symptoms, Diagnosis, Assessment, Medicines, MedDetails, LabName) VALUES (@DiagId, @PatId, @PatName, @PatGender, @PatAge, @ExamId, @Symptoms, @Diagnosis, @Assessment, @Medicines, @MedDetails, @LabName)";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Adding parameters to avoid SQL Injection
                    cmd.Parameters.AddWithValue("@DiagId", int.Parse(DiagId.Text));
                    cmd.Parameters.AddWithValue("@PatId", int.Parse(PatientIdCb.SelectedValue.ToString())); // Assuming PatientIdCb is a ComboBox
                    cmd.Parameters.AddWithValue("@PatName", PatientTb.Text);
                    cmd.Parameters.AddWithValue("@PatGender", PatGender.Text);
                    cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                    cmd.Parameters.AddWithValue("@ExamId", int.Parse(ExaminationCb.SelectedValue.ToString())); // Assuming ExaminationCb is a ComboBox
                    cmd.Parameters.AddWithValue("@Symptoms", Symptoms.Text);
                    cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis.Text);
                    cmd.Parameters.AddWithValue("@Assessment", Assessment.Text);
                    cmd.Parameters.AddWithValue("@Medicines", medNames);
                    cmd.Parameters.AddWithValue("@MedDetails", String.Join("; ", medDetails));
                    cmd.Parameters.AddWithValue("@LabName", LabName.Text);

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
            {
                MessageBox.Show("Enter the Diagnosis Id");
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
                        string query = "DELETE FROM DiagnosisTbl WHERE DiagId = @DiagId";

                        using (SqlCommand cmd = new SqlCommand(query, Con))
                        {
                            cmd.Parameters.AddWithValue("@DiagId", DiagId.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Diagnosis Successfully Deleted");
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
                    ClearMedicineSelections(); // Additional cleanup function
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> selectedMeds = GetSelectedMedicines();
            if (selectedMeds.Count == 0)
            {
                MessageBox.Show("Please select at least one medicine.");
                return;
            }

            string medNames = String.Join(", ", selectedMeds); // Combine all selected medicine names with a comma

            try
            {
                Con.Open();

                // Fetch additional medicine data
                List<string> medDetails = new List<string>();
                foreach (var med in selectedMeds)
                {
                    string medQuery = "SELECT Dose, Route, Frequency, Days, Instruction FROM MedicineTbl WHERE MedicineName = @MedName";
                    SqlCommand medCmd = new SqlCommand(medQuery, Con);
                    medCmd.Parameters.AddWithValue("@MedName", med);
                    SqlDataReader medReader = medCmd.ExecuteReader();
                    while (medReader.Read())
                    {
                        string details = $"{med} - Dose: {medReader["Dose"]}, Route: {medReader["Route"]}, Frequency: {medReader["Frequency"]}, Days: {medReader["Days"]}, Instruction: {medReader["Instruction"]}";
                        medDetails.Add(details);
                    }
                    medReader.Close();
                }

                // Update SQL query to include all necessary columns
                string query = "UPDATE DiagnosisTbl SET PatId = @PatId, PatName = @PatName, PatGender = @PatGender, PatAge = @PatAge, ExamId = @ExamId, Symptoms = @Symptoms, Diagnosis = @Diagnosis, Assessment = @Assessment, Medicines = @Medicines, MedDetails = @MedDetails, LabName = @LabName WHERE DiagId = @DiagId";
                SqlCommand cmd = new SqlCommand(query, Con);

                // Add parameters to SqlCommand object
                cmd.Parameters.AddWithValue("@DiagId", int.Parse(DiagId.Text));
                cmd.Parameters.AddWithValue("@PatId", int.Parse(PatientIdCb.SelectedValue.ToString()));
                cmd.Parameters.AddWithValue("@PatName", PatientTb.Text);
                cmd.Parameters.AddWithValue("@PatGender", PatGender.Text);
                cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                cmd.Parameters.AddWithValue("@ExamId", int.Parse(ExaminationCb.SelectedValue.ToString())); // Assuming ExaminationCb is a ComboBox
                cmd.Parameters.AddWithValue("@Symptoms", Symptoms.Text);
                cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis.Text);
                cmd.Parameters.AddWithValue("@Assessment", Assessment.Text);
                cmd.Parameters.AddWithValue("@Medicines", medNames);
                cmd.Parameters.AddWithValue("@MedDetails", String.Join("; ", medDetails));
                cmd.Parameters.AddWithValue("@LabName", LabName.Text);

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
                int creationDateColumnIndex = dataGridView.Columns["Date"].Index; // Ensure the column name matches your DataGridView setup
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

        private string FetchMedDetails(int diagId)
        {
                string medDetails = "";
                string query = "SELECT MedDetails FROM DiagnosisTbl WHERE DiagId = @DiagId";
                Con.Open();
                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("@DiagId", diagId);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        medDetails = reader["MedDetails"].ToString();
                    }
                    reader.Close();
                Con.Close();
                }
            return medDetails;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            List<string> selectedMeds = GetSelectedMedicines();
            string medNames = String.Join(", ", selectedMeds);

            string medDetails = FetchMedDetails(int.Parse(DiagId.Text));
            string[] medArray = medDetails.Split(';');

            string formattedDate = GetFormattedCreationDate(DiagnosisGV);

            //e.Graphics.DrawString(label4.Text + "\n\n\n\n\n\n\n\n\n\n", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics?.DrawString("Patient Report", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(280));

            Graphics graphic = e.Graphics;
            Font font = new("Courier New", 12);  // Choose appropriate font
            float fontHeight = font.GetHeight();
            Font headerFont = new("Arial", 16, FontStyle.Bold);
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

            graphic.DrawString($"Patient Id: {PatientIdCb.SelectedValue?.ToString()}", font, new SolidBrush(Color.Black), startX, startY + offset);
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
            graphic.DrawString("Diagnosis", headerFont, Brushes.Black, startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            graphic.DrawString($"Doctor Diagnosis: {Diagnosis.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Patient Symptons: {Symptoms.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5;
            graphic.DrawString($"Doctor Examination: {Assessment.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);

            // Increment the offset for a new section
            offset = offset + (int)fontHeight + 30;
            graphic.DrawString("Medications", headerFont, Brushes.Black, startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            foreach (string med in medArray)
            {
                string[] parts = med.Trim().Split('-');
                string medicineName = parts[0].Trim();
                string[] details = parts[1].Trim().Split(',');

                graphic.DrawString($"Medicine: {medicineName}", font, new SolidBrush(Color.Black), startX, startY + offset);
                offset += (int)fontHeight + 5;

                foreach (string detail in details)
                {
                    graphic.DrawString(detail.Trim(), font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset += (int)fontHeight + 5;
                }
            }
   

            // Increment the offset for a new section
            offset = offset + (int)fontHeight + 30;
            graphic.DrawString("Lab Recommended", headerFont, Brushes.Black, startX, startY + offset);
            offset = offset + (int)fontHeight + 20;

            // Continuing Lab results
            graphic.DrawString($"Lab Name: {LabName.Text}", font, new SolidBrush(Color.Black), startX, startY + offset);
            //offset = offset + (int)fontHeight + 5;
            //graphic.DrawString("Hemoglobin: 13.8 g/dL", font, new SolidBrush(Color.Black), startX, startY + offset);

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

        private void ExaminationCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FetchExamination();
        }
    }
}
