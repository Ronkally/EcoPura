using EcoPuraLibreria;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace EcoPura
{
    public partial class PuntoVentaVentana2 : MetroFramework.Forms.MetroForm
    {
        
        DataTable Productos ;
        public PuntoVentaVentana2()
        {
            InitializeComponent();
            gridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WindowState = FormWindowState.Maximized;
            gridview.Width = 955;
            gridview.Height = 500;
            panelSide.Height = 680;
            this.ActiveControl = labelP;
            


        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        FormWindowState LastWindowState = FormWindowState.Maximized;
        private void PuntoVentaVentana2_Resize(object sender, EventArgs e)
        {
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;

                if (WindowState == FormWindowState.Maximized)
                {
                    gridview.Width = 955;
                    gridview.Height = 500;
                    panelSide.Height = 680;
                }
                if (WindowState == FormWindowState.Normal)
                {
                    gridview.Width = 490;
                    gridview.Height = 324;
                    panelSide.Height = 490;
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(gridview.SelectedRows.Count > 0)
            {
                int cantidad = Int32.Parse(gridview.Rows[gridview.CurrentRow.Index].Cells["Cantidad"].Value.ToString());
                cantidad++;

                float precio = float.Parse(gridview.Rows[gridview.CurrentRow.Index].Cells["Precio"].Value.ToString());

                float importe = cantidad * precio;

                gridview.Rows[gridview.CurrentRow.Index].Cells["Cantidad"].Value = cantidad.ToString();
                gridview.Rows[gridview.CurrentRow.Index].Cells["Importe"].Value = importe.ToString();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un producto para aumentar su cantidad", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
            
            }
            Total();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void AgregarProducto()
        {
            bool bandera = false; 

            for(int i = 0; i < Productos.Rows.Count; i++)
            {
                if (tbSearchBox.Text.Equals(Productos.Rows[i]["Código"].ToString()))
                {

                    for(int j = 0; j < gridview.Rows.Count; j++)
                    {
                        if (tbSearchBox.Text.Equals(gridview.Rows[j].Cells["Código"].Value.ToString()))
                        {
                            int cantidad = Int32.Parse(gridview.Rows[j].Cells["Cantidad"].Value.ToString());
                            cantidad++;

                            float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());

                            float importe = cantidad * precio;

                            gridview.Rows[j].Cells["Cantidad"].Value = cantidad.ToString();
                            gridview.Rows[j].Cells["Importe"].Value = importe.ToString();

                            bandera = true;
                            break;
                        }
                    }

                    if (!bandera)
                    {
                        string[] newRow = new string[] {
                        Productos.Rows[i]["Código"].ToString(),
                        Productos.Rows[i]["Descripción"].ToString(),
                        Productos.Rows[i]["Precio"].ToString(),
                        "1",
                        Productos.Rows[i]["Precio"].ToString()};
                        gridview.Rows.Add(newRow);
                        break;
                    }
                    
                }
            }
            Total();
            gridview.ClearSelection();
        }

        private void tbSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AgregarProducto();
            }
        }

        private void PuntoVentaVentana2_Load(object sender, EventArgs e)
        {
            string query = $@"Select codigo as Código, Descripcion as Descripción, Precio
                          FROM Productos";
            Productos = DatabaseAccess.CargarTabla(query);

            gridview.Columns["Precio"].DefaultCellStyle.Format = "c";
            gridview.Columns["Precio"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-MX");

            gridview.Columns["Importe"].DefaultCellStyle.Format = "c";
            gridview.Columns["Importe"].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("es-MX");

            gridview.Columns[0].ReadOnly = true;
            gridview.Columns[1].ReadOnly = true;
            gridview.Columns[2].ReadOnly = true;
            gridview.Columns[4].ReadOnly = true;
            int cero = 0;
            labelP.Text = cero.ToString("C2", CultureInfo.GetCultureInfo("es-MX"));
        }

        private void tbSearchBox_Enter(object sender, EventArgs e)
        {
            if(tbSearchBox.Text.Equals("Código de barras"))
            {
                tbSearchBox.Text = "";
                tbSearchBox.ForeColor = Color.Black;
            }
        }

        private void tbSearchBox_Leave(object sender, EventArgs e)
        {
            if (tbSearchBox.Text.Equals(""))
            {
                tbSearchBox.Text = "Código de barras";
                tbSearchBox.ForeColor = Color.Gray;
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {

            gridview.Rows.Clear();
            Total();
        }

        private void btnBorrarUltimo_Click(object sender, EventArgs e)
        {
            if (gridview.SelectedRows.Count > 0)
            {
                DataGridViewRow row = gridview.Rows[gridview.CurrentRow.Index];

                gridview.Rows.Remove(row);
                Total();
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Por favor selecciona un producto para borrar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        private void PuntoVentaVentana2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i;
            if (int.TryParse(e.KeyChar.ToString(), out i))
            {
                tbSearchBox.Focus();
            }
        }

        private void PuntoVentaVentana2_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnGarrafon20L_Click(object sender, EventArgs e)
        {
            if(!DoesRowExist("Garrafón 20L"))
            {
                string[] garrafon = new string[] { "", "Garrafón 20L", "11", "1", "11" };
                gridview.Rows.Add(garrafon);
            }
            Total();
            gridview.ClearSelection();
        }

        private bool DoesRowExist(string descripcion)
        {
            bool bandera = false; 
            for (int j = 0; j < gridview.Rows.Count; j++)
            {
                if (descripcion.Equals(gridview.Rows[j].Cells["Descripción"].Value.ToString()))
                {
                    int cantidad = Int32.Parse(gridview.Rows[j].Cells["Cantidad"].Value.ToString());
                    cantidad++;

                    float precio = float.Parse(gridview.Rows[j].Cells["Precio"].Value.ToString());

                    float importe = cantidad * precio;

                    gridview.Rows[j].Cells["Cantidad"].Value = cantidad.ToString();
                    gridview.Rows[j].Cells["Importe"].Value = importe.ToString();
                    
                    bandera = true;
                    break;
                }
            }
            
            return bandera;
        }

        public void Total()
        {
            float total = 0;

            foreach (DataGridViewRow rows in gridview.Rows)
            {
                total += float.Parse(rows.Cells[4].Value.ToString());

            }
            labelP.Text = total.ToString("C2", CultureInfo.CreateSpecificCulture("es-MX"));
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            if(gridview.Rows.Count > 0)
            {
                string converter = labelP.Text;
                float total = float.Parse(converter.Replace("$",""));

                var cambio = new CambioVentana1(total);
                cambio.StartPosition = FormStartPosition.CenterParent;
                cambio.ShowDialog();


            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Agrega productos para realizar una venta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
