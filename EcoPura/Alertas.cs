using EcoPuraLibreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoPura
{
    public partial class Alertas : MetroFramework.Forms.MetroForm
    {
        public Alertas()
        {
            InitializeComponent();
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WindowState = FormWindowState.Maximized;
        }

        private void VentanaProducto1_Load(object sender, EventArgs e)
        {
            CargarGridView();
        }

        private void CargarGridView()
        {
            string query = @"SELECT * FROM ALERTAS";

            this.gridview.DataSource = DatabaseAccess.CargarTabla(query);
            gridview.ClearSelection();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas resolver esta alerta?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int selectedRowIndex = gridview.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = gridview.Rows[selectedRowIndex];
                    string codigo = selectedRow.Cells["IdAlerta"].Value.ToString();
                    string query = $@"DELETE FROM Alertas WHERE IdAlerta = '{codigo}'";
                    DatabaseAccess.EjecutarConsulta(query);
                    gridview.ClearSelection();
                    CargarGridView();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona una alerta de la tabla para resolver", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProveedor_Click_1(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas resolver todas las alertas?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                string query = $@"DELETE FROM Alertas";
                DatabaseAccess.EjecutarConsulta(query);
                gridview.ClearSelection();
                CargarGridView();
            }
        }
    }
}
