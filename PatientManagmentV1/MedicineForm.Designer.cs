namespace PatientManagmentV1
{
    partial class MedicineForm
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            MedId = new TextBox();
            MedicineName = new TextBox();
            MedicineGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            DoseCb = new ComboBox();
            RouteCb = new ComboBox();
            FrequencyCb = new ComboBox();
            DaysCb = new ComboBox();
            InstructionCb = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MedicineGV).BeginInit();
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
            panel1.TabIndex = 1;
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
            label2.Size = new Size(136, 36);
            label2.TabIndex = 2;
            label2.Text = "MEDICINE";
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
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(142, 329);
            button4.Name = "button4";
            button4.Size = new Size(94, 46);
            button4.TabIndex = 13;
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
            button3.Location = new Point(256, 258);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 12;
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
            button2.Location = new Point(143, 258);
            button2.Name = "button2";
            button2.Size = new Size(93, 46);
            button2.TabIndex = 11;
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
            button1.Location = new Point(32, 258);
            button1.Name = "button1";
            button1.Size = new Size(92, 46);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // MedId
            // 
            MedId.BackColor = Color.White;
            MedId.Location = new Point(24, 123);
            MedId.Name = "MedId";
            MedId.PlaceholderText = "MedicineID";
            MedId.Size = new Size(182, 23);
            MedId.TabIndex = 14;
            // 
            // MedicineName
            // 
            MedicineName.BackColor = Color.White;
            MedicineName.Location = new Point(227, 123);
            MedicineName.Name = "MedicineName";
            MedicineName.PlaceholderText = "Medicine Name";
            MedicineName.Size = new Size(182, 23);
            MedicineName.TabIndex = 15;
            // 
            // MedicineGV
            // 
            dataGridViewCellStyle10.BackColor = Color.White;
            MedicineGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            MedicineGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            MedicineGV.ColumnHeadersHeight = 30;
            MedicineGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            MedicineGV.DefaultCellStyle = dataGridViewCellStyle12;
            MedicineGV.GridColor = Color.FromArgb(231, 229, 255);
            MedicineGV.Location = new Point(12, 416);
            MedicineGV.Name = "MedicineGV";
            MedicineGV.RowHeadersVisible = false;
            MedicineGV.Size = new Size(921, 148);
            MedicineGV.TabIndex = 17;
            MedicineGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            MedicineGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            MedicineGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            MedicineGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            MedicineGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            MedicineGV.ThemeStyle.BackColor = Color.White;
            MedicineGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            MedicineGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            MedicineGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            MedicineGV.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MedicineGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            MedicineGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            MedicineGV.ThemeStyle.HeaderStyle.Height = 30;
            MedicineGV.ThemeStyle.ReadOnly = false;
            MedicineGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            MedicineGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            MedicineGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            MedicineGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            MedicineGV.ThemeStyle.RowsStyle.Height = 25;
            MedicineGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            MedicineGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            MedicineGV.CellContentClick += MedicineGV_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(362, 366);
            label3.Name = "label3";
            label3.Size = new Size(205, 36);
            label3.TabIndex = 18;
            label3.Text = "MEDICINES LIST";
            // 
            // DoseCb
            // 
            DoseCb.FormattingEnabled = true;
            DoseCb.Items.AddRange(new object[] { "1 گولی", "2 گولی", "3 گولی", "4 گولی", "5 گولی", "6 گولی", "7 گولی", "8 گولی", "9 گولی", "10 گولی", "11 گولی", "12 گولی" });
            DoseCb.Location = new Point(431, 123);
            DoseCb.Name = "DoseCb";
            DoseCb.Size = new Size(166, 23);
            DoseCb.TabIndex = 19;
            DoseCb.Text = "Dose";
            // 
            // RouteCb
            // 
            RouteCb.FormattingEnabled = true;
            RouteCb.Items.AddRange(new object[] { "PO", "IV ", "IM ", "SC ", "PR", "PV ", "Inhale", "Sublingual ", "Topical", "As directed" });
            RouteCb.Location = new Point(616, 123);
            RouteCb.Name = "RouteCb";
            RouteCb.Size = new Size(202, 23);
            RouteCb.TabIndex = 20;
            RouteCb.Text = "Route";
            // 
            // FrequencyCb
            // 
            FrequencyCb.FormattingEnabled = true;
            FrequencyCb.Items.AddRange(new object[] { "صبح میں ایک بار", "دن میں ایک بار", "صبح+شام", "صبح+دوپہر+شام", "صبح+دوپہر+شام+رات" });
            FrequencyCb.Location = new Point(24, 176);
            FrequencyCb.Name = "FrequencyCb";
            FrequencyCb.Size = new Size(182, 23);
            FrequencyCb.TabIndex = 21;
            FrequencyCb.Text = "Frequency";
            // 
            // DaysCb
            // 
            DaysCb.FormattingEnabled = true;
            DaysCb.Items.AddRange(new object[] { "1 Day", "2 Days", "3 Days", "4 Days", "5 Days", "6 Days", "7 Days", "1 Week", "2 Weeks", "3 Weeks", "4 Weeks", "1 Month", "3 Month" });
            DaysCb.Location = new Point(227, 176);
            DaysCb.Name = "DaysCb";
            DaysCb.Size = new Size(182, 23);
            DaysCb.TabIndex = 22;
            DaysCb.Text = "Days";
            // 
            // InstructionCb
            // 
            InstructionCb.FormattingEnabled = true;
            InstructionCb.Items.AddRange(new object[] { "صبح ناشتے سے پہلے", "صبح ناشتے+رات کھانے سے پہلے", "کھانے کے بعد", "کھانے سے پہلے", "کھانے کے درمیان", "رات کو سوتے وقت", "ماہواری کے 5 دن", "ہفتے میں ایک بار", "ہفتے میں دو بار", "دن میں ایک بار" });
            InstructionCb.Location = new Point(431, 176);
            InstructionCb.Name = "InstructionCb";
            InstructionCb.Size = new Size(192, 23);
            InstructionCb.TabIndex = 23;
            InstructionCb.Text = "Instruction";
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(945, 597);
            Controls.Add(InstructionCb);
            Controls.Add(DaysCb);
            Controls.Add(FrequencyCb);
            Controls.Add(RouteCb);
            Controls.Add(DoseCb);
            Controls.Add(label3);
            Controls.Add(MedicineGV);
            Controls.Add(MedicineName);
            Controls.Add(MedId);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MedicineForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicineForm";
            Load += MedicineForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MedicineGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label2;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox MedId;
        private TextBox MedicineName;
        private Guna.UI2.WinForms.Guna2DataGridView MedicineGV;
        private Label label3;
        private ComboBox DoseCb;
        private ComboBox RouteCb;
        private ComboBox FrequencyCb;
        private ComboBox DaysCb;
        private ComboBox InstructionCb;
    }
}