namespace PatientManagmentV1
{
    partial class DiagnosisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiagnosisForm));
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            DiagId = new TextBox();
            PatientIdCb = new ComboBox();
            PatientTb = new TextBox();
            Symptoms = new TextBox();
            Diagnosis = new TextBox();
            Medicines = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            DiagnosisGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            diagsummary = new Panel();
            label9 = new Label();
            Diagnosislbl = new Label();
            Medicineslbl = new Label();
            Symptomslbl = new Label();
            PatientNamelbl = new Label();
            label4 = new Label();
            button5 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).BeginInit();
            diagsummary.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 96);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(945, 9);
            label5.Name = "label5";
            label5.Size = new Size(26, 29);
            label5.TabIndex = 9;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(398, 45);
            label2.Name = "label2";
            label2.Size = new Size(152, 36);
            label2.TabIndex = 2;
            label2.Text = "DIAGNOSIS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(269, 9);
            label1.Name = "label1";
            label1.Size = new Size(406, 36);
            label1.TabIndex = 1;
            label1.Text = "PATIENT MANAGEMENT SYSTEM";
            // 
            // DiagId
            // 
            DiagId.BackColor = Color.Gainsboro;
            DiagId.Location = new Point(25, 115);
            DiagId.Name = "DiagId";
            DiagId.PlaceholderText = "DiagnosisID";
            DiagId.Size = new Size(182, 23);
            DiagId.TabIndex = 3;
            // 
            // PatientIdCb
            // 
            PatientIdCb.FormattingEnabled = true;
            PatientIdCb.Location = new Point(25, 154);
            PatientIdCb.Name = "PatientIdCb";
            PatientIdCb.Size = new Size(182, 23);
            PatientIdCb.TabIndex = 8;
            PatientIdCb.Text = "PatientID";
            PatientIdCb.SelectionChangeCommitted += PatientIdCb_SelectionChangeCommitted;
            // 
            // PatientTb
            // 
            PatientTb.BackColor = Color.Gainsboro;
            PatientTb.Cursor = Cursors.No;
            PatientTb.Enabled = false;
            PatientTb.Location = new Point(25, 193);
            PatientTb.Name = "PatientTb";
            PatientTb.PlaceholderText = "PatientName";
            PatientTb.Size = new Size(182, 23);
            PatientTb.TabIndex = 9;
            // 
            // Symptoms
            // 
            Symptoms.BackColor = Color.Gainsboro;
            Symptoms.Location = new Point(236, 115);
            Symptoms.Name = "Symptoms";
            Symptoms.PlaceholderText = "Symptoms";
            Symptoms.Size = new Size(182, 23);
            Symptoms.TabIndex = 10;
            // 
            // Diagnosis
            // 
            Diagnosis.BackColor = Color.Gainsboro;
            Diagnosis.Location = new Point(236, 154);
            Diagnosis.Name = "Diagnosis";
            Diagnosis.PlaceholderText = "Diagnosis";
            Diagnosis.Size = new Size(182, 23);
            Diagnosis.TabIndex = 11;
            // 
            // Medicines
            // 
            Medicines.BackColor = Color.Gainsboro;
            Medicines.Location = new Point(236, 193);
            Medicines.Name = "Medicines";
            Medicines.PlaceholderText = "Medicines";
            Medicines.Size = new Size(182, 23);
            Medicines.TabIndex = 12;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(170, 308);
            button4.Name = "button4";
            button4.Size = new Size(93, 41);
            button4.TabIndex = 18;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(280, 247);
            button3.Name = "button3";
            button3.Size = new Size(88, 46);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(170, 247);
            button2.Name = "button2";
            button2.Size = new Size(93, 46);
            button2.TabIndex = 16;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(69, 247);
            button1.Name = "button1";
            button1.Size = new Size(86, 46);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DiagnosisGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DiagnosisGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DiagnosisGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DiagnosisGV.ColumnHeadersHeight = 30;
            DiagnosisGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DiagnosisGV.DefaultCellStyle = dataGridViewCellStyle3;
            DiagnosisGV.GridColor = Color.FromArgb(231, 229, 255);
            DiagnosisGV.Location = new Point(69, 463);
            DiagnosisGV.Name = "DiagnosisGV";
            DiagnosisGV.RowHeadersVisible = false;
            DiagnosisGV.Size = new Size(885, 186);
            DiagnosisGV.TabIndex = 19;
            DiagnosisGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DiagnosisGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            DiagnosisGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DiagnosisGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DiagnosisGV.ThemeStyle.BackColor = Color.White;
            DiagnosisGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DiagnosisGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DiagnosisGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DiagnosisGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            DiagnosisGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DiagnosisGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DiagnosisGV.ThemeStyle.HeaderStyle.Height = 30;
            DiagnosisGV.ThemeStyle.ReadOnly = false;
            DiagnosisGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            DiagnosisGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DiagnosisGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DiagnosisGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DiagnosisGV.ThemeStyle.RowsStyle.Height = 25;
            DiagnosisGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DiagnosisGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DiagnosisGV.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(368, 413);
            label3.Name = "label3";
            label3.Size = new Size(207, 36);
            label3.TabIndex = 20;
            label3.Text = "DIAGNOSIS LIST";
            // 
            // diagsummary
            // 
            diagsummary.Controls.Add(label9);
            diagsummary.Controls.Add(Diagnosislbl);
            diagsummary.Controls.Add(Medicineslbl);
            diagsummary.Controls.Add(Symptomslbl);
            diagsummary.Controls.Add(PatientNamelbl);
            diagsummary.Controls.Add(label4);
            diagsummary.Location = new Point(474, 116);
            diagsummary.Name = "diagsummary";
            diagsummary.Size = new Size(497, 294);
            diagsummary.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(338, 14);
            label9.Name = "label9";
            label9.Size = new Size(40, 19);
            label9.TabIndex = 8;
            label9.Text = "Date";
            // 
            // Diagnosislbl
            // 
            Diagnosislbl.AutoSize = true;
            Diagnosislbl.Font = new Font("Calibri", 14.25F);
            Diagnosislbl.ForeColor = Color.Black;
            Diagnosislbl.Location = new Point(294, 121);
            Diagnosislbl.Name = "Diagnosislbl";
            Diagnosislbl.Size = new Size(84, 23);
            Diagnosislbl.TabIndex = 7;
            Diagnosislbl.Text = "Diagnosis";
            // 
            // Medicineslbl
            // 
            Medicineslbl.AutoSize = true;
            Medicineslbl.Font = new Font("Calibri", 14.25F);
            Medicineslbl.ForeColor = Color.Black;
            Medicineslbl.Location = new Point(290, 192);
            Medicineslbl.Name = "Medicineslbl";
            Medicineslbl.Size = new Size(88, 23);
            Medicineslbl.TabIndex = 6;
            Medicineslbl.Text = "Medicines";
            // 
            // Symptomslbl
            // 
            Symptomslbl.AutoSize = true;
            Symptomslbl.Font = new Font("Calibri", 14.25F);
            Symptomslbl.ForeColor = Color.Black;
            Symptomslbl.Location = new Point(51, 192);
            Symptomslbl.Name = "Symptomslbl";
            Symptomslbl.Size = new Size(92, 23);
            Symptomslbl.TabIndex = 5;
            Symptomslbl.Text = "Symptoms";
            // 
            // PatientNamelbl
            // 
            PatientNamelbl.AutoSize = true;
            PatientNamelbl.Font = new Font("Calibri", 14.25F);
            PatientNamelbl.ForeColor = Color.Black;
            PatientNamelbl.Location = new Point(51, 121);
            PatientNamelbl.Name = "PatientNamelbl";
            PatientNamelbl.Size = new Size(110, 23);
            PatientNamelbl.TabIndex = 4;
            PatientNamelbl.Text = "PatientName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(102, 54);
            label4.Name = "label4";
            label4.Size = new Size(239, 29);
            label4.TabIndex = 3;
            label4.Text = "DIAGNOSIS SUMMARY";
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(674, 413);
            button5.Name = "button5";
            button5.Size = new Size(93, 41);
            button5.TabIndex = 22;
            button5.Text = "Print";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // DiagnosisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 670);
            Controls.Add(button5);
            Controls.Add(diagsummary);
            Controls.Add(label3);
            Controls.Add(DiagnosisGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Medicines);
            Controls.Add(Diagnosis);
            Controls.Add(Symptoms);
            Controls.Add(PatientTb);
            Controls.Add(PatientIdCb);
            Controls.Add(DiagId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DiagnosisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiagnosisForm";
            Load += DiagnosisForm_Load;
            VisibleChanged += DiagnosisForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DiagnosisGV).EndInit();
            diagsummary.ResumeLayout(false);
            diagsummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox DiagId;
        private ComboBox PatientIdCb;
        private TextBox PatientTb;
        private TextBox Symptoms;
        private TextBox Diagnosis;
        private TextBox Medicines;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView DiagnosisGV;
        private Label label3;
        private Panel diagsummary;
        private Label label4;
        private Label label9;
        private Label Diagnosislbl;
        private Label Medicineslbl;
        private Label Symptomslbl;
        private Label PatientNamelbl;
        private Button button5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label label5;
    }
}