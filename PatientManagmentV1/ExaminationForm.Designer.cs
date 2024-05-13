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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            LabNameCb = new ComboBox();
            Examination = new TextBox();
            Diagnosis = new TextBox();
            Symptoms = new TextBox();
            ExamId = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ExaminationGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ExaminationGV).BeginInit();
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
            panel1.Size = new Size(1052, 96);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(1018, 9);
            label5.Name = "label5";
            label5.Size = new Size(26, 29);
            label5.TabIndex = 10;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(448, 45);
            label2.Name = "label2";
            label2.Size = new Size(166, 36);
            label2.TabIndex = 2;
            label2.Text = "Examination";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(302, 9);
            label1.Name = "label1";
            label1.Size = new Size(406, 36);
            label1.TabIndex = 1;
            label1.Text = "PATIENT MANAGEMENT SYSTEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(592, 105);
            label3.Name = "label3";
            label3.Size = new Size(221, 36);
            label3.TabIndex = 29;
            label3.Text = "Examination LIST";
            // 
            // LabNameCb
            // 
            LabNameCb.FormattingEnabled = true;
            LabNameCb.Location = new Point(25, 321);
            LabNameCb.Name = "LabNameCb";
            LabNameCb.Size = new Size(182, 23);
            LabNameCb.TabIndex = 36;
            LabNameCb.Text = "LabName";
            // 
            // Examination
            // 
            Examination.BackColor = Color.White;
            Examination.Location = new Point(25, 278);
            Examination.Name = "Examination";
            Examination.PlaceholderText = "Examination";
            Examination.Size = new Size(182, 23);
            Examination.TabIndex = 35;
            // 
            // Diagnosis
            // 
            Diagnosis.BackColor = Color.White;
            Diagnosis.Location = new Point(25, 195);
            Diagnosis.Name = "Diagnosis";
            Diagnosis.PlaceholderText = "Diagnosis";
            Diagnosis.Size = new Size(182, 23);
            Diagnosis.TabIndex = 34;
            // 
            // Symptoms
            // 
            Symptoms.BackColor = Color.White;
            Symptoms.Location = new Point(25, 234);
            Symptoms.Name = "Symptoms";
            Symptoms.PlaceholderText = "Symptoms";
            Symptoms.Size = new Size(182, 23);
            Symptoms.TabIndex = 33;
            // 
            // ExamId
            // 
            ExamId.BackColor = Color.White;
            ExamId.Location = new Point(25, 157);
            ExamId.Name = "ExamId";
            ExamId.PlaceholderText = "ExaminationID";
            ExamId.Size = new Size(182, 23);
            ExamId.TabIndex = 32;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(120, 422);
            button4.Name = "button4";
            button4.Size = new Size(87, 40);
            button4.TabIndex = 40;
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
            button3.ForeColor = Color.Black;
            button3.Location = new Point(230, 367);
            button3.Name = "button3";
            button3.Size = new Size(82, 45);
            button3.TabIndex = 39;
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
            button2.ForeColor = Color.Black;
            button2.Location = new Point(120, 367);
            button2.Name = "button2";
            button2.Size = new Size(87, 45);
            button2.TabIndex = 38;
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
            button1.ForeColor = Color.Black;
            button1.Location = new Point(19, 367);
            button1.Name = "button1";
            button1.Size = new Size(80, 45);
            button1.TabIndex = 37;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ExaminationGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            ExaminationGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ExaminationGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ExaminationGV.ColumnHeadersHeight = 30;
            ExaminationGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            ExaminationGV.DefaultCellStyle = dataGridViewCellStyle3;
            ExaminationGV.GridColor = Color.FromArgb(231, 229, 255);
            ExaminationGV.Location = new Point(338, 157);
            ExaminationGV.Name = "ExaminationGV";
            ExaminationGV.RowHeadersVisible = false;
            ExaminationGV.Size = new Size(702, 394);
            ExaminationGV.TabIndex = 5;
            ExaminationGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            ExaminationGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            ExaminationGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            ExaminationGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            ExaminationGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            ExaminationGV.ThemeStyle.BackColor = Color.White;
            ExaminationGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            ExaminationGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            ExaminationGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            ExaminationGV.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExaminationGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            ExaminationGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            ExaminationGV.ThemeStyle.HeaderStyle.Height = 30;
            ExaminationGV.ThemeStyle.ReadOnly = false;
            ExaminationGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            ExaminationGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ExaminationGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            ExaminationGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            ExaminationGV.ThemeStyle.RowsStyle.Height = 25;
            ExaminationGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            ExaminationGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // ExaminationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 572);
            Controls.Add(ExaminationGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LabNameCb);
            Controls.Add(Examination);
            Controls.Add(Diagnosis);
            Controls.Add(Symptoms);
            Controls.Add(ExamId);
            Controls.Add(label3);
            Controls.Add(panel1);
            ForeColor = Color.Gainsboro;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ExaminationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExaminationForm";
            Load += ExaminationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ExaminationGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox LabNameCb;
        private TextBox Examination;
        private TextBox Diagnosis;
        private TextBox Symptoms;
        private TextBox ExamId;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView ExaminationGV;
    }
}