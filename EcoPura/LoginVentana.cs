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
            if (tbUsuario.Text.Equals("Usuario"))
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.Black;
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text.Equals(""))
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
    }
}
