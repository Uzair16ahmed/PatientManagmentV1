namespace PatientManagmentV1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            button1 = new Button();
            UsernameTb = new TextBox();
            PassTb = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 63);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(367, 9);
            label5.Name = "label5";
            label5.Size = new Size(26, 29);
            label5.TabIndex = 10;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(44, 18);
            label1.Name = "label1";
            label1.Size = new Size(304, 36);
            label1.TabIndex = 0;
            label1.Text = "PATIENT MANAGEMENT";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(69, 278);
            button1.Name = "button1";
            button1.Size = new Size(249, 50);
            button1.TabIndex = 1;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UsernameTb
            // 
            UsernameTb.ForeColor = SystemColors.Desktop;
            UsernameTb.Location = new Point(69, 151);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.PlaceholderText = "Username";
            UsernameTb.Size = new Size(249, 23);
            UsernameTb.TabIndex = 3;
            // 
            // PassTb
            // 
            PassTb.ForeColor = SystemColors.Desktop;
            PassTb.Location = new Point(69, 208);
            PassTb.Name = "PassTb";
            PassTb.PlaceholderText = "Password";
            PassTb.Size = new Size(249, 23);
            PassTb.TabIndex = 4;
            PassTb.UseSystemPasswordChar = true;
            PassTb.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(165, 359);
            label2.Name = "label2";
            label2.Size = new Size(49, 23);
            label2.TabIndex = 5;
            label2.Text = "Clear";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(396, 391);
            Controls.Add(label2);
            Controls.Add(PassTb);
            Controls.Add(UsernameTb);
            Controls.Add(button1);
            Controls.Add(panel1);
            ForeColor = Color.DeepSkyBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Username";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private TextBox UsernameTb;
        private TextBox PassTb;
        private Label label2;
        private Label label5;
    }
}
