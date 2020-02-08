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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
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
                Retroceso.Height = 46;
                Retroceso.Width = 44;
                BackButton.Visible = false;
               
            }
            else
            {
                Sidebar.Visible = true;
                Sidebar.Width = 176;
                SidebarWrapper.Width = 200;
                PanelChart.Width = 668;
                label2.Visible = true;
                Separador.Visible = true;
                Retroceso.Height = 30;
                Retroceso.Width = 35;
                BackButton.Visible = true;
             
            }
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
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


    }
}
