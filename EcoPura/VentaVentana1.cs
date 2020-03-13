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
    public partial class VentaVentana1 : MetroFramework.Forms.MetroForm
    {
        public VentaVentana1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            gridview.Width = 1130;
            gridview.Height = 500;
            panelSide.Height = 680;
            panelSB.Width = 300;
            btnBuscar.Location = new Point(490, 101);
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        FormWindowState LastWindowState = FormWindowState.Maximized;
        private void VentaVentana1_Resize(object sender, EventArgs e)
          {
                if (WindowState != LastWindowState)
                {
                    LastWindowState = WindowState;

                    if (WindowState == FormWindowState.Maximized)
                    {
                    gridview.Width = 1130;
                    gridview.Height = 500;
                    panelSide.Height = 680;
                }
                    if (WindowState == FormWindowState.Normal)
                    {
                        gridview.Width = 662;
                        gridview.Height = 335;
                        panelSide.Height = 491;
                    }
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

