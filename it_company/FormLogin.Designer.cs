namespace it_company
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pbLogo = new PictureBox();
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtLogin = new TextBox();
            lblPassword = new Label();
            lblLogin = new Label();
            btnGuest = new Button();
            btnLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.ErrorImage = null;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.InitialImage = null;
            pbLogo.Location = new Point(128, 13);
            pbLogo.Margin = new Padding(4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(129, 127);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(lblPassword);
            panel1.Controls.Add(lblLogin);
            panel1.Controls.Add(btnGuest);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(13, 149);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 210);
            panel1.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(24, 101);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(310, 26);
            txtPassword.TabIndex = 5;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(24, 36);
            txtLogin.Margin = new Padding(4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(310, 26);
            txtLogin.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(151, 70);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль";
            lblPassword.UseCompatibleTextRendering = true;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(153, 9);
            lblLogin.Margin = new Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(52, 19);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Логин";
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.FromArgb(156, 211, 216);
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(112, 172);
            btnGuest.Margin = new Padding(4);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(134, 29);
            btnGuest.TabIndex = 1;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += btnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(156, 211, 216);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(112, 136);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(134, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(panel1);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtLogin;
        private Label lblPassword;
        private Label lblLogin;
        private Button btnGuest;
        private Button btnLogin;
    }
}
