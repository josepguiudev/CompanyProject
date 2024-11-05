namespace ProyectoCompany.ZComponents
{
    partial class MainApp
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
            components = new System.ComponentModel.Container();
            panelBotonera = new Panel();
            panelBotones = new Panel();
            buttonAdmin = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            labelEmail = new Label();
            labelUserFullName = new Label();
            panel3 = new Panel();
            pictureBoxUser = new PictureBox();
            labelCompany = new Label();
            TittleBar = new Panel();
            panel5 = new Panel();
            pictureBoxMinimize = new PictureBox();
            pictureBoxClose = new PictureBox();
            pictureBoxMaximize = new PictureBox();
            panelTittleCategory = new Panel();
            pictureBoxCloseChildForm = new PictureBox();
            labelTittle = new Label();
            panelDesktop = new Panel();
            labelDia = new Label();
            labelHora = new Label();
            horaFecha = new System.Windows.Forms.Timer(components);
            panelBotonera.SuspendLayout();
            panelBotones.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).BeginInit();
            TittleBar.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaximize).BeginInit();
            panelTittleCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotonera
            // 
            panelBotonera.BackColor = Color.FromArgb(30, 38, 70);
            panelBotonera.Controls.Add(panelBotones);
            panelBotonera.Controls.Add(labelEmail);
            panelBotonera.Controls.Add(panel3);
            panelBotonera.Dock = DockStyle.Left;
            panelBotonera.Location = new Point(0, 0);
            panelBotonera.Name = "panelBotonera";
            panelBotonera.Padding = new Padding(10, 0, 10, 0);
            panelBotonera.Size = new Size(205, 900);
            panelBotonera.TabIndex = 0;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(30, 38, 70);
            panelBotones.Controls.Add(buttonAdmin);
            panelBotones.Controls.Add(button4);
            panelBotones.Controls.Add(button3);
            panelBotones.Controls.Add(button2);
            panelBotones.Controls.Add(button1);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(10, 560);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(185, 340);
            panelBotones.TabIndex = 4;
            // 
            // buttonAdmin
            // 
            buttonAdmin.Dock = DockStyle.Bottom;
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.ForeColor = Color.Silver;
            buttonAdmin.Location = new Point(0, 288);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(185, 52);
            buttonAdmin.TabIndex = 4;
            buttonAdmin.Text = "Opciones Admin";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click_1;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Silver;
            button4.Location = new Point(0, 156);
            button4.Name = "button4";
            button4.Size = new Size(185, 52);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Silver;
            button3.Location = new Point(0, 104);
            button3.Name = "button3";
            button3.Size = new Size(185, 52);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Silver;
            button2.Location = new Point(0, 52);
            button2.Name = "button2";
            button2.Size = new Size(185, 52);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(185, 52);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.ForeColor = Color.Silver;
            labelEmail.Location = new Point(13, 228);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(54, 25);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email";
            // 
            // labelUserFullName
            // 
            labelUserFullName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelUserFullName.AutoSize = true;
            labelUserFullName.ForeColor = Color.Silver;
            labelUserFullName.Location = new Point(3, 192);
            labelUserFullName.Name = "labelUserFullName";
            labelUserFullName.Size = new Size(168, 25);
            labelUserFullName.TabIndex = 2;
            labelUserFullName.Text = "Nombre y apellidos";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(30, 38, 70);
            panel3.Controls.Add(pictureBoxUser);
            panel3.Controls.Add(labelCompany);
            panel3.Controls.Add(labelUserFullName);
            panel3.Location = new Point(10, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(185, 376);
            panel3.TabIndex = 0;
            // 
            // pictureBoxUser
            // 
            pictureBoxUser.Image = Properties.Resources.empresa_freepik;
            pictureBoxUser.Location = new Point(33, 51);
            pictureBoxUser.Name = "pictureBoxUser";
            pictureBoxUser.Size = new Size(120, 120);
            pictureBoxUser.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUser.TabIndex = 1;
            pictureBoxUser.TabStop = false;
            pictureBoxUser.Paint += pictureBoxUser_Paint;
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCompany.ForeColor = Color.Silver;
            labelCompany.Location = new Point(45, 9);
            labelCompany.MaximumSize = new Size(117, 25);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(105, 25);
            labelCompany.TabIndex = 0;
            labelCompany.Text = "COMPANY";
            // 
            // TittleBar
            // 
            TittleBar.BackColor = Color.FromArgb(30, 38, 70);
            TittleBar.Controls.Add(panel5);
            TittleBar.Dock = DockStyle.Top;
            TittleBar.Location = new Point(205, 0);
            TittleBar.Name = "TittleBar";
            TittleBar.Size = new Size(1295, 30);
            TittleBar.TabIndex = 1;
            TittleBar.MouseDown += TittleBar_MouseDown;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBoxMinimize);
            panel5.Controls.Add(pictureBoxClose);
            panel5.Controls.Add(pictureBoxMaximize);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(1116, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(179, 30);
            panel5.TabIndex = 6;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Image = Properties.Resources.minimizar_ventana;
            pictureBoxMinimize.Location = new Point(101, 4);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(20, 20);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMinimize.TabIndex = 5;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Image = Properties.Resources.cerrar_ventana;
            pictureBoxClose.Location = new Point(153, 4);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(20, 20);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxClose.TabIndex = 3;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            // 
            // pictureBoxMaximize
            // 
            pictureBoxMaximize.Image = Properties.Resources.redimensionar;
            pictureBoxMaximize.Location = new Point(127, 4);
            pictureBoxMaximize.Name = "pictureBoxMaximize";
            pictureBoxMaximize.Size = new Size(20, 20);
            pictureBoxMaximize.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMaximize.TabIndex = 4;
            pictureBoxMaximize.TabStop = false;
            pictureBoxMaximize.Click += pictureBoxMaximize_Click;
            // 
            // panelTittleCategory
            // 
            panelTittleCategory.BackColor = Color.FromArgb(0, 150, 136);
            panelTittleCategory.Controls.Add(pictureBoxCloseChildForm);
            panelTittleCategory.Controls.Add(labelTittle);
            panelTittleCategory.Dock = DockStyle.Top;
            panelTittleCategory.Location = new Point(205, 30);
            panelTittleCategory.Name = "panelTittleCategory";
            panelTittleCategory.Size = new Size(1295, 57);
            panelTittleCategory.TabIndex = 3;
            // 
            // pictureBoxCloseChildForm
            // 
            pictureBoxCloseChildForm.Image = Properties.Resources.boton_cerrar;
            pictureBoxCloseChildForm.Location = new Point(8, 8);
            pictureBoxCloseChildForm.Name = "pictureBoxCloseChildForm";
            pictureBoxCloseChildForm.Size = new Size(40, 40);
            pictureBoxCloseChildForm.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCloseChildForm.TabIndex = 1;
            pictureBoxCloseChildForm.TabStop = false;
            pictureBoxCloseChildForm.Click += pictureBoxCloseChildForm_Click;
            // 
            // labelTittle
            // 
            labelTittle.Anchor = AnchorStyles.None;
            labelTittle.AutoSize = true;
            labelTittle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTittle.ForeColor = Color.Silver;
            labelTittle.Location = new Point(597, 12);
            labelTittle.Name = "labelTittle";
            labelTittle.Size = new Size(83, 32);
            labelTittle.TabIndex = 0;
            labelTittle.Text = "HOME";
            // 
            // panelDesktop
            // 
            panelDesktop.Controls.Add(labelDia);
            panelDesktop.Controls.Add(labelHora);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(205, 87);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1295, 813);
            panelDesktop.TabIndex = 4;
            // 
            // labelDia
            // 
            labelDia.AutoSize = true;
            labelDia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDia.ForeColor = Color.Silver;
            labelDia.Location = new Point(998, 741);
            labelDia.Name = "labelDia";
            labelDia.Size = new Size(225, 32);
            labelDia.TabIndex = 1;
            labelDia.Text = "Dom, 23 september";
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHora.ForeColor = Color.White;
            labelHora.Location = new Point(1044, 689);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(131, 38);
            labelHora.TabIndex = 0;
            labelHora.Text = "XX:XX:XX";
            // 
            // horaFecha
            // 
            horaFecha.Enabled = true;
            horaFecha.Tick += horaFecha_Tick;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(1500, 900);
            Controls.Add(panelDesktop);
            Controls.Add(panelTittleCategory);
            Controls.Add(TittleBar);
            Controls.Add(panelBotonera);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainApp";
            Text = "MainApp";
            panelBotonera.ResumeLayout(false);
            panelBotonera.PerformLayout();
            panelBotones.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUser).EndInit();
            TittleBar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMaximize).EndInit();
            panelTittleCategory.ResumeLayout(false);
            panelTittleCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotonera;
        private Panel TittleBar;
        private Panel panel3;
        private PictureBox pictureBoxMinimize;
        private PictureBox pictureBoxMaximize;
        private PictureBox pictureBoxClose;
        private Label labelCompany;
        private Label labelUserFullName;
        private Label labelEmail;
        private Panel panelBotones;
        private Button buttonAdmin;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel5;
        private Panel panelTittleCategory;
        private Label labelTittle;
        private Panel panelDesktop;
        private PictureBox pictureBoxCloseChildForm;
        private Label labelDia;
        private Label labelHora;
        private System.Windows.Forms.Timer horaFecha;
        private PictureBox pictureBoxUser;
    }
}