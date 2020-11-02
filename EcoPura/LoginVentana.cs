using EcoPuraLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoPura
{
    public partial class LoginVentana : MetroFramework.Forms.MetroForm
    {
        public LoginVentana()
        {
            InitializeComponent();
            tbUsuario.Select();
        }


        //Placeholders
        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Equals("Usuario") || tbUsuario.Text.Equals("Ingresa un usuario válido"))
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.Black;
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Equals("") || tbContrasena.Text.Equals("Ingresa una contraseña válida"))
            {
                tbUsuario.Text = "Usuario";
                tbUsuario.ForeColor = Color.Gray;
            }
        }

        private void tbContrasena_Enter(object sender, EventArgs e)
        {
            if (tbContrasena.Text.Equals("Contraseña"))
            {
                tbContrasena.Text = "";
                tbContrasena.ForeColor = Color.Black;
            }
        }

        private void tbContrasena_Leave(object sender, EventArgs e)
        {
            if (tbContrasena.Text.Equals(""))
            {
                tbContrasena.Text = "Contraseña";
                tbContrasena.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        public bool Validacion()
        {
            bool bandera = true;

            if (string.IsNullOrEmpty(tbUsuario.Text) || tbUsuario.Text.Equals("Usuario"))
            {
                bandera = false;
            }

            if (string.IsNullOrEmpty(tbContrasena.Text) || tbContrasena.Text.Equals("Contraseña"))
            {
                bandera = false;
            }

            if (!bandera)
                MetroFramework.MetroMessageBox.Show(this, "Por favor verifique que los campos estén llenos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return bandera;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void Login()
        {
            if (Validacion())
            {
                //select count(Id) from Project
                string query = $"Select * FROM Usuarios WHERE Usuario = '{tbUsuario.Text}' AND Contrasena = '{tbContrasena.Text}' AND Estado = 'Habilitado'";
                var user = DatabaseAccess.CargarTabla(query);

                if (user.Rows.Count > 0)
                {
                    var currentUser = new User(user);

                    var Ventana = new InicioVentana(currentUser);
                    Ventana.StartPosition = FormStartPosition.CenterScreen;
                    Hide();
                    Ventana.ShowDialog();
                    Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "No se encontró el usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
