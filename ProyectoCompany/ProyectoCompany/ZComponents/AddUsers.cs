using ProyectoCompany.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompany.ZComponents
{
    public partial class AddUsers : Form
    {
        private Encrypt encrypt;
        bool isAdd = true;
        HttpRequests requests = new HttpRequests();
        User userloged;
        List<User> users;
        User userToModify;
        public AddUsers()
        {
            InitializeComponent();
        }
        public AddUsers(Encrypt x, User user)
        {
            InitializeComponent();
            encrypt = x;
            userloged = user;
        }
        private void AddUsers_Load(object sender, EventArgs e)
        {
            LoadTheme();
            //BORRAR Y PONER LOS DE BD
            CargarGridView();
        }

        private async void CargarGridView()
        {
            users = new List<User>();
            users = await requests.ObtenerUsuarios();
            dataGridView1.DataSource = users;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["password"].Visible = false;
            dataGridView1.Columns["name"].HeaderText = "Nombre";
            dataGridView1.Columns["firstSurname"].HeaderText = "Apellido";
            dataGridView1.Columns["secondSurname"].HeaderText = "Apellido";
            dataGridView1.Columns["phone"].HeaderText = "Tlfn";
            dataGridView1.Columns["isAdmin"].HeaderText = "Admin";
            dataGridView1.Columns["isActive"].HeaderText = "Activo";
            dataGridView1.Refresh();
        }

        private void LoadTheme()
        {
            foreach (Control btns in panel1.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColors.primaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.secondaryColor;
                }
            }
            labelTittlePanelA.ForeColor = ThemeColors.primaryColor;
            labelUserBd.ForeColor = ThemeColors.primaryColor;
            panel2.BackColor = Color.FromArgb(46, 59, 104);
            panel3.BackColor = Color.FromArgb(46, 59, 104);
            BackColor = ThemeColors.secondaryColor;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Convierte la fila en un objeto Persona
                User personaSeleccionada = (User)filaSeleccionada.DataBoundItem;

                // Utiliza el objeto como necesites
                MessageBox.Show(personaSeleccionada.ToString());
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            isAdd = false;
            labelTittlePanelA.Text = "Modificación del usuario";
            userToModify = Selectuser();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cleanTexts();
            labelTittlePanelA.Text = "Datos del nuevo usuario";
            isAdd = true;
            userToModify = null;
        }

        private User Selectuser()
        {
            User user = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0];
                // Crear un objeto Producto a partir de los valores de la fila
                User userSeleccionado = (User)filaSeleccionada.DataBoundItem;
                if (userSeleccionado.Id != 1 || userloged.Id == 1)
                {
                    // Poner en los textBox
                    textBoxName.Text = userSeleccionado.Name;
                    textBoxFirstSurname.Text = userSeleccionado.FirstSurname;
                    textBoxSecondSurname.Text = userSeleccionado.SecondSurname;
                    textBoxPhone.Text = userSeleccionado.Phone;
                    textBoxEmail.Text = userSeleccionado.Email;
                    textBoxDni.Text = userSeleccionado.Dni;
                    checkBoxAdmin.Checked = userSeleccionado.IsAdmin;
                    checkBoxActive.Checked = userSeleccionado.IsActive;

                    byte[] byteArray = Convert.FromBase64String(userSeleccionado.Password);
                    textBoxDefaultPassWord.Text = encrypt.DecryptStringFromBytes_Aes(byteArray);
                    user = userSeleccionado;
                }
                else
                {
                    labelTittlePanelA.Text = "Datos del nuevo usuario";
                    cleanTexts();
                    MessageBox.Show("Este es el usuario prinicpal del sistema, NO se puede modificar.");
                    isAdd = true;
                    user = null;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }
            return user;
        }

        private void cleanTexts()
        {
            textBoxName.Text = "";
            textBoxFirstSurname.Text = "";
            textBoxSecondSurname.Text = "";
            textBoxPhone.Text = "";
            textBoxEmail.Text = "";
            textBoxDni.Text = "";
            checkBoxAdmin.Checked = false;
            checkBoxActive.Checked = false;
            textBoxDefaultPassWord.Text = "123456";
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            labelTittlePanelA.Text = "Modificación del usuario";
            isAdd = false;
            userToModify = Selectuser();
        }

        private async void buttonAccept_Click(object sender, EventArgs e)
        {
            labelTittlePanelA.Text = "Datos del nuevo usuario";
            if (isAdd)
            {
                string passwordToSave = Convert.ToBase64String(encrypt.EncryptStringToBytes_Aes(textBoxDefaultPassWord.Text));
                UserToSend usuarioNuevo = new UserToSend(textBoxName.Text, textBoxFirstSurname.Text,
                    textBoxSecondSurname.Text, textBoxPhone.Text, textBoxEmail.Text,
                    textBoxDni.Text, checkBoxAdmin.Checked, checkBoxActive.Checked,
                    passwordToSave);
                doPost(usuarioNuevo);
            }
            else
            {
                UserToSend userModified = new UserToSend(
                    textBoxName.Text, textBoxFirstSurname.Text, textBoxSecondSurname.Text,
                    textBoxPhone.Text, textBoxEmail.Text, textBoxDni.Text,
                    checkBoxAdmin.Checked, checkBoxActive.Checked,
                    Convert.ToBase64String(encrypt.EncryptStringToBytes_Aes(textBoxDefaultPassWord.Text))
                    );

                doPut(userModified, userToModify.Id);

                userToModify = null;
                isAdd = true;
            }
            CargarGridView();
        }

        private async void doPost(UserToSend user)
        {
            await requests.CrearUsuario(user);
        }
        private async void doPut(UserToSend user, int id)
        {
            await requests.ActualizarUsuario(user, id);
        }
        private async void doDelete(User user)
        {
            await requests.EliminarUsuario(user);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (userToModify != null) { 
                doDelete(userToModify);
                userToModify = null;
                isAdd = true;
                cleanTexts();
                CargarGridView();
            }
        }
    }
}
