namespace PatientManagmentV1
{
    partial class ExaminationForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            PatientGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            LabNameCb = new ComboBox();
            Assessment = new TextBox();
            Diagnosis = new TextBox();
            Symptoms = new TextBox();
            DiagId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PatientGV).BeginInit();
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
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1509, 160);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1454, 15);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 44);
            label5.TabIndex = 10;
            label5.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(640, 75);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 54);
            label2.TabIndex = 2;
            label2.Text = "Examination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(431, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(616, 54);
            label1.TabIndex = 1;
            label1.Text = "PATIENT MANAGEMENT SYSTEM";
            // 
            // PatientGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            PatientGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            PatientGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            PatientGV.ColumnHeadersHeight = 30;
            PatientGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            PatientGV.DefaultCellStyle = dataGridViewCellStyle6;
            PatientGV.GridColor = Color.FromArgb(231, 229, 255);
            PatientGV.Location = new Point(480, 258);
            PatientGV.Margin = new Padding(4, 5, 4, 5);
            PatientGV.Name = "PatientGV";
            PatientGV.RowHeadersVisible = false;
            PatientGV.RowHeadersWidth = 62;
            PatientGV.RowTemplate.Height = 25;
            PatientGV.Size = new Size(1003, 657);
            PatientGV.TabIndex = 30;
            PatientGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            PatientGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            PatientGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            PatientGV.ThemeStyle.BackColor = Color.White;
            PatientGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            PatientGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            PatientGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            PatientGV.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PatientGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            PatientGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            PatientGV.ThemeStyle.HeaderStyle.Height = 30;
            PatientGV.ThemeStyle.ReadOnly = false;
            PatientGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            PatientGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            PatientGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            PatientGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            PatientGV.ThemeStyle.RowsStyle.Height = 25;
            PatientGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            PatientGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(846, 175);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(326, 54);
            label3.TabIndex = 29;
            label3.Text = "ExaminationLIST";
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(161, 725);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(133, 68);
            button4.TabIndex = 28;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(318, 624);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(126, 77);
            button3.TabIndex = 27;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(161, 624);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(133, 77);
            button2.TabIndex = 26;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(16, 624);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(123, 77);
            button1.TabIndex = 25;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // LabNameCb
            // 
            LabNameCb.FormattingEnabled = true;
            LabNameCb.Location = new Point(36, 535);
            LabNameCb.Margin = new Padding(4, 5, 4, 5);
            LabNameCb.Name = "LabNameCb";
            LabNameCb.Size = new Size(258, 33);
            LabNameCb.TabIndex = 36;
            LabNameCb.Text = "LabName";
            // 
            // Assessment
            // 
            Assessment.BackColor = Color.Gainsboro;
            Assessment.Location = new Point(36, 464);
            Assessment.Margin = new Padding(4, 5, 4, 5);
            Assessment.Name = "Assessment";
            Assessment.PlaceholderText = "Examination";
            Assessment.Size = new Size(258, 31);
            Assessment.TabIndex = 35;
            // 
            // Diagnosis
            // 
            Diagnosis.BackColor = Color.Gainsboro;
            Diagnosis.Location = new Point(36, 397);
            Diagnosis.Margin = new Padding(4, 5, 4, 5);
            Diagnosis.Name = "Diagnosis";
            Diagnosis.PlaceholderText = "Diagnosis";
            Diagnosis.Size = new Size(258, 31);
            Diagnosis.TabIndex = 34;
            // 
            // Symptoms
            // 
            Symptoms.BackColor = Color.Gainsboro;
            Symptoms.Location = new Point(36, 330);
            Symptoms.Margin = new Padding(4, 5, 4, 5);
            Symptoms.Name = "Symptoms";
            Symptoms.PlaceholderText = "Symptoms";
            Symptoms.Size = new Size(258, 31);
            Symptoms.TabIndex = 33;
            // 
            // DiagId
            // 
            DiagId.BackColor = Color.Gainsboro;
            DiagId.Location = new Point(36, 262);
            DiagId.Margin = new Padding(4, 5, 4, 5);
            DiagId.Name = "DiagId";
            DiagId.PlaceholderText = "DiagnosisID";
            DiagId.Size = new Size(258, 31);
            DiagId.TabIndex = 32;
            // 
            // ExaminationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1509, 995);
            Controls.Add(LabNameCb);
            Controls.Add(Assessment);
            Controls.Add(Diagnosis);
            Controls.Add(Symptoms);
            Controls.Add(DiagId);
            Controls.Add(PatientGV);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExaminationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExaminationForm";
            Load += ExaminationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PatientGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView PatientGV;
        private Label label3;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox LabNameCb;
        private TextBox Assessment;
        private TextBox Diagnosis;
        private TextBox Symptoms;
        private TextBox DiagId;
    }
}