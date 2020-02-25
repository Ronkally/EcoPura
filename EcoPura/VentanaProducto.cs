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
    public partial class VentanaProducto : Form
    {
        public VentanaProducto()
        {
            InitializeComponent();
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width == 176)
            {
                Sidebar.Visible = true;
                Sidebar.Width = 68;
                SidebarWrapper.Width = 90;
                PanelChart.Width = 750;
                label2.Visible = false;
                Separador.Visible = false;
             
               
            }
            else
            {
                Sidebar.Visible = true;
                Sidebar.Width = 176;
                SidebarWrapper.Width = 200;
                PanelChart.Width = 668;
                label2.Visible = true;
                Separador.Visible = true;
               
             
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
