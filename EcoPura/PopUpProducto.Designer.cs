namespace EcoPura
{
    partial class PopUpProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbMinimo = new System.Windows.Forms.TextBox();
            this.tbExistencia = new System.Windows.Forms.TextBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.cbClasificacion = new System.Windows.Forms.ComboBox();
            this.tbBarras = new System.Windows.Forms.TextBox();
            this.tbMaximo = new System.Windows.Forms.TextBox();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbDescripcioon = new System.Windows.Forms.TextBox();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblBarras = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.MenuTopp = new System.Windows.Forms.Panel();
            this.lblTituloVentana = new System.Windows.Forms.Label();
            this.lblIconoVentana = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.MenuTopp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblIconoVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.pbIcono);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.tbMinimo);
            this.panel1.Controls.Add(this.tbExistencia);
            this.panel1.Controls.Add(this.cbProveedor);
            this.panel1.Controls.Add(this.cbClasificacion);
            this.panel1.Controls.Add(this.tbBarras);
            this.panel1.Controls.Add(this.tbMaximo);
            this.panel1.Controls.Add(this.tbCosto);
            this.panel1.Controls.Add(this.tbPrecio);
            this.panel1.Controls.Add(this.tbDescripcioon);
            this.panel1.Controls.Add(this.lblClasificacion);
            this.panel1.Controls.Add(this.lblMinimo);
            this.panel1.Controls.Add(this.lblMaximo);
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Controls.Add(this.lblCosto);
            this.panel1.Controls.Add(this.lblExistencia);
            this.panel1.Controls.Add(this.lblPrecio);
            this.panel1.Controls.Add(this.lblBarras);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 434);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(42)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::EcoPura.Properties.Resources.deleteChiquito;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(130, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::EcoPura.Properties.Resources.addChiquito;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(255, 363);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 35);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pbIcono
            // 
            this.pbIcono.Image = global::EcoPura.Properties.Resources.producto;
            this.pbIcono.Location = new System.Drawing.Point(76, 17);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(97, 72);
            this.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcono.TabIndex = 19;
            this.pbIcono.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(192, 44);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(186, 45);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Alta Producto";
            // 
            // tbMinimo
            // 
            this.tbMinimo.Location = new System.Drawing.Point(134, 316);
            this.tbMinimo.Name = "tbMinimo";
            this.tbMinimo.Size = new System.Drawing.Size(74, 20);
            this.tbMinimo.TabIndex = 6;
            // 
            // tbExistencia
            // 
            this.tbExistencia.Location = new System.Drawing.Point(52, 316);
            this.tbExistencia.Name = "tbExistencia";
            this.tbExistencia.Size = new System.Drawing.Size(74, 20);
            this.tbExistencia.TabIndex = 5;
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(263, 252);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(198, 21);
            this.cbProveedor.TabIndex = 4;
            // 
            // cbClasificacion
            // 
            this.cbClasificacion.FormattingEnabled = true;
            this.cbClasificacion.Location = new System.Drawing.Point(52, 252);
            this.cbClasificacion.Name = "cbClasificacion";
            this.cbClasificacion.Size = new System.Drawing.Size(198, 21);
            this.cbClasificacion.TabIndex = 3;
            // 
            // tbBarras
            // 
            this.tbBarras.Location = new System.Drawing.Point(54, 194);
            this.tbBarras.Name = "tbBarras";
            this.tbBarras.Size = new System.Drawing.Size(407, 20);
            this.tbBarras.TabIndex = 2;
            // 
            // tbMaximo
            // 
            this.tbMaximo.Location = new System.Drawing.Point(216, 316);
            this.tbMaximo.Name = "tbMaximo";
            this.tbMaximo.Size = new System.Drawing.Size(74, 20);
            this.tbMaximo.TabIndex = 7;
            this.tbMaximo.TextChanged += new System.EventHandler(this.tbMaximo_TextChanged);
            // 
            // tbCosto
            // 
            this.tbCosto.Location = new System.Drawing.Point(385, 316);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(76, 20);
            this.tbCosto.TabIndex = 9;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(301, 316);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(74, 20);
            this.tbPrecio.TabIndex = 8;
            // 
            // tbDescripcioon
            // 
            this.tbDescripcioon.Location = new System.Drawing.Point(54, 135);
            this.tbDescripcioon.Name = "tbDescripcioon";
            this.tbDescripcioon.Size = new System.Drawing.Size(407, 20);
            this.tbDescripcioon.TabIndex = 1;
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.Location = new System.Drawing.Point(50, 227);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(94, 23);
            this.lblClasificacion.TabIndex = 8;
            this.lblClasificacion.Text = "Clasificación:";
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(131, 291);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(59, 23);
            this.lblMinimo.TabIndex = 7;
            this.lblMinimo.Text = "Mínimo:";
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(212, 291);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(62, 23);
            this.lblMaximo.TabIndex = 6;
            this.lblMaximo.Text = "Máximo:";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(259, 226);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(75, 23);
            this.lblProveedor.TabIndex = 5;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCosto.Location = new System.Drawing.Point(381, 291);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(47, 23);
            this.lblCosto.TabIndex = 4;
            this.lblCosto.Text = "Costo:";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistencia.Location = new System.Drawing.Point(49, 291);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(77, 23);
            this.lblExistencia.TabIndex = 3;
            this.lblExistencia.Text = "Existencia:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(297, 291);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 23);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblBarras
            // 
            this.lblBarras.AutoSize = true;
            this.lblBarras.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarras.Location = new System.Drawing.Point(50, 167);
            this.lblBarras.Name = "lblBarras";
            this.lblBarras.Size = new System.Drawing.Size(121, 23);
            this.lblBarras.TabIndex = 0;
            this.lblBarras.Text = "Código de Barras:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(50, 109);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(86, 23);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // MenuTopp
            // 
            this.MenuTopp.Controls.Add(this.lblTituloVentana);
            this.MenuTopp.Controls.Add(this.lblIconoVentana);
            this.MenuTopp.Controls.Add(this.button1);
            this.MenuTopp.Controls.Add(this.btnMinimizar);
            this.MenuTopp.Controls.Add(this.btnCerrar);
            this.MenuTopp.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTopp.Location = new System.Drawing.Point(0, 0);
            this.MenuTopp.Name = "MenuTopp";
            this.MenuTopp.Size = new System.Drawing.Size(541, 37);
            this.MenuTopp.TabIndex = 20;
            this.MenuTopp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuTopp_MouseMove);
            // 
            // lblTituloVentana
            // 
            this.lblTituloVentana.AutoSize = true;
            this.lblTituloVentana.Font = new System.Drawing.Font("Bahnschrift Condensed", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVentana.ForeColor = System.Drawing.Color.White;
            this.lblTituloVentana.Location = new System.Drawing.Point(64, 3);
            this.lblTituloVentana.Name = "lblTituloVentana";
            this.lblTituloVentana.Size = new System.Drawing.Size(97, 34);
            this.lblTituloVentana.TabIndex = 22;
            this.lblTituloVentana.Text = "Producto";
            // 
            // lblIconoVentana
            // 
            this.lblIconoVentana.Image = ((System.Drawing.Image)(resources.GetObject("lblIconoVentana.Image")));
            this.lblIconoVentana.Location = new System.Drawing.Point(36, 3);
            this.lblIconoVentana.Name = "lblIconoVentana";
            this.lblIconoVentana.Size = new System.Drawing.Size(22, 31);
            this.lblIconoVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lblIconoVentana.TabIndex = 21;
            this.lblIconoVentana.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(459, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(425, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(28, 31);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(498, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(30, 31);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PopUpProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(541, 491);
            this.Controls.Add(this.MenuTopp);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpProducto";
            this.Text = "altaProducto";
            this.Load += new System.EventHandler(this.PopUpProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.MenuTopp.ResumeLayout(false);
            this.MenuTopp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblIconoVentana)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblBarras;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbMinimo;
        private System.Windows.Forms.TextBox tbExistencia;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.ComboBox cbClasificacion;
        private System.Windows.Forms.TextBox tbBarras;
        private System.Windows.Forms.TextBox tbMaximo;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbDescripcioon;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.Panel MenuTopp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox lblIconoVentana;
        private System.Windows.Forms.Label lblTituloVentana;
    }
}