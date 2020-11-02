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
    public partial class PopUpUsuario : MetroFramework.Forms.MetroForm
    {
        Boolean Actualizar = false;
        private string codigo;

        public PopUpUsuario()
        {
            InitializeComponent();
        }

        public PopUpUsuario(string codigo)
        {
            InitializeComponent();
            LlenarCampos(codigo);
            Actualizar = true;
            this.codigo = codigo;
        }

        private void LlenarCampos(string codigo)
        {
            string query = $@"SELECT IdUsuario, Nombre, Correo, Usuario, Rol.Rol, Estado, Contrasena
                             FROM Usuarios
                             LEFT JOIN Rol
                             ON Usuarios.Rol = Rol.Id
                             Where IdUsuario = {codigo}";

            DataTable da = DatabaseAccess.CargarTabla(query);

            tbNombre.Text = da.Rows[0][1].ToString();
            tbCorreo.Text = da.Rows[0][2].ToString();
            tbUsuario.Text = da.Rows[0][3].ToString();
            if (da.Rows[0][4].ToString() == "Administrador")
                cbTipo.SelectedIndex = 1;

            tbContrasena.Text = da.Rows[0][6].ToString();
            tbRContrasena.Text = da.Rows[0][6].ToString();
        }

        private void PopUpAgregarFondo_Load(object sender, EventArgs e)
        {
            cbTipo.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                if (!Actualizar)
                {
                    if (tbContrasena.Text != tbRContrasena.Text)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Las contraseñas no coinciden", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    GuardarUsuario();
                }
                else
                    ActualizarUsuario();

                this.Close();
            }
        }

        private bool Validacion()
        {
            bool bandera = true;

            if (tbNombre.Text.Equals("Ej. Juan") || tbNombre.Text.Equals("Ingresa un nombre") || Shared.InvalidString(tbNombre.Text))
            {
                tbNombre.Text = "Ingresa una descripción";
                tbNombre.ForeColor = Color.Red;
                bandera = false;
            }

            if (tbUsuario.Text.Equals("Ej. Juan64") || tbUsuario.Text.Equals("Ingresa un usuario") || Shared.InvalidString(tbUsuario.Text))
            {
                tbUsuario.Text = "Ingresa un código de barras, solo números";
                tbUsuario.ForeColor = Color.Red;
                bandera = false;
            }

            if (tbCorreo.Text.Equals("Ej. Alvaro@hotmail.com") || tbCorreo.Text.Equals("Ingresa un correo") || Shared.InvalidString(tbCorreo.Text))
            {
                tbCorreo.Text = "Ingresa un precio, solo números";
                tbCorreo.ForeColor = Color.Red;
                bandera = false;
            }

            if (tbContrasena.Text.Equals("Contrasena") || Shared.InvalidString(tbCorreo.Text))
            {
                tbContrasena.Text = "Ingresa un precio, solo números";
                tbContrasena.ForeColor = Color.Red;
                bandera = false;
            }

            if (tbRContrasena.Text.Equals("Contrasena") || Shared.InvalidString(tbCorreo.Text))
            {
                tbRContrasena.Text = "Ingresa un precio, solo números";
                tbRContrasena.ForeColor = Color.Red;
                bandera = false;
            }

            return bandera;
        }

        private void GuardarUsuario()
        {
            int rol = 2;

            if (cbTipo.Text == "Administrador")
                rol = 1;

            string query = $@"Insert into Usuarios 
                             (Usuario, Nombre, Contrasena, Correo, Rol, Estado)
                             Values ('{tbUsuario.Text}', '{tbNombre.Text}','{tbContrasena.Text}', '{tbCorreo.Text}', {rol}, 'Habilitado')";

            DatabaseAccess.EjecutarConsulta(query);
        }

        private void ActualizarUsuario()
        {
            int rol = 2;

            if (cbTipo.Text == "Administrador")
                rol = 1;


            string query = $@"UPDATE Usuarios
                              SET Usuario = '{tbUsuario.Text}', Nombre = '{tbNombre.Text}', Contrasena = '{tbContrasena.Text}', Correo = '{tbCorreo.Text}', Rol = {rol}
                              WHERE IdUsuario = {codigo}";

            DatabaseAccess.EjecutarConsulta(query);
        }

        #region PlaceHolders
        private void tbNombre_Enter(object sender, EventArgs e)
        {
            if (tbNombre.Text.Equals("Ej. Juan") || tbNombre.Text.Equals("Ingresa un nombre"))
            {
                tbNombre.Text = "";
                tbNombre.ForeColor = Color.Black;
            }
        }

        private void tbNombre_Leave(object sender, EventArgs e)
        {
            if (tbNombre.Text.Equals(""))
            {
                tbNombre.Text = "Ej. Juan";
                tbNombre.ForeColor = Color.Gray;
            }
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Equals("Ej. Juan64") || tbUsuario.Text.Equals("Ingresa un usuario"))
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.Black;
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Equals(""))
            {
                tbUsuario.Text = "Ej. Juan64";
                tbUsuario.ForeColor = Color.Gray;
            }
        }

        private void tbCorreo_Enter(object sender, EventArgs e)
        {
            if (tbCorreo.Text.Equals("Ej. Alvaro@hotmail.com") || tbCorreo.Text.Equals("Ingresa un correo"))
            {
                tbCorreo.Text = "";
                tbCorreo.ForeColor = Color.Black;
            }
        }

        private void tbCorreo_Leave(object sender, EventArgs e)
        {
            if (tbCorreo.Text.Equals(""))
            {
                tbCorreo.Text = "Ej. Alvaro@hotmail.com";
                tbCorreo.ForeColor = Color.Gray;
            }
        }

        private void tbContrasena_Enter(object sender, EventArgs e)
        {
            if (tbContrasena.Text.Equals("Contrasena"))
            {
                tbContrasena.Text = "";
                tbContrasena.ForeColor = Color.Black;
            }
        }

        private void tbContrasena_Leave(object sender, EventArgs e)
        {
            if (tbContrasena.Text.Equals(""))
            {
                tbContrasena.Text = "Contrasena";
                tbContrasena.ForeColor = Color.Gray;
            }
        }

        private void tbRContrasena_Enter(object sender, EventArgs e)
        {
            if (tbRContrasena.Text.Equals("Contrasena"))
            {
                tbRContrasena.Text = "";
                tbRContrasena.ForeColor = Color.Black;
            }
        }

        private void tbRContrasena_Leave(object sender, EventArgs e)
        {
            if (tbRContrasena.Text.Equals(""))
            {
                tbRContrasena.Text = "Contrasena";
                tbRContrasena.ForeColor = Color.Gray;
            }
        }
        #endregion
    }
}
