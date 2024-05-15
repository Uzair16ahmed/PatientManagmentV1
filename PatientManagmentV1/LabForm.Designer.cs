namespace PatientManagmentV1
{
    partial class LabForm
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            LabName = new TextBox();
            LabId = new TextBox();
            LabGV = new Guna.UI2.WinForms.Guna2DataGridView();
            label3 = new Label();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LabGV).BeginInit();
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
            panel1.TabIndex = 2;
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
            label2.Location = new Point(442, 45);
            label2.Name = "label2";
            label2.Size = new Size(61, 36);
            label2.TabIndex = 2;
            label2.Text = "LAB";
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
            button4.Location = new Point(107, 377);
            button4.Name = "button4";
            button4.Size = new Size(94, 46);
            button4.TabIndex = 17;
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
            button3.Location = new Point(279, 310);
            button3.Name = "button3";
            button3.Size = new Size(94, 46);
            button3.TabIndex = 16;
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
            button2.Location = new Point(166, 310);
            button2.Name = "button2";
            button2.Size = new Size(93, 46);
            button2.TabIndex = 15;
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
            button1.Location = new Point(55, 310);
            button1.Name = "button1";
            button1.Size = new Size(92, 46);
            button1.TabIndex = 14;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LabName
            // 
            LabName.BackColor = Color.White;
            LabName.Location = new Point(64, 231);
            LabName.Name = "LabName";
            LabName.PlaceholderText = "Lab Name";
            LabName.Size = new Size(182, 23);
            LabName.TabIndex = 19;
            // 
            // LabId
            // 
            LabId.BackColor = Color.White;
            LabId.Enabled = false;
            LabId.Location = new Point(64, 174);
            LabId.Name = "LabId";
            LabId.PlaceholderText = "LabID";
            LabId.Size = new Size(182, 23);
            LabId.TabIndex = 18;
            // 
            // LabGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            LabGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            LabGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            LabGV.ColumnHeadersHeight = 30;
            LabGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            LabGV.DefaultCellStyle = dataGridViewCellStyle3;
            LabGV.GridColor = Color.FromArgb(231, 229, 255);
            LabGV.Location = new Point(421, 156);
            LabGV.Name = "LabGV";
            LabGV.RowHeadersVisible = false;
            LabGV.Size = new Size(493, 345);
            LabGV.TabIndex = 20;
            LabGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            LabGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            LabGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            LabGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            LabGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            LabGV.ThemeStyle.BackColor = Color.White;
            LabGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            LabGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            LabGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            LabGV.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            LabGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            LabGV.ThemeStyle.HeaderStyle.Height = 30;
            LabGV.ThemeStyle.ReadOnly = false;
            LabGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            LabGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            LabGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            LabGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            LabGV.ThemeStyle.RowsStyle.Height = 25;
            LabGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            LabGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            LabGV.CellContentClick += LabGV_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(611, 108);
            label3.Name = "label3";
            label3.Size = new Size(130, 36);
            label3.TabIndex = 21;
            label3.Text = "LABS LIST";
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(227, 377);
            button5.Name = "button5";
            button5.Size = new Size(94, 46);
            button5.TabIndex = 22;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // LabForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 597);
            Controls.Add(button5);
            Controls.Add(label3);
            Controls.Add(LabGV);
            Controls.Add(LabName);
            Controls.Add(LabId);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LabForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LabForm";
            Load += LabForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LabGV).EndInit();
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
        private TextBox LabName;
        private TextBox LabId;
        private Guna.UI2.WinForms.Guna2DataGridView LabGV;
        private Label label3;
        private Button button5;
    }
}