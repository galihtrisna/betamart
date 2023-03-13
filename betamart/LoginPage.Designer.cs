namespace betamart
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            invalidLogin2 = new Label();
            invalidLogin1 = new Label();
            btnMasuk = new Button();
            label5 = new Label();
            label2 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            textEmail = new TextBox();
            panel4 = new Panel();
            textPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(322, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 450);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(401, 89);
            label1.TabIndex = 4;
            label1.Text = "Selamat Datang Di Betamart Purwokerto";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 309);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(invalidLogin2);
            panel2.Controls.Add(invalidLogin1);
            panel2.Controls.Add(btnMasuk);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 450);
            panel2.TabIndex = 1;
            // 
            // invalidLogin2
            // 
            invalidLogin2.AutoSize = true;
            invalidLogin2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            invalidLogin2.ForeColor = Color.Red;
            invalidLogin2.Location = new Point(58, 307);
            invalidLogin2.Name = "invalidLogin2";
            invalidLogin2.Size = new Size(73, 13);
            invalidLogin2.TabIndex = 18;
            invalidLogin2.Text = "Invalid Login";
            invalidLogin2.Visible = false;
            // 
            // invalidLogin1
            // 
            invalidLogin1.AutoSize = true;
            invalidLogin1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            invalidLogin1.ForeColor = Color.Red;
            invalidLogin1.Location = new Point(58, 225);
            invalidLogin1.Name = "invalidLogin1";
            invalidLogin1.Size = new Size(73, 13);
            invalidLogin1.TabIndex = 17;
            invalidLogin1.Text = "Invalid Login";
            invalidLogin1.Visible = false;
            // 
            // btnMasuk
            // 
            btnMasuk.AutoSize = true;
            btnMasuk.BackColor = Color.FromArgb(47, 105, 254);
            btnMasuk.FlatAppearance.BorderSize = 0;
            btnMasuk.FlatStyle = FlatStyle.Flat;
            btnMasuk.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnMasuk.ForeColor = Color.White;
            btnMasuk.Location = new Point(58, 327);
            btnMasuk.Name = "btnMasuk";
            btnMasuk.RightToLeft = RightToLeft.No;
            btnMasuk.Size = new Size(215, 36);
            btnMasuk.TabIndex = 16;
            btnMasuk.Text = "Masuk";
            btnMasuk.UseVisualStyleBackColor = false;
            btnMasuk.Click += btnMasuk_Click;
            btnMasuk.Paint += btn_Masuk_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(54, 158);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 12;
            label5.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 88);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 9;
            label2.Text = "Masuk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(54, 240);
            label6.Name = "label6";
            label6.Size = new Size(79, 21);
            label6.TabIndex = 14;
            label6.Text = "Password";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textEmail);
            panel3.Location = new Point(58, 182);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 8, 10, 10);
            panel3.Size = new Size(215, 41);
            panel3.TabIndex = 13;
            // 
            // textEmail
            // 
            textEmail.BackColor = SystemColors.Control;
            textEmail.BorderStyle = BorderStyle.None;
            textEmail.Dock = DockStyle.Fill;
            textEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textEmail.Location = new Point(10, 8);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Masukkan email";
            textEmail.Size = new Size(193, 22);
            textEmail.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(textPassword);
            panel4.Location = new Point(58, 264);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 8, 10, 10);
            panel4.Size = new Size(215, 41);
            panel4.TabIndex = 15;
            // 
            // textPassword
            // 
            textPassword.BackColor = SystemColors.Control;
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Dock = DockStyle.Fill;
            textPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textPassword.Location = new Point(10, 8);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.PlaceholderText = "Masukkan password";
            textPassword.Size = new Size(193, 22);
            textPassword.TabIndex = 4;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "LoginPage";
            Text = "LoginPage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label invalidLogin2;
        private Label invalidLogin1;
        private Button btnMasuk;
        private Label label5;
        private Label label2;
        private Label label6;
        private Panel panel3;
        private TextBox textEmail;
        private Panel panel4;
        private TextBox textPassword;
    }
}