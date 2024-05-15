using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        SqlConnection Con;

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
            Con = DatabaseConnection.GetConnection();  // Initialize the connection

        }

        //void PopulateCombo()
        //{
        //    string sql = "select * from PatientTbl";
        //    SqlCommand cmd = new SqlCommand(sql, Con);
        //    SqlDataReader rdr;
        //    try
        //    {
        //        Con.Open();
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("PatId", typeof(int));
        //        rdr = cmd.ExecuteReader();
        //        dt.Load(rdr);
        //        PatientIdCb.ValueMember = "PatId";
        //        PatientIdCb.DataSource = dt;
        //        Con.Close();
        //    }
        //    catch
        //    {

        //    }
        //}

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

        private Guna.UI2.WinForms.Guna2DataGridView GetDiagnosisGV()
        {
            return DiagnosisGV;
        }

        private void PreselectMedicinesInList(Guna.UI2.WinForms.Guna2DataGridView diagnosisGV)
        {
            // Clear any existing selections first
            ClearMedicineSelections();

            // Check if any row is selected in the DataGridView
            if (DiagnosisGV.SelectedRows.Count > 0)
            {
                string medicineNames = diagnosisGV.SelectedRows[0].Cells[9].Value.ToString();
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
            PatId.Text = "";
            ExaminationCb.Text = "";
            PatientTb.Text = "";
            PatGender.Text = "Gender";
            PatAge.Text = "";
            Symptoms.Text = "";
            Diagnosis.Text = "";
            Assessment.Text = "";
            LabName.Text = "";
        }

        //void FetchPatientName()
        //{
        //    if (PatientIdCb.SelectedValue == null)
        //    {
        //        MessageBox.Show("Please select a valid patient ID.");
        //        return;
        //    }

        //    try
        //    {
        //        Con.Open();
        //        string sql = "SELECT * FROM PatientTbl WHERE PatId = @PatId";
        //        using (SqlCommand cmd = new SqlCommand(sql, Con))
        //        {
        //            // Safely add the patient ID as a parameter to avoid SQL injection
        //            cmd.Parameters.AddWithValue("@PatId", PatientIdCb.SelectedValue.ToString());

        //            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
        //            {
        //                DataTable dt = new DataTable();
        //                da.Fill(dt);

        //                if (dt.Rows.Count > 0)
        //                {
        //                    DataRow dr = dt.Rows[0];  // Assuming you expect only one row since IDs should be unique
        //                    PatientTb.Text = dr["PatName"].ToString();
        //                    PatGender.Text = dr["PatGender"].ToString();
        //                    PatAge.Text = dr["PatAge"].ToString();
        //                }
        //                else
        //                {
        //                    MessageBox.Show("No patient found with the specified ID.");
        //                    // Optionally clear any previous data displayed
        //                    PatientTb.Text = "";
        //                    PatGender.Text = "";
        //                    PatAge.Text = "";
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message);
        //    }
        //    finally
        //    {
        //        // Connection will be closed by the using statement
        //        if (Con.State == ConnectionState.Open)
        //        {
        //            Con.Close();
        //        }
        //    }
        //}

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
            //PopulateCombo();
            PopulateExamCombo();
            PopulateMedicines();
            Populate();
            label9.Text = DateTime.Now.ToString();
            //Visible();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PreselectMedicinesInList(GetDiagnosisGV());
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatId.Text = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            PatGender.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            ExaminationCb.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
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

            if (medComboBox.Text == "" || Diagnosis.Text == "" || Symptoms.Text == "" || PatId.Text == "" || PatientTb.Text == "" || PatGender.Text == "" || PatAge.Text == "" || Assessment.Text == "")
            {
                MessageBox.Show("No Empty Values Accepted", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Please fill in all required fields before generating the report.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

                    string query = "INSERT INTO DiagnosisTbl (PatId, PatName, PatGender, PatAge, ExamId, Symptoms, Diagnosis, Assessment, Medicines, MedDetails, LabName) VALUES (@PatId, @PatName, @PatGender, @PatAge, @ExamId, @Symptoms, @Diagnosis, @Assessment, @Medicines, @MedDetails, @LabName)";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Adding parameters to avoid SQL Injection
                    //cmd.Parameters.AddWithValue("@DiagId", int.Parse(DiagId.Text));
                    cmd.Parameters.AddWithValue("@PatId", int.Parse(PatId.Text)); // Assuming PatientIdCb is a ComboBox
                    cmd.Parameters.AddWithValue("@PatName", PatientTb.Text);
                    cmd.Parameters.AddWithValue("@PatGender", PatGender.SelectedItem);
                    cmd.Parameters.AddWithValue("@PatAge", PatAge.Text);
                    cmd.Parameters.AddWithValue("@ExamId", ExaminationCb.SelectedValue); // Assuming ExaminationCb is a ComboBox
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
                //MessageBox.Show("Enter the Diagnosis Id");
                MessageBox.Show("Enter the Diagnosis Id", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                // Check if the logged-in user's role allows for deletion
                if (DoctorSession.Role != "Admin")
                {
                    //MessageBox.Show("You are not authorized to delete diagnosis records.");
                    MessageBox.Show("You are not authorized to delete diagnosis records.", "Un-Authorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

            if (DiagId.Text == "" || medComboBox.Text == "" || Diagnosis.Text == "" || Symptoms.Text == "" || PatId.Text == "" || PatientTb.Text == "" || PatGender.Text == "" || PatAge.Text == "" || Assessment.Text == "")
            {
                MessageBox.Show("No Empty Values Accepted", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("Please fill in all required fields before generating the report.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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

                    // Update SQL query to include all necessary columns
                    string query = "UPDATE DiagnosisTbl SET PatId = @PatId, PatName = @PatName, PatGender = @PatGender, PatAge = @PatAge, ExamId = @ExamId, Symptoms = @Symptoms, Diagnosis = @Diagnosis, Assessment = @Assessment, Medicines = @Medicines, MedDetails = @MedDetails, LabName = @LabName WHERE DiagId = @DiagId";
                    SqlCommand cmd = new SqlCommand(query, Con);

                    // Add parameters to SqlCommand object
                    cmd.Parameters.AddWithValue("@DiagId", int.Parse(DiagId.Text));
                    cmd.Parameters.AddWithValue("@PatId", int.Parse(PatId.Text));
                    cmd.Parameters.AddWithValue("@PatName", PatientTb.Text);
                    cmd.Parameters.AddWithValue("@PatGender", PatGender.SelectedItem); ;
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
        }

        //private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    FetchPatientName();
        //}

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

            if (string.IsNullOrWhiteSpace(medNames) || string.IsNullOrWhiteSpace(PatId.Text) ||
               string.IsNullOrWhiteSpace(PatientTb.Text) || string.IsNullOrWhiteSpace(PatAge.Text) ||
               string.IsNullOrWhiteSpace(PatGender.Text) || string.IsNullOrWhiteSpace(Diagnosis.Text))
            {
                MessageBox.Show("Please fill in all required fields before generating the report.", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;  // This will stop the printing process
                return;
            }

            string medDetails = FetchMedDetails(int.Parse(DiagId.Text));
            string[] medArray = medDetails.Split(';');

            string formattedDate = GetFormattedCreationDate(DiagnosisGV);

            string logoPath = "C:\\Users\\USER\\source\\repos\\PatientManagmentV1\\PatientManagmentV1\\Logo.jpg"; // Update this to your actual logo path
            Image logo = Image.FromFile(logoPath);

            // Determine the logo position and size
            int logoX = 650; // X-coordinate for the logo
            int logoY = 20; // Y-coordinate for the logo
            int logoDiameter = 140;

            Graphics graphic = e.Graphics;
            Font font = new("Courier New", 12);  // Choose appropriate font
            Font fontbold = new("Courier New", 12, FontStyle.Bold);  // Choose appropriate font
            float fontHeight = font.GetHeight();
            Font headerFont = new("Arial", 18, FontStyle.Bold);
            int startX = 20;
            int startY = 90;
            int offset = 80;


            // Draw the logo in a circular shape
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(logoX, logoY, logoDiameter, logoDiameter);
            Region region = new Region(path);
            graphic.SetClip(region, System.Drawing.Drawing2D.CombineMode.Replace);
            graphic.DrawImage(logo, new Rectangle(logoX, logoY, logoDiameter, logoDiameter));
            graphic.ResetClip(); // Reset the clipping region

            // Adjust offset to account for the logo space
            offset = logoY + 80;

            graphic.DrawString("Clinic Name", headerFont, Brushes.Black, new Point(350, offset));
            offset += (int)fontHeight;

            // Draw the Doctor Information box
            int doctorBoxWidth = 460;
            int doctorBoxHeight = (int)(fontHeight * 4) + 13; // Adjust the height based on the content
            int doctorBoxStartX = startX;
            int doctorBoxStartY = 50;

            // Draw the rectangle
            //graphic.FillRectangle(Brushes.Gray, doctorBoxStartX, doctorBoxStartY, doctorBoxWidth, 25);
            //graphic.DrawRectangle(Pens.Black, new Rectangle(doctorBoxStartX, doctorBoxStartY, doctorBoxWidth, doctorBoxHeight));

            // Draw the Doctor Information title inside the box

            // Adjust offset for the content inside the box
            int contentOffsetY = doctorBoxStartY + 10;

            graphic.DrawString("Dr. ZUBAIR AHMED", headerFont, Brushes.Black, doctorBoxStartX + 10, contentOffsetY);
            contentOffsetY += (int)fontHeight + 8;

            graphic.DrawString("MBBS , FCPS", fontbold, Brushes.Black, doctorBoxStartX + 10, contentOffsetY);
            contentOffsetY += (int)fontHeight + 5;

            graphic.DrawString("consultant General", fontbold, Brushes.Black, doctorBoxStartX + 10, contentOffsetY);
            contentOffsetY += (int)fontHeight + 5;

            graphic.DrawString("Laproscopic surgeon", fontbold, Brushes.Black, doctorBoxStartX + 10, contentOffsetY);
            // Update the offset after the doctor information box
            offset = doctorBoxStartY - 10;  //offset = offset + (int)fontHeight + 5;
            //graphic.DrawString("Information: info", font, new SolidBrush(Color.Black), startX, startY + offset);

            offset += (int)fontHeight + 70;

            // Draw the Patient Information box
            int patientBoxWidth = 815;
            int patientBoxHeight = (int)(fontHeight * 5) + 50; // Adjust the height based on the content
            int patientBoxStartX = startX;
            int patientBoxStartY = startY + offset;

            // Draw the rectangle
            graphic.FillRectangle(Brushes.Gray, patientBoxStartX, patientBoxStartY, patientBoxWidth, 28);
            graphic.DrawRectangle(Pens.Black, new Rectangle(patientBoxStartX, patientBoxStartY, patientBoxWidth, patientBoxHeight));

            // Draw the Patient Information title inside the box
            graphic.DrawString("Patient Information", headerFont, Brushes.White, new PointF(patientBoxStartX + 5, patientBoxStartY + 2));

            // Adjust offset for the content inside the box
            contentOffsetY = patientBoxStartY + 30;

            graphic.DrawString("Patient Id:", fontbold, Brushes.Black, patientBoxStartX + 10, contentOffsetY);
            graphic.DrawString($"{PatId.Text}", font, Brushes.Black, patientBoxStartX + 125, contentOffsetY);
            contentOffsetY += (int)fontHeight + 5;

            graphic.DrawString("Name:", fontbold, Brushes.Black, patientBoxStartX + 10, contentOffsetY);
            graphic.DrawString($"{PatientTb.Text}", font, Brushes.Black, patientBoxStartX + 70, contentOffsetY);
            contentOffsetY += (int)fontHeight + 5;

            graphic.DrawString("Age:", fontbold, Brushes.Black, patientBoxStartX + 10, contentOffsetY);
            graphic.DrawString($"{PatAge.Text}", font, Brushes.Black, patientBoxStartX + 60, contentOffsetY);
            contentOffsetY += (int)fontHeight + 5;

            graphic.DrawString("Gender:", fontbold, Brushes.Black, patientBoxStartX + 10, contentOffsetY);
            graphic.DrawString($"{PatGender.Text}", font, Brushes.Black, patientBoxStartX + 85, contentOffsetY);
            contentOffsetY += (int)fontHeight + 5;

            // Check if we actually got a date
            if (!string.IsNullOrEmpty(formattedDate))
            {
                graphic.DrawString("Diagnosis Date-time:", fontbold, Brushes.Black, patientBoxStartX + 10, contentOffsetY);
                graphic.DrawString($"{formattedDate}", font, Brushes.Black, patientBoxStartX + 220, contentOffsetY);
            }
            else
            {
                graphic.DrawString("No valid date available.", font, Brushes.Black, patientBoxStartX + 10, contentOffsetY);
            }
            // Update the offset after the patient information box
            offset = patientBoxStartY + 65;

            int diagnosisBoxWidth = 815;
            int diagnosisBoxHeight = (int)(fontHeight * 4) + 24; // Adjust the height based on the content
            int diagBoxStartX = startX;
            int diagBoxStartY = startY + offset;

            // Draw the rectangle
            graphic.FillRectangle(Brushes.Gray, diagBoxStartX, diagBoxStartY, diagnosisBoxWidth, 28);
            graphic.DrawRectangle(Pens.Black, new Rectangle(diagBoxStartX, diagBoxStartY, diagnosisBoxWidth, diagnosisBoxHeight));

            // Draw the Diagnosis Information title inside the box
            graphic.DrawString("Diagnosis", headerFont, Brushes.White, new PointF(diagBoxStartX + 5, diagBoxStartY + 2));

            // Adjust offset for the content inside the box
            contentOffsetY = diagBoxStartY + 30;

            graphic.DrawString("Doctor Diagnosis:", fontbold, Brushes.Black, diagBoxStartX + 10, contentOffsetY);
            graphic.DrawString($"{Diagnosis.Text}", font, Brushes.Black, diagBoxStartX + 190, contentOffsetY);
            contentOffsetY += (int)fontHeight + 5;

            graphic.DrawString("Patient Symptoms:", fontbold, Brushes.Black, diagBoxStartX + 10, contentOffsetY);
            graphic.DrawString($"{Symptoms.Text}", font, Brushes.Black, diagBoxStartX + 190, contentOffsetY);
            contentOffsetY += (int)fontHeight + 5;

            graphic.DrawString("Doctor Examination:", fontbold, Brushes.Black, diagBoxStartX + 10, contentOffsetY);
            graphic.DrawString($"{Assessment.Text}", font, Brushes.Black, diagBoxStartX + 210, contentOffsetY);

            // Update the offset after the diagnosis information box
            offset = diagBoxStartY + 25;

            // Draw the Medications box
            int medicationsBoxWidth = 815;
            int medicationsBoxHeight = (int)(fontHeight * 6) + 80; // Adjust the height based on the content
            int medBoxStartX = startX;
            int medBoxStartY = startY + offset;

            // Draw the rectangle
            graphic.FillRectangle(Brushes.Gray, medBoxStartX, medBoxStartY, medicationsBoxWidth, 28);
            graphic.DrawRectangle(Pens.Black, new Rectangle(medBoxStartX, medBoxStartY, medicationsBoxWidth, medicationsBoxHeight));

            // Draw the Medications title inside the box
            graphic.DrawString("Medications", headerFont, Brushes.White, new PointF(medBoxStartX + 5, medBoxStartY + 2));

            // Adjust offset for the content inside the box
            contentOffsetY = medBoxStartY + 30;

            // Table Column Headers
            int col1X = medBoxStartX + 10;  // Medicine Name
            int col2X = medBoxStartX + 145; // Dose
            int col3X = medBoxStartX + 222; // Intake
            int col4X = medBoxStartX + 332; // Schedule
            int col5X = medBoxStartX + 508; // DAYS
            int col6X = medBoxStartX + 591; // Instruction

            graphic.DrawString("Medicine", fontbold, Brushes.Black, col1X, contentOffsetY);
            graphic.DrawString("Dose", fontbold, Brushes.Black, col2X, contentOffsetY);
            graphic.DrawString("Route", fontbold, Brushes.Black, col3X, contentOffsetY);
            graphic.DrawString("Frequency", fontbold, Brushes.Black, col4X, contentOffsetY);
            graphic.DrawString("Days", fontbold, Brushes.Black, col5X, contentOffsetY);
            graphic.DrawString("Instruction", fontbold, Brushes.Black, col6X, contentOffsetY);

            contentOffsetY += (int)fontHeight + 5;

            // Loop through each medication and draw the details

            foreach (string med in medArray)
            {
                string[] parts = med.Trim().Split('-');
                string medicineName = parts[0].Trim();
                string[] details = parts.Length > 1 ? parts[1].Trim().Split(',') : new string[] { };

                string dose = details.Length > 0 ? details[0].Split(':')[1].Trim() : "N/A";
                string intake = details.Length > 1 ? details[1].Split(':')[1].Trim() : "N/A";
                string schedule = details.Length > 2 ? details[2].Split(':')[1].Trim() : "N/A";
                string days = details.Length > 3 ? details[3].Split(':')[1].Trim() : "N/A";
                string instruction = details.Length > 4 ? details[4].Split(':')[1].Trim() : "N/A";

                graphic.DrawString(medicineName, font, Brushes.Black, col1X, contentOffsetY);
                graphic.DrawString(dose, font, Brushes.Black, col2X, contentOffsetY);
                graphic.DrawString(intake, font, Brushes.Black, col3X, contentOffsetY);
                graphic.DrawString(schedule, font, Brushes.Black, col4X, contentOffsetY);
                graphic.DrawString(days, font, Brushes.Black, col5X, contentOffsetY);
                graphic.DrawString(instruction, new("Courier New", 11), Brushes.Black, col6X, contentOffsetY);

                contentOffsetY += (int)fontHeight + 5;
            }
            
            // Update the offset after the medications information box
            offset = medBoxStartY + 115;
            // Draw the Lab Recommendations box
            int labBoxWidth = 815;
            int labBoxHeight = (int)(fontHeight * 2) + 30; // Adjust the height based on the content
            int labBoxStartX = startX;
            int labBoxStartY = startY + offset;

            // Draw the rectangle
            graphic.FillRectangle(Brushes.Gray, labBoxStartX, labBoxStartY, labBoxWidth, 28);
            graphic.DrawRectangle(Pens.Black, new Rectangle(labBoxStartX, labBoxStartY, labBoxWidth, labBoxHeight));

            // Draw the Lab Recommendations title inside the box
            graphic.DrawString("Lab Recommendations", headerFont, Brushes.White, new PointF(labBoxStartX + 5, labBoxStartY + 2));

            // Adjust offset for the content inside the box
            contentOffsetY = labBoxStartY + 30;

            graphic.DrawString("Lab Name:", fontbold, Brushes.Black, labBoxStartX + 10, contentOffsetY);
            graphic.DrawString($"{LabName.Text}", font, Brushes.Black, labBoxStartX + 110, contentOffsetY);

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

        private void button6_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
