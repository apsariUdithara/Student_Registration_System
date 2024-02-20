namespace Student_Registration_System
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            CloseBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            LoginBtn = new Button();
            label2 = new Label();
            PasswordTb = new TextBox();
            UNameTb = new TextBox();
            label3 = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CloseBtn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LoginBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(PasswordTb);
            panel1.Controls.Add(UNameTb);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(487, 144);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 637);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(61, 19, 95);
            label1.Location = new Point(117, 61);
            label1.Name = "label1";
            label1.Size = new Size(441, 41);
            label1.TabIndex = 1;
            label1.Text = "Student Registration System";
            // 
            // CloseBtn
            // 
            CloseBtn.Cursor = Cursors.Hand;
            CloseBtn.Image = (Image)resources.GetObject("CloseBtn.Image");
            CloseBtn.Location = new Point(597, 15);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(33, 38);
            CloseBtn.SizeMode = PictureBoxSizeMode.Zoom;
            CloseBtn.TabIndex = 8;
            CloseBtn.TabStop = false;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(246, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(61, 19, 95);
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(264, 512);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(136, 45);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(162, 102, 210);
            label2.Location = new Point(136, 277);
            label2.Name = "label2";
            label2.Size = new Size(121, 31);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // PasswordTb
            // 
            PasswordTb.BackColor = Color.FromArgb(224, 224, 224);
            PasswordTb.BorderStyle = BorderStyle.None;
            PasswordTb.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTb.ForeColor = Color.FromArgb(77, 77, 77);
            PasswordTb.Location = new Point(176, 411);
            PasswordTb.Multiline = true;
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '•';
            PasswordTb.Size = new Size(308, 39);
            PasswordTb.TabIndex = 6;
            // 
            // UNameTb
            // 
            UNameTb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UNameTb.BackColor = Color.FromArgb(224, 224, 224);
            UNameTb.BorderStyle = BorderStyle.None;
            UNameTb.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            UNameTb.ForeColor = Color.FromArgb(77, 77, 77);
            UNameTb.Location = new Point(176, 311);
            UNameTb.Multiline = true;
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(308, 39);
            UNameTb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(162, 102, 210);
            label3.Location = new Point(136, 377);
            label3.Name = "label3";
            label3.Size = new Size(113, 31);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 15;
            guna2Elipse1.TargetControl = LoginBtn;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 15;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.BorderRadius = 30;
            guna2Elipse3.TargetControl = UNameTb;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.BorderRadius = 30;
            guna2Elipse4.TargetControl = PasswordTb;
            // 
            // guna2Elipse5
            // 
            guna2Elipse5.BorderRadius = 25;
            guna2Elipse5.TargetControl = panel1;
            // 
            // guna2Elipse6
            // 
            guna2Elipse6.BorderRadius = 15;
            guna2Elipse6.TargetControl = this;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(189, 146, 223);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1616, 926);
            Controls.Add(panel1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox UNameTb;
        private TextBox PasswordTb;
        private Label label3;
        private Button LoginBtn;
        private PictureBox CloseBtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
    }
}