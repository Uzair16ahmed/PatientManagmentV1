﻿namespace PatientManagmentV1
{
    partial class PatientForm
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
            label2 = new Label();
            label1 = new Label();
            PatId = new TextBox();
            PatName = new TextBox();
            PatAddress = new TextBox();
            PatPhone = new TextBox();
            PatAge = new TextBox();
            PatGender = new ComboBox();
            PatBlood = new ComboBox();
            PatDisease = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label3 = new Label();
            DoctorGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 96);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(448, 45);
            label2.Name = "label2";
            label2.Size = new Size(113, 36);
            label2.TabIndex = 2;
            label2.Text = "PATIENT";
            label2.Click += label2_Click;
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
            // PatId
            // 
            PatId.BackColor = Color.Gainsboro;
            PatId.Location = new Point(36, 128);
            PatId.Name = "PatId";
            PatId.PlaceholderText = "PatientID";
            PatId.Size = new Size(182, 23);
            PatId.TabIndex = 2;
            // 
            // PatName
            // 
            PatName.BackColor = Color.Gainsboro;
            PatName.Location = new Point(36, 170);
            PatName.Name = "PatName";
            PatName.PlaceholderText = "PatientName";
            PatName.Size = new Size(182, 23);
            PatName.TabIndex = 3;
            // 
            // PatAddress
            // 
            PatAddress.BackColor = Color.Gainsboro;
            PatAddress.Location = new Point(36, 209);
            PatAddress.Name = "PatAddress";
            PatAddress.PlaceholderText = "PatientAddress";
            PatAddress.Size = new Size(182, 23);
            PatAddress.TabIndex = 4;
            // 
            // PatPhone
            // 
            PatPhone.BackColor = Color.Gainsboro;
            PatPhone.Location = new Point(36, 252);
            PatPhone.Name = "PatPhone";
            PatPhone.PlaceholderText = "PatientPhone";
            PatPhone.Size = new Size(182, 23);
            PatPhone.TabIndex = 5;
            // 
            // PatAge
            // 
            PatAge.BackColor = Color.Gainsboro;
            PatAge.Location = new Point(36, 293);
            PatAge.Name = "PatAge";
            PatAge.PlaceholderText = "PatientAge";
            PatAge.Size = new Size(182, 23);
            PatAge.TabIndex = 6;
            // 
            // PatGender
            // 
            PatGender.FormattingEnabled = true;
            PatGender.Items.AddRange(new object[] { "Male", "Female" });
            PatGender.Location = new Point(36, 331);
            PatGender.Name = "PatGender";
            PatGender.Size = new Size(182, 23);
            PatGender.TabIndex = 7;
            PatGender.Text = "Gender";
            // 
            // PatBlood
            // 
            PatBlood.CausesValidation = false;
            PatBlood.FormattingEnabled = true;
            PatBlood.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            PatBlood.Location = new Point(36, 371);
            PatBlood.Name = "PatBlood";
            PatBlood.Size = new Size(182, 23);
            PatBlood.TabIndex = 8;
            PatBlood.Text = "BloodGroup";
            // 
            // PatDisease
            // 
            PatDisease.BackColor = Color.Gainsboro;
            PatDisease.Location = new Point(36, 412);
            PatDisease.Name = "PatDisease";
            PatDisease.PlaceholderText = "MajorDisease";
            PatDisease.Size = new Size(182, 23);
            PatDisease.TabIndex = 9;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(125, 521);
            button4.Name = "button4";
            button4.Size = new Size(93, 41);
            button4.TabIndex = 14;
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
            button3.Location = new Point(235, 460);
            button3.Name = "button3";
            button3.Size = new Size(88, 46);
            button3.TabIndex = 13;
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
            button2.Location = new Point(125, 460);
            button2.Name = "button2";
            button2.Size = new Size(93, 46);
            button2.TabIndex = 12;
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
            button1.Location = new Point(24, 460);
            button1.Name = "button1";
            button1.Size = new Size(86, 46);
            button1.TabIndex = 11;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(545, 99);
            label3.Name = "label3";
            label3.Size = new Size(182, 36);
            label3.TabIndex = 15;
            label3.Text = "PATIENTS LIST";
            // 
            // DoctorGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            DoctorGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DoctorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DoctorGV.ColumnHeadersHeight = 30;
            DoctorGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DoctorGV.DefaultCellStyle = dataGridViewCellStyle3;
            DoctorGV.GridColor = Color.FromArgb(231, 229, 255);
            DoctorGV.Location = new Point(342, 149);
            DoctorGV.Name = "DoctorGV";
            DoctorGV.RowHeadersVisible = false;
            DoctorGV.Size = new Size(663, 394);
            DoctorGV.TabIndex = 16;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DoctorGV.ThemeStyle.BackColor = Color.White;
            DoctorGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DoctorGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            DoctorGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DoctorGV.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DoctorGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            DoctorGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DoctorGV.ThemeStyle.HeaderStyle.Height = 30;
            DoctorGV.ThemeStyle.ReadOnly = false;
            DoctorGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            DoctorGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DoctorGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            DoctorGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DoctorGV.ThemeStyle.RowsStyle.Height = 25;
            DoctorGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DoctorGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DoctorGV.CellContentClick += DoctorGV_CellContentClick;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1024, 597);
            Controls.Add(DoctorGV);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PatDisease);
            Controls.Add(PatBlood);
            Controls.Add(PatGender);
            Controls.Add(PatAge);
            Controls.Add(PatPhone);
            Controls.Add(PatAddress);
            Controls.Add(PatName);
            Controls.Add(PatId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PatientForm";
            Load += PatientForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox PatId;
        private TextBox PatName;
        private TextBox PatAddress;
        private TextBox PatPhone;
        private TextBox PatAge;
        private ComboBox PatGender;
        private ComboBox PatBlood;
        private TextBox PatDisease;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView DoctorGV;
    }
}