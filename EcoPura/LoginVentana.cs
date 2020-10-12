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
            if (Validacion())
            {
                //select count(Id) from Project
                string query = $"Select count(Usuario) FROM Usuarios WHERE Usuario = '{tbUsuario.Text}' AND Contrasena = '{tbContrasena.Text}' ";
                bool DoesExist = DatabaseAccess.Existe(query);

                if (DoesExist)
                {
                    var Ventana = new InicioVentana2();
                    Ventana.StartPosition = FormStartPosition.CenterScreen;
                    Ventana.Show();
                    this.Close();
                }
                else
                {
                    tbUsuario.Text = "Ingresa un usuario válido";
                    tbUsuario.ForeColor = Color.Red;

                    tbContrasena.Text = "Ingresa una contraseña válida";
                    tbContrasena.ForeColor = Color.Red;
                }
                


            }
         

        }

        public bool Validacion()
        {
            bool bandera = true;


            if (string.IsNullOrEmpty(tbUsuario.Text) || tbUsuario.Text.Equals("Ingresa un usuario válido"))
            {
                tbUsuario.Text = "Ingresa un usuario válido";
                tbUsuario.ForeColor = Color.Red;
                bandera = false;
            }


            if (string.IsNullOrEmpty(tbContrasena.Text) || tbContrasena.Text.Equals("Ingresa una contraseña válida") )
            {
                tbContrasena.Text = "Ingresa una contraseña válida";
                tbContrasena.ForeColor = Color.Red;
                bandera = false;
            }


            return bandera;

        }
    }
}
