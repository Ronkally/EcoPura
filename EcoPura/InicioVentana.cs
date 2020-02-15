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
    public partial class InicioVentana : Form
    {
        public InicioVentana()
        {
            InitializeComponent();
        }
        int posY = 0;
        int posX = 0;
        private void MenuTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;

        }


        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void Minimizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
   

        private void PanelChart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            var inicio = new VentanaProducto();
            inicio.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }

        private void btnPuntoVenta_Click(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var inicio = new VentaVentana();
            inicio.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {

        }

        private void btnCotizaciones_Click(object sender, EventArgs e)
        {

        }
    }
}
