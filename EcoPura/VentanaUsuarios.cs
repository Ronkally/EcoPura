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
    public partial class VentanaUsuarios : MetroFramework.Forms.MetroForm
    {
        public VentanaUsuarios()
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
            string query = @"SELECT IdUsuario, Nombre, Correo, Usuario, Rol.Rol, Estado
                             FROM Usuarios
                             LEFT JOIN Rol
                             ON Usuarios.Rol = Rol.Id";

            this.gridview.DataSource = DatabaseAccess.CargarTabla(query);
            gridview.ClearSelection();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var popUsuarios = new PopUpUsuario();
            popUsuarios.StartPosition = FormStartPosition.CenterParent;
            popUsuarios.ShowDialog();
            gridview.ClearSelection();
            CargarGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas deshabilitar este usuario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int selectedRowIndex = gridview.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = gridview.Rows[selectedRowIndex];
                    if ("Administrador" == selectedRow.Cells["Rol"].Value.ToString())
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Usuario no elegible", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string codigo = selectedRow.Cells["IdUsuario"].Value.ToString();
                    string query = $@"UPDATE USUARIOS SET Estado = 'Deshabilitado' WHERE IdUsuario = '{codigo}'";
                    DatabaseAccess.EjecutarConsulta(query);
                    gridview.ClearSelection();
                    CargarGridView();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un usuario de la tabla para deshabilitar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            if (gridview.SelectedRows.Count > 0)
            {
                int selectedRowIndex = gridview.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = gridview.Rows[selectedRowIndex];
                string codigo = selectedRow.Cells["IdUsuario"].Value.ToString();
                var popUpUsuario = new PopUpUsuario(codigo);
                popUpUsuario.StartPosition = FormStartPosition.CenterParent;
                popUpUsuario.ShowDialog();
                gridview.ClearSelection();
                CargarGridView();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un usuario de la tabla para modificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count > 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "¿Estás seguro que deseas habilitar este usuario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    int selectedRowIndex = gridview.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = gridview.Rows[selectedRowIndex];
                    if ("Administrador" == selectedRow.Cells["Rol"].Value.ToString())
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Usuario no elegible", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string codigo = selectedRow.Cells["IdUsuario"].Value.ToString();
                    string query = $@"UPDATE USUARIOS SET Estado = 'Habilitado' WHERE IdUsuario = '{codigo}'";
                    DatabaseAccess.EjecutarConsulta(query);
                    gridview.ClearSelection();
                    CargarGridView();
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un usuario de la tabla para habilitar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
