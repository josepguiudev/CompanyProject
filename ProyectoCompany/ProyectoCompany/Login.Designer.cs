
namespace ProyectoCompany
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
            TittleBar = new Panel();
            btnMinimize = new PictureBox();
            btnClose = new PictureBox();
            FooterBar = new Panel();
            textBoxUserName = new TextBox();
            labelUserName = new Label();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            checkBoxRememberMe = new CheckBox();
            buttonLogin = new Button();
            panel1 = new Panel();
            linkLabelForgotPassword = new LinkLabel();
            pictureBoxLogoEmpresa = new PictureBox();
            timerInactividad = new System.Windows.Forms.Timer(components);
            TittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoEmpresa).BeginInit();
            SuspendLayout();
            // 
            // TittleBar
            // 
            TittleBar.BackColor = Color.FromArgb(30, 38, 70);
            TittleBar.Controls.Add(btnMinimize);
            TittleBar.Controls.Add(btnClose);
            TittleBar.Dock = DockStyle.Top;
            TittleBar.Location = new Point(0, 0);
            TittleBar.Name = "TittleBar";
            TittleBar.Size = new Size(473, 50);
            TittleBar.TabIndex = 0;
            TittleBar.MouseDown += TittleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.Image = Properties.Resources.minimizar_ventana;
            btnMinimize.Location = new Point(405, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(25, 25);
            btnMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btnMinimize.TabIndex = 1;
            btnMinimize.TabStop = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Image = Properties.Resources.cerrar_ventana;
            btnClose.Location = new Point(436, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 25);
            btnClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // FooterBar
            // 
            FooterBar.BackColor = Color.FromArgb(30, 38, 70);
            FooterBar.Dock = DockStyle.Bottom;
            FooterBar.Location = new Point(0, 686);
            FooterBar.Name = "FooterBar";
            FooterBar.Size = new Size(473, 15);
            FooterBar.TabIndex = 1;
            // 
            // textBoxUserName
            // 
            textBoxUserName.BackColor = Color.FromArgb(80, 94, 128);
            textBoxUserName.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUserName.ForeColor = SystemColors.Window;
            textBoxUserName.Location = new Point(60, 308);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(356, 30);
            textBoxUserName.TabIndex = 2;
            textBoxUserName.Text = "sysadmin@gmail.com";
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserName.ForeColor = Color.Silver;
            labelUserName.Location = new Point(60, 271);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(103, 25);
            labelUserName.TabIndex = 3;
            labelUserName.Text = "User email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.Silver;
            labelPassword.Location = new Point(60, 354);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(96, 25);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(80, 94, 128);
            textBoxPassword.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.ForeColor = SystemColors.Window;
            textBoxPassword.Location = new Point(60, 391);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(356, 30);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.Text = "SystemPassword2024";
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // checkBoxRememberMe
            // 
            checkBoxRememberMe.AutoSize = true;
            checkBoxRememberMe.Font = new Font("Franklin Gothic Medium", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxRememberMe.ForeColor = Color.Silver;
            checkBoxRememberMe.Location = new Point(60, 440);
            checkBoxRememberMe.Name = "checkBoxRememberMe";
            checkBoxRememberMe.Size = new Size(138, 25);
            checkBoxRememberMe.TabIndex = 6;
            checkBoxRememberMe.Text = "Remember me";
            checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(17, 97, 238);
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.Silver;
            buttonLogin.Location = new Point(60, 507);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(356, 51);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(60, 591);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 2);
            panel1.TabIndex = 8;
            // 
            // linkLabelForgotPassword
            // 
            linkLabelForgotPassword.ActiveLinkColor = Color.FromArgb(17, 97, 238);
            linkLabelForgotPassword.AutoSize = true;
            linkLabelForgotPassword.LinkColor = Color.Silver;
            linkLabelForgotPassword.Location = new Point(165, 607);
            linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            linkLabelForgotPassword.Size = new Size(146, 25);
            linkLabelForgotPassword.TabIndex = 9;
            linkLabelForgotPassword.TabStop = true;
            linkLabelForgotPassword.Text = "Forgot Password";
            // 
            // pictureBoxLogoEmpresa
            // 
            pictureBoxLogoEmpresa.Image = Properties.Resources.empresa_freepik;
            pictureBoxLogoEmpresa.Location = new Point(138, 56);
            pictureBoxLogoEmpresa.Name = "pictureBoxLogoEmpresa";
            pictureBoxLogoEmpresa.Size = new Size(200, 200);
            pictureBoxLogoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogoEmpresa.TabIndex = 10;
            pictureBoxLogoEmpresa.TabStop = false;
            // 
            // timerInactividad
            // 
            timerInactividad.Tick += timerInactividad_Tick;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(473, 701);
            Controls.Add(pictureBoxLogoEmpresa);
            Controls.Add(linkLabelForgotPassword);
            Controls.Add(panel1);
            Controls.Add(buttonLogin);
            Controls.Add(checkBoxRememberMe);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(labelUserName);
            Controls.Add(textBoxUserName);
            Controls.Add(FooterBar);
            Controls.Add(TittleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.85D;
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Login_MouseMove;
            TittleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogoEmpresa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TittleBar;
        private Panel FooterBar;
        private PictureBox btnMinimize;
        private PictureBox btnClose;
        private TextBox textBoxUserName;
        private Label labelUserName;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private CheckBox checkBoxRememberMe;
        private Button buttonLogin;
        private Panel panel1;
        private LinkLabel linkLabelForgotPassword;
        private PictureBox pictureBoxLogoEmpresa;
        private System.Windows.Forms.Timer timerInactividad;
    }
}
