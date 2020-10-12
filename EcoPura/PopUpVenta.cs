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
    public partial class PopUpVenta : MetroFramework.Forms.MetroForm
    {
        public PopUpVenta()
        {
            InitializeComponent();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbMinimo_TextChanged(object sender, EventArgs e)
        {
            if (tbPrecio.Text.Equals("Ej. 50"))
            {
                tbPrecio.Text = "1";
            }
        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {
            if (tbMinimo.Text.Equals("Ej. 5"))
            {
                tbMinimo.Text = "1";
            }
        }

        private void Multiplicar()
        {
            int precio = int.Parse(tbPrecio.Text);
            int cantidad = int.Parse(tbMinimo.Text);

            tbMaximo.Text = (precio * cantidad).ToString();
        }

        private void tbPrecio_Enter(object sender, EventArgs e)
        {
            if (tbPrecio.Text.Equals("Ej. 50") || tbBarras.Text.Equals("Ingresa un precio valido, solo números"))
            {
                tbPrecio.Text = "";
                tbPrecio.ForeColor = Color.Black;
            }
        }

        private void tbPrecio_Leave(object sender, EventArgs e)
        {
            if (tbPrecio.Text.Equals(""))
            {
                tbPrecio.Text = "Ej. 50";
                tbPrecio.ForeColor = Color.Gray;
            }
        }
    }
}
