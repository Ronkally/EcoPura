namespace EcoPura
{
    partial class PuntoVentaVentana2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuntoVentaVentana2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSide = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.tbSearchBox = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGarrafon20L = new MetroFramework.Controls.MetroTile();
            this.labelP = new System.Windows.Forms.Label();
            this.gridview = new MetroFramework.Controls.MetroGrid();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDecrementar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrarUltimo = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSide.Controls.Add(this.metroLabel2);
            this.panelSide.Controls.Add(this.metroLabel1);
            this.panelSide.Controls.Add(this.btnRegresar);
            this.panelSide.Controls.Add(this.tbSearchBox);
            this.panelSide.Controls.Add(this.btnBuscar);
            this.panelSide.Controls.Add(this.btnGarrafon20L);
            this.panelSide.HorizontalScrollbarBarColor = true;
            this.panelSide.HorizontalScrollbarHighlightOnWheel = false;
            this.panelSide.HorizontalScrollbarSize = 10;
            this.panelSide.Location = new System.Drawing.Point(0, 60);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(324, 490);
            this.panelSide.TabIndex = 0;
            this.panelSide.UseCustomBackColor = true;
            this.panelSide.VerticalScrollbarBarColor = true;
            this.panelSide.VerticalScrollbarHighlightOnWheel = false;
            this.panelSide.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(82, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(166, 25);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Agrega un producto";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(82, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(160, 25);
            this.metroLabel1.TabIndex = 27;
            this.metroLabel1.Text = "Garrafones/Botellas";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(0, 369);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(324, 98);
            this.btnRegresar.TabIndex = 26;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchBox.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbSearchBox.Location = new System.Drawing.Point(27, 46);
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(240, 29);
            this.tbSearchBox.TabIndex = 13;
            this.tbSearchBox.Text = "Código de barras";
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            this.tbSearchBox.Enter += new System.EventHandler(this.tbSearchBox_Enter);
            this.tbSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearchBox_KeyDown);
            this.tbSearchBox.Leave += new System.EventHandler(this.tbSearchBox_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = global::EcoPura.Properties.Resources.plus;
            this.btnBuscar.Location = new System.Drawing.Point(273, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(32, 29);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGarrafon20L
            // 
            this.btnGarrafon20L.ActiveControl = null;
            this.btnGarrafon20L.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGarrafon20L.Location = new System.Drawing.Point(27, 150);
            this.btnGarrafon20L.Name = "btnGarrafon20L";
            this.btnGarrafon20L.Size = new System.Drawing.Size(86, 102);
            this.btnGarrafon20L.TabIndex = 3;
            this.btnGarrafon20L.Text = "20L";
            this.btnGarrafon20L.TileImage = ((System.Drawing.Image)(resources.GetObject("btnGarrafon20L.TileImage")));
            this.btnGarrafon20L.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGarrafon20L.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnGarrafon20L.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.btnGarrafon20L.UseCustomBackColor = true;
            this.btnGarrafon20L.UseSelectable = true;
            this.btnGarrafon20L.UseTileImage = true;
            this.btnGarrafon20L.Click += new System.EventHandler(this.btnGarrafon20L_Click);
            // 
            // labelP
            // 
            this.labelP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Bahnschrift Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelP.Location = new System.Drawing.Point(770, 470);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(91, 45);
            this.labelP.TabIndex = 26;
            this.labelP.Text = "$ 0.00";
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToResizeRows = false;
            this.gridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Descripción,
            this.Precio,
            this.Cantidad,
            this.Importe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridview.EnableHeadersVisualStyles = false;
            this.gridview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridview.Location = new System.Drawing.Point(355, 60);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(506, 380);
            this.gridview.TabIndex = 32;
            this.gridview.UseStyleColors = true;
            this.gridview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellDoubleClick);
            this.gridview.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_CellEndEdit);
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // btnDecrementar
            // 
            this.btnDecrementar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecrementar.BackColor = System.Drawing.Color.LightCyan;
            this.btnDecrementar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecrementar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDecrementar.FlatAppearance.BorderSize = 2;
            this.btnDecrementar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnDecrementar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrementar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrementar.Image = global::EcoPura.Properties.Resources.decrementar;
            this.btnDecrementar.Location = new System.Drawing.Point(663, 458);
            this.btnDecrementar.Name = "btnDecrementar";
            this.btnDecrementar.Size = new System.Drawing.Size(71, 73);
            this.btnDecrementar.TabIndex = 33;
            this.btnDecrementar.Text = "Decrementar";
            this.btnDecrementar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDecrementar.UseVisualStyleBackColor = false;
            this.btnDecrementar.Click += new System.EventHandler(this.btnDecrementar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.LightCyan;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::EcoPura.Properties.Resources.incrementar;
            this.btnAgregar.Location = new System.Drawing.Point(586, 458);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 73);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Incrementar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrarUltimo
            // 
            this.btnBorrarUltimo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorrarUltimo.BackColor = System.Drawing.Color.LightCyan;
            this.btnBorrarUltimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarUltimo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrarUltimo.FlatAppearance.BorderSize = 2;
            this.btnBorrarUltimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnBorrarUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarUltimo.Image = global::EcoPura.Properties.Resources.borrarUltimo;
            this.btnBorrarUltimo.Location = new System.Drawing.Point(509, 458);
            this.btnBorrarUltimo.Name = "btnBorrarUltimo";
            this.btnBorrarUltimo.Size = new System.Drawing.Size(71, 73);
            this.btnBorrarUltimo.TabIndex = 30;
            this.btnBorrarUltimo.Text = "Borrar";
            this.btnBorrarUltimo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrarUltimo.UseVisualStyleBackColor = false;
            this.btnBorrarUltimo.Click += new System.EventHandler(this.btnBorrarUltimo_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorrarTodo.BackColor = System.Drawing.Color.LightCyan;
            this.btnBorrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnBorrarTodo.FlatAppearance.BorderSize = 2;
            this.btnBorrarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Image = global::EcoPura.Properties.Resources.borrarTodo;
            this.btnBorrarTodo.Location = new System.Drawing.Point(432, 458);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(71, 73);
            this.btnBorrarTodo.TabIndex = 29;
            this.btnBorrarTodo.Text = "Borrar todo";
            this.btnBorrarTodo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRealizarVenta.BackColor = System.Drawing.Color.LightCyan;
            this.btnRealizarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarVenta.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnRealizarVenta.FlatAppearance.BorderSize = 2;
            this.btnRealizarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenta.Image = global::EcoPura.Properties.Resources.realizarVenta;
            this.btnRealizarVenta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRealizarVenta.Location = new System.Drawing.Point(355, 458);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(71, 73);
            this.btnRealizarVenta.TabIndex = 28;
            this.btnRealizarVenta.Text = "Realizar venta";
            this.btnRealizarVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EcoPura.Properties.Resources.IconoEco;
            this.pictureBox1.Location = new System.Drawing.Point(20, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // PuntoVentaVentana2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnDecrementar);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBorrarUltimo);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.panelSide);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PuntoVentaVentana2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "    Punto de venta";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.PuntoVentaVentana2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PuntoVentaVentana2_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PuntoVentaVentana2_KeyPress);
            this.Resize += new System.EventHandler(this.PuntoVentaVentana2_Resize);
            this.panelSide.ResumeLayout(false);
            this.panelSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel panelSide;
        private MetroFramework.Controls.MetroTile btnGarrafon20L;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbSearchBox;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrarUltimo;
        private System.Windows.Forms.Button btnAgregar;
        private MetroFramework.Controls.MetroGrid gridview;
        private System.Windows.Forms.Button btnRegresar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button btnDecrementar;
    }
}