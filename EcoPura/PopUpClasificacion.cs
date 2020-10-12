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
    public partial class PopUpClasificacion : MetroFramework.Forms.MetroForm
    {

        string proveedor;
        public PopUpClasificacion()
        {
            InitializeComponent();

            //GridProveedores.Rows.Add("Pepsico");

        }




        private void tbAgregar_Enter(object sender, EventArgs e)
        {
            if (tbAgregar.Text.Equals("Agrega una clasificación") || tbAgregar.Text.Equals("Clasificación ya existe"))
            {
                tbAgregar.Text = "";
                tbAgregar.ForeColor = Color.Black;
            }
        }

        private void tbAgregar_Leave(object sender, EventArgs e)
        {
            if (tbAgregar.Text.Equals(""))
            {
                tbAgregar.Text = "Agrega una clasificación";
                tbAgregar.ForeColor = Color.Gray;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                AgregarProveedor();
                Reload();
            }
        }

        private void Reload()
        {
            string query = "Select Clasificacion as Clasificación From Clasificacion Where clasificacion != 'Agua'";
            GridClasificacion.DataSource = DatabaseAccess.CargarTabla(query);
            GridClasificacion.ClearSelection();
            tbAgregar.Text = "";
        }

        private void AgregarProveedor()
        {
            string query = $"Insert into Clasificacion (Clasificacion) values ('{tbAgregar.Text}')";
            DatabaseAccess.EjecutarConsulta(query);
        }


        private bool Validacion()
        {
            bool bandera = true;

            if (string.IsNullOrEmpty(tbAgregar.Text) || tbAgregar.Text.Equals("Agrega una clasificación") || tbAgregar.Text.Equals("Clasificación ya existe"))
            {
                bandera = false;
                tbAgregar.Text = "Agrega una clasificación";
                tbAgregar.ForeColor = Color.Red;
            }

            for (int i = 0; i < GridClasificacion.RowCount; i++)
            {
                if (tbAgregar.Text.Equals(GridClasificacion.Rows[i].Cells[0].Value.ToString()))
                {
                    bandera = false;
                    tbAgregar.Text = "Clasificación ya existe";
                    tbAgregar.ForeColor = Color.Red;
                    break;
                }
            }



            return bandera;

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            Reload();
            this.ActiveControl = pictureBox1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GridClasificacion.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas borrar esta Clasificación?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    string query = $"DELETE FROM Clasificacion WHERE Clasificacion = '{GridClasificacion.Rows[GridClasificacion.CurrentCell.RowIndex].Cells[0].Value.ToString()}' AND Clasificacion != 'Dulces' ";
                    DatabaseAccess.EjecutarConsulta(query);
                    Reload();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona una clasificación de la tabla para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void GridProveedores_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(GridClasificacion.Rows[GridClasificacion.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                GridClasificacion.Rows[GridClasificacion.CurrentCell.RowIndex].Cells[0].Value = proveedor;
            else
            {
                string query = $"UPDATE Clasificacion SET Clasificacion = '{GridClasificacion.Rows[GridClasificacion.CurrentCell.RowIndex].Cells[0].Value.ToString()}' WHERE Clasificacion = '{proveedor}' ";
                DatabaseAccess.EjecutarConsulta(query);
            }

        }

        private void GridProveedores_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /* if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                 e.Cancel = true;*/
        }

        private void GridProveedores_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            proveedor = GridClasificacion.Rows[GridClasificacion.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
