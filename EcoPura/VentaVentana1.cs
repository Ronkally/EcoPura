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
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearchBox_Enter(object sender, EventArgs e)
        {
            if (tbSearchBox.Text.Equals("Busqueda"))
            {
                tbSearchBox.Text = "";
                tbSearchBox.ForeColor = Color.Black;
            }
        }

        private void tbSearchBox_Leave(object sender, EventArgs e)
        {
            if (tbSearchBox.Text.Equals(""))
            {
                tbSearchBox.Text = "Busqueda";
                tbSearchBox.ForeColor = Color.Gray;
            }
        }
    }
    }

