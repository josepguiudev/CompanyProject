using ProyectoCompany.Classes;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace ProyectoCompany.ZComponents
{
    public partial class MainApp : Form
    {
        bool ismaximize = true;
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private Encrypt encrypt;
        Color borderColor = Color.FromArgb(0, 150, 136);
        private User userLoged;

        public MainApp()
        {
            Inicializador();
        }

        public MainApp(Encrypt x, User user)
        {
            Inicializador();
            encrypt = x;
            MakePictureBoxRound(pictureBoxUser);
            userLoged = user;
            labelUserFullName.Text = userLoged.Name + " " + userLoged.FirstSurname + " " + userLoged.SecondSurname;
            labelEmail.Text = userLoged.Email;
        }

        private void Inicializador()
        {
            InitializeComponent();
            random = new Random();
            pictureBoxCloseChildForm.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTittle.Text = childForm.Text;
        }

        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    borderColor = color;
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    //El valor debe ser (0.1, 0.05, -0.1, 0.3)
                    panelTittleCategory.BackColor = ThemeColors.ChangeColorBrightness(color, 0.1);
                    labelTittle.Text = currentButton.Text;
                    ThemeColors.primaryColor = color;
                    ThemeColors.secondaryColor = ThemeColors.ChangeColorBrightness(color, -0.1);
                    pictureBoxCloseChildForm.Visible = true;

                    // Forzar el repintado de pictureBoxUser
                    pictureBoxUser.Invalidate();
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelBotones.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(30, 38, 70);
                    previousBtn.ForeColor = Color.Silver;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }

        #region "Form Behaviours"

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMaximize_Click(object sender, EventArgs e)
        {
            if (ismaximize)
            {
                this.WindowState = FormWindowState.Maximized;
                ismaximize = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                ismaximize = true;
            }
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
        #region "Drag Forms"
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        private void TittleBar_MouseDown(object? sender, MouseEventArgs e)
        {
            TittleBar.MouseDown += new MouseEventHandler(TittleBar_MouseDown);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion
        #region "Round picture"
        private void MakePictureBoxRound(PictureBox pb)
        {
            pb.SizeMode = PictureBoxSizeMode.StretchImage;  // Ajusta la imagen
            pb.BackColor = Color.Transparent;               // Color de fondo transparente

            // Crear un nuevo objeto de región que define la forma redonda
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pb.Width, pb.Height);
            pb.Region = new Region(path);
        }
        private void pictureBoxUser_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                // Dibujar el borde
                using (Pen pen = new Pen(borderColor, 10)) // Borde de color rojo y grosor 5
                {
                    // Dibujar un círculo (el tamaño se ajusta al tamaño del PictureBox)
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawEllipse(pen, 0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
                }

                // Dibujar la imagen dentro del círculo (recortando)
                using (GraphicsPath path = new GraphicsPath())
                {
                    // Definir el contorno del círculo
                    path.AddEllipse(0, 0, pictureBox.Width - 1, pictureBox.Height - 1);
                    pictureBox.Region = new Region(path); // Establecer la región para recortar la imagen dentro del círculo
                }
            }
        }
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void buttonAdmin_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ZComponents.AddUsers(encrypt, userLoged), sender);
        }

        private void pictureBoxCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                borderColor = Color.FromArgb(0, 150, 136);
                pictureBoxUser.Invalidate();
            }
            reset();
        }

        private void reset()
        {
            DisableButton();
            labelTittle.Text = "HOME";
            panelTittleCategory.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            pictureBoxCloseChildForm.Visible = false;
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelDia.Text = DateTime.Now.ToString("dddd MMMM yyy").ToUpper();
        }
    }
}
