namespace ProyectoCompany.ZComponents
{
    partial class AddUsers
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
            buttonAccept = new Button();
            buttonCancel = new Button();
            panelBtnAceptarCancelar = new Panel();
            panel1 = new Panel();
            buttonDelete = new Button();
            labelTittlePanelA = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBoxName = new TextBox();
            textBoxFirstSurname = new TextBox();
            textBoxSecondSurname = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxDni = new TextBox();
            label8 = new Label();
            checkBoxAdmin = new CheckBox();
            panel2 = new Panel();
            textBoxDefaultPassWord = new TextBox();
            labelPassword = new Label();
            checkBoxActive = new CheckBox();
            label10 = new Label();
            panel3 = new Panel();
            labelUserBd = new Label();
            buttonModificar = new Button();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            textBox7 = new TextBox();
            panelBtnAceptarCancelar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonAccept
            // 
            buttonAccept.FlatAppearance.BorderSize = 0;
            buttonAccept.FlatStyle = FlatStyle.Flat;
            buttonAccept.ForeColor = Color.Silver;
            buttonAccept.Location = new Point(292, 9);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(112, 34);
            buttonAccept.TabIndex = 0;
            buttonAccept.Text = "Aceptar";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.Silver;
            buttonCancel.Location = new Point(174, 9);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(112, 34);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // panelBtnAceptarCancelar
            // 
            panelBtnAceptarCancelar.BackColor = Color.FromArgb(30, 38, 70);
            panelBtnAceptarCancelar.Controls.Add(panel1);
            panelBtnAceptarCancelar.Dock = DockStyle.Bottom;
            panelBtnAceptarCancelar.Location = new Point(0, 707);
            panelBtnAceptarCancelar.Name = "panelBtnAceptarCancelar";
            panelBtnAceptarCancelar.Size = new Size(1273, 50);
            panelBtnAceptarCancelar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 38, 70);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonAccept);
            panel1.Controls.Add(buttonCancel);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(880, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 50);
            panel1.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.Silver;
            buttonDelete.Location = new Point(56, 9);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(112, 34);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // labelTittlePanelA
            // 
            labelTittlePanelA.AutoSize = true;
            labelTittlePanelA.ForeColor = Color.Silver;
            labelTittlePanelA.Location = new Point(3, 33);
            labelTittlePanelA.Name = "labelTittlePanelA";
            labelTittlePanelA.Size = new Size(205, 25);
            labelTittlePanelA.TabIndex = 3;
            labelTittlePanelA.Text = "Datos del nuevo usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 97);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 160);
            label3.Name = "label3";
            label3.Size = new Size(131, 25);
            label3.TabIndex = 5;
            label3.Text = "Primer apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 224);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 6;
            label4.Text = "Segundo apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 287);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 7;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 347);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 8;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 405);
            label7.Name = "label7";
            label7.Size = new Size(43, 25);
            label7.TabIndex = 9;
            label7.Text = "DNI";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(203, 94);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(308, 31);
            textBoxName.TabIndex = 11;
            // 
            // textBoxFirstSurname
            // 
            textBoxFirstSurname.Location = new Point(203, 157);
            textBoxFirstSurname.Name = "textBoxFirstSurname";
            textBoxFirstSurname.Size = new Size(308, 31);
            textBoxFirstSurname.TabIndex = 12;
            // 
            // textBoxSecondSurname
            // 
            textBoxSecondSurname.Location = new Point(203, 221);
            textBoxSecondSurname.Name = "textBoxSecondSurname";
            textBoxSecondSurname.Size = new Size(308, 31);
            textBoxSecondSurname.TabIndex = 13;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(203, 284);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(308, 31);
            textBoxPhone.TabIndex = 14;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(203, 344);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(308, 31);
            textBoxEmail.TabIndex = 15;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(203, 407);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(308, 31);
            textBoxDni.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 477);
            label8.Name = "label8";
            label8.Size = new Size(126, 25);
            label8.TabIndex = 17;
            label8.Text = "Administrador";
            // 
            // checkBoxAdmin
            // 
            checkBoxAdmin.AutoSize = true;
            checkBoxAdmin.Location = new Point(203, 476);
            checkBoxAdmin.Name = "checkBoxAdmin";
            checkBoxAdmin.Size = new Size(22, 21);
            checkBoxAdmin.TabIndex = 18;
            checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxDefaultPassWord);
            panel2.Controls.Add(labelPassword);
            panel2.Controls.Add(checkBoxActive);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBoxDni);
            panel2.Controls.Add(checkBoxAdmin);
            panel2.Controls.Add(labelTittlePanelA);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxEmail);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBoxPhone);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBoxSecondSurname);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBoxFirstSurname);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBoxName);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(639, 707);
            panel2.TabIndex = 19;
            // 
            // textBoxDefaultPassWord
            // 
            textBoxDefaultPassWord.Location = new Point(203, 658);
            textBoxDefaultPassWord.Name = "textBoxDefaultPassWord";
            textBoxDefaultPassWord.Size = new Size(308, 31);
            textBoxDefaultPassWord.TabIndex = 22;
            textBoxDefaultPassWord.Text = "123456";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(3, 656);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(183, 25);
            labelPassword.TabIndex = 21;
            labelPassword.Text = "Password Predefinido";
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Location = new Point(203, 529);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(22, 21);
            checkBoxActive.TabIndex = 20;
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 530);
            label10.Name = "label10";
            label10.Size = new Size(62, 25);
            label10.TabIndex = 19;
            label10.Text = "Activo";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(labelUserBd);
            panel3.Controls.Add(buttonModificar);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBox7);
            panel3.Location = new Point(671, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(602, 707);
            panel3.TabIndex = 20;
            // 
            // labelUserBd
            // 
            labelUserBd.AutoSize = true;
            labelUserBd.ForeColor = Color.Silver;
            labelUserBd.Location = new Point(3, 33);
            labelUserBd.Name = "labelUserBd";
            labelUserBd.Size = new Size(178, 25);
            labelUserBd.TabIndex = 16;
            labelUserBd.Text = "Usuarios Registrados";
            // 
            // buttonModificar
            // 
            buttonModificar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonModificar.FlatAppearance.BorderSize = 0;
            buttonModificar.FlatStyle = FlatStyle.Flat;
            buttonModificar.ForeColor = Color.Silver;
            buttonModificar.Location = new Point(490, 656);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(112, 34);
            buttonModificar.TabIndex = 15;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(45, 66, 91);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.SteelBlue;
            dataGridView1.Location = new Point(10, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Franklin Gothic Medium", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(577, 495);
            dataGridView1.TabIndex = 14;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(0, 97);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 12;
            label9.Text = "Nombre";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(84, 94);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(503, 31);
            textBox7.TabIndex = 13;
            // 
            // AddUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(1273, 757);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelBtnAceptarCancelar);
            Name = "AddUsers";
            Text = "AddUsers";
            Load += AddUsers_Load;
            panelBtnAceptarCancelar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAccept;
        private Button buttonCancel;
        private Panel panelBtnAceptarCancelar;
        private Label labelTittlePanelA;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxName;
        private TextBox textBoxFirstSurname;
        private TextBox textBoxSecondSurname;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxDni;
        private Label label8;
        private CheckBox checkBoxAdmin;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label9;
        private TextBox textBox7;
        private DataGridView dataGridView1;
        private CheckBox checkBoxActive;
        private Label label10;
        private Button buttonModificar;
        private Label labelUserBd;
        private TextBox textBoxDefaultPassWord;
        private Label labelPassword;
        private Button buttonDelete;
    }
}