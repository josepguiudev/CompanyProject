using ProyectoCompany.Classes;
using ProyectoCompany.ZComponents;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace ProyectoCompany
{
    public partial class Login : Form
    {
        Encrypt encript = new Encrypt();
        HttpRequests requests = new HttpRequests();
        User userLoged;
        public Login()
        {
            InitializeComponent();
            habilitarTimme();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakePictureBoxRound(pictureBoxLogoEmpresa);
            string fullPath = imagePath();
            LoadImage(fullPath);
            timerInactividad.Start();

            
            encript.comprobarSiHayArchivosAes();
        }
        #region "Form Behaviours"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
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
        #endregion
        #region "Timmer"
        private void habilitarTimme()
        {
            timerInactividad.Interval = 60000;    // 60 segundos
            timerInactividad.Enabled = true;      // Habilita el timer

        }

        private void timerInactividad_Tick(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            timerInactividad.Stop();
            timerInactividad.Start();
        }
        #endregion
        #region "Try get company logo"
        private void LoadImage(string path)
        {
            try
            {
                // Carga la imagen en el PictureBox
                pictureBoxLogoEmpresa.Image = Image.FromFile(path);
                pictureBoxLogoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta la imagen
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }
        #endregion
        #region "Get path from images"
        private static string imagePath()
        {
            // Obtener la ruta del directorio del proyecto
            string projectDirectory = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            // Ruta a la carpeta Images
            string relativePath = @"Images\logoempresa.jpg"; // Ruta relativa desde el directorio del proyecto
            string fullPath = Path.Combine(projectDirectory, relativePath); // Combinar rutas
            return fullPath;
        }
        #endregion
        #region "Clean Text"
        private void limpiarTextos()
        {
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
        }
        #endregion

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            String userName = textBoxUserName.Text;
            String userPassWord = textBoxPassword.Text;
            limpiarTextos();

            /*byte[] encrypted = encript.EncryptStringToBytes_Aes(userName);
            MessageBox.Show(Encoding.UTF8.GetString(encrypted));
            string decrypt = encript.DecryptStringFromBytes_Aes(encrypted);
            MessageBox.Show(decrypt);
            this.Hide();
            timerInactividad.Stop();*/


            User usuario = await requests.BuscarUsuarioPorEmail(userName);
            if (usuario != null)
            {
                string passWordEncoded = Convert.ToBase64String(encript.EncryptStringToBytes_Aes(userPassWord));
                if (passWordEncoded.Equals(usuario.Password))
                {   
                    userLoged = usuario;
                    MainApp mainApp = new MainApp(encript, userLoged);
                    mainApp.Show();
                    this.Hide();
                    timerInactividad.Stop();
                }
                else
                {
                    MessageBox.Show("Password incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Usuario o password incorrecto");
            }  
        }

    }
}
