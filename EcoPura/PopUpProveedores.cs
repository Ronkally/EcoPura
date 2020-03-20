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
    public partial class Proveedores : MetroFramework.Forms.MetroForm
    {

        string proveedor;
        public Proveedores()
        {
            InitializeComponent();
            
           
        }




        private void tbAgregar_Enter(object sender, EventArgs e)
        {
            if(tbAgregar.Text.Equals("Agrega un proveedor") || tbAgregar.Text.Equals("Proveedor ya existe"))
            {
                tbAgregar.Text = "";
                tbAgregar.ForeColor = Color.Black;
            }
        }

        private void tbAgregar_Leave(object sender, EventArgs e)
        {
            if (tbAgregar.Text.Equals(""))
            {
                tbAgregar.Text = "Agrega un proveedor";
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
            string query = "Select Proveedor From Proveedor";
            GridProveedores.DataSource = DatabaseAccess.CargarTabla(query);
            GridProveedores.ClearSelection();
        }

        private void AgregarProveedor()
        {
            string query = $"Insert into Proveedor (Proveedor) values ('{tbAgregar.Text}')";
            DatabaseAccess.EjecutarConsulta(query);
        }


        private bool Validacion()
        {
            bool bandera = true;

            if (string.IsNullOrEmpty(tbAgregar.Text) || tbAgregar.Text.Equals("Agrega un proveedor") || tbAgregar.Text.Equals("Proveedor ya existe"))
            {
                bandera = false;
                tbAgregar.Text = "Agrega un proveedor";
                tbAgregar.ForeColor = Color.Red;
            }

            for(int i = 0; i < GridProveedores.RowCount; i++)
            {
                if (tbAgregar.Text.Equals(GridProveedores.Rows[i].Cells[0].Value.ToString()))
                {
                    bandera = false;
                    tbAgregar.Text = "Proveedor ya existe";
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
            if (GridProveedores.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas borrar este proveedor?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    string query = $"DELETE FROM PROVEEDOR WHERE Proveedor = '{GridProveedores.Rows[GridProveedores.CurrentCell.RowIndex].Cells[0].Value.ToString()}'";
                    DatabaseAccess.EjecutarConsulta(query);
                    Reload();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un proveedor de la tabla para eliminar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void GridProveedores_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrEmpty(GridProveedores.Rows[GridProveedores.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                GridProveedores.Rows[GridProveedores.CurrentCell.RowIndex].Cells[0].Value = proveedor;
            else
            {
                string query = $"UPDATE Proveedor SET Proveedor = '{GridProveedores.Rows[GridProveedores.CurrentCell.RowIndex].Cells[0].Value.ToString()}' WHERE Proveedor = '{proveedor}' ";
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
            proveedor = GridProveedores.Rows[GridProveedores.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
