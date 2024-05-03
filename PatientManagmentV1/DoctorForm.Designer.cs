namespace PatientManagmentV1
{
    partial class DoctorForm
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
            DocId = new TextBox();
            DocName = new TextBox();
            DocPass = new TextBox();
            DoctorGV = new Guna.UI2.WinForms.Guna2DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            RoleCb = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DoctorGV).BeginInit();
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
            panel1.Size = new Size(945, 96);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(907, 9);
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
            label2.Location = new Point(417, 45);
            label2.Name = "label2";
            label2.Size = new Size(117, 36);
            label2.TabIndex = 2;
            label2.Text = "DOCTOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(279, 9);
            label1.Name = "label1";
            label1.Size = new Size(406, 36);
            label1.TabIndex = 1;
            label1.Text = "PATIENT MANAGEMENT SYSTEM";
            // 
            // DocId
            // 
            DocId.BackColor = Color.Gainsboro;
            DocId.Location = new Point(44, 172);
            DocId.Name = "DocId";
            DocId.PlaceholderText = "DoctorID";
            DocId.Size = new Size(182, 23);
            DocId.TabIndex = 1;
            // 
            // DocName
            // 
            DocName.BackColor = Color.Gainsboro;
            DocName.Location = new Point(44, 222);
            DocName.Name = "DocName";
            DocName.PlaceholderText = "DoctorName";
            DocName.Size = new Size(182, 23);
            DocName.TabIndex = 2;
            DocName.TextChanged += DocName_TextChanged;
            // 
            // DocPass
            // 
            DocPass.BackColor = Color.Gainsboro;
            DocPass.Location = new Point(44, 321);
            DocPass.Name = "DocPass";
            DocPass.PlaceholderText = "Password";
            DocPass.Size = new Size(182, 23);
            DocPass.TabIndex = 4;
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
            DoctorGV.Location = new Point(417, 141);
            DoctorGV.Name = "DoctorGV";
            DoctorGV.RowHeadersVisible = false;
            DoctorGV.Size = new Size(516, 332);
            DoctorGV.TabIndex = 5;
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
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(44, 399);
            button1.Name = "button1";
            button1.Size = new Size(92, 46);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(155, 399);
            button2.Name = "button2";
            button2.Size = new Size(93, 46);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DeepSkyBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(268, 399);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(154, 470);
            button4.Name = "button4";
            button4.Size = new Size(94, 46);
            button4.TabIndex = 9;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // RoleCb
            // 
            RoleCb.FormattingEnabled = true;
            RoleCb.Items.AddRange(new object[] { "Admin", "User" });
            RoleCb.Location = new Point(44, 271);
            RoleCb.Name = "RoleCb";
            RoleCb.Size = new Size(182, 23);
            RoleCb.TabIndex = 10;
            RoleCb.Text = "Role";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(945, 597);
            Controls.Add(RoleCb);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DoctorGV);
            Controls.Add(DocPass);
            Controls.Add(DocName);
            Controls.Add(DocId);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoctorForm";
            Load += DoctorForm_Load;
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
        private TextBox DocId;
        private TextBox DocName;
        private TextBox DocPass;
        private Guna.UI2.WinForms.Guna2DataGridView DoctorGV;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private ComboBox RoleCb;
    }
}