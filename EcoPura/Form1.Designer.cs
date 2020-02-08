namespace EcoPura
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuTop = new System.Windows.Forms.Panel();
            this.MenuSidebar = new System.Windows.Forms.PictureBox();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.SidebarWrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.Retroceso = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.Separador = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.PanelChart = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.PictureBox();
            this.Mod = new System.Windows.Forms.PictureBox();
            this.Add = new System.Windows.Forms.PictureBox();
            this.SearchButton = new System.Windows.Forms.PictureBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SidebarWrapper.SuspendLayout();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Retroceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Wrapper.SuspendLayout();
            this.PanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.MenuTop.Controls.Add(this.MenuSidebar);
            this.MenuTop.Controls.Add(this.Restaurar);
            this.MenuTop.Controls.Add(this.Minimizar);
            this.MenuTop.Controls.Add(this.Maximizar);
            this.MenuTop.Controls.Add(this.Salir);
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(900, 50);
            this.MenuTop.TabIndex = 0;
            this.MenuTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MenuTop_MouseMove);
            // 
            // MenuSidebar
            // 
            this.MenuSidebar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuSidebar.Image = ((System.Drawing.Image)(resources.GetObject("MenuSidebar.Image")));
            this.MenuSidebar.Location = new System.Drawing.Point(27, 12);
            this.MenuSidebar.Name = "MenuSidebar";
            this.MenuSidebar.Size = new System.Drawing.Size(25, 25);
            this.MenuSidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuSidebar.TabIndex = 4;
            this.MenuSidebar.TabStop = false;
            this.MenuSidebar.Click += new System.EventHandler(this.MenuSidebar_Click);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(827, 12);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(25, 25);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 3;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(796, 12);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(25, 25);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click_1);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(827, 12);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(25, 25);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 1;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click_1);
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(858, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(25, 25);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click_1);
            // 
            // SidebarWrapper
            // 
            this.SidebarWrapper.Controls.Add(this.Sidebar);
            this.SidebarWrapper.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidebarWrapper.Location = new System.Drawing.Point(0, 50);
            this.SidebarWrapper.Name = "SidebarWrapper";
            this.SidebarWrapper.Size = new System.Drawing.Size(200, 500);
            this.SidebarWrapper.TabIndex = 1;
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Sidebar.Controls.Add(this.Retroceso);
            this.Sidebar.Controls.Add(this.BackButton);
            this.Sidebar.Controls.Add(this.Logo);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.shapeContainer1);
            this.Sidebar.Location = new System.Drawing.Point(12, 15);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(176, 473);
            this.Sidebar.TabIndex = 0;
            // 
            // Retroceso
            // 
            this.Retroceso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Retroceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Retroceso.Image = ((System.Drawing.Image)(resources.GetObject("Retroceso.Image")));
            this.Retroceso.Location = new System.Drawing.Point(71, 178);
            this.Retroceso.Name = "Retroceso";
            this.Retroceso.Size = new System.Drawing.Size(35, 30);
            this.Retroceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Retroceso.TabIndex = 7;
            this.Retroceso.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Swis721 Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(41, 169);
            this.BackButton.Name = "BackButton";
            this.BackButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BackButton.Size = new System.Drawing.Size(101, 60);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Regresar";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // Logo
            // 
            this.Logo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(67, 13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(44, 46);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Swis721 BT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "ECOPURA";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.Separador});
            this.shapeContainer1.Size = new System.Drawing.Size(176, 473);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // Separador
            // 
            this.Separador.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Separador.Name = "Separador";
            this.Separador.X1 = 15;
            this.Separador.X2 = 158;
            this.Separador.Y1 = 100;
            this.Separador.Y2 = 100;
            // 
            // Wrapper
            // 
            this.Wrapper.Controls.Add(this.PanelChart);
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(200, 50);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(700, 500);
            this.Wrapper.TabIndex = 2;
            // 
            // PanelChart
            // 
            this.PanelChart.BackColor = System.Drawing.Color.Gainsboro;
            this.PanelChart.Controls.Add(this.Delete);
            this.PanelChart.Controls.Add(this.Mod);
            this.PanelChart.Controls.Add(this.Add);
            this.PanelChart.Controls.Add(this.SearchButton);
            this.PanelChart.Controls.Add(this.SearchBox);
            this.PanelChart.Controls.Add(this.label1);
            this.PanelChart.Controls.Add(this.dataGridView1);
            this.PanelChart.Location = new System.Drawing.Point(14, 15);
            this.PanelChart.Name = "PanelChart";
            this.PanelChart.Size = new System.Drawing.Size(674, 473);
            this.PanelChart.TabIndex = 0;
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(566, 56);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(35, 35);
            this.Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Delete.TabIndex = 9;
            this.Delete.TabStop = false;
            // 
            // Mod
            // 
            this.Mod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Mod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mod.Image = ((System.Drawing.Image)(resources.GetObject("Mod.Image")));
            this.Mod.Location = new System.Drawing.Point(521, 56);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(35, 35);
            this.Mod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Mod.TabIndex = 8;
            this.Mod.TabStop = false;
            // 
            // Add
            // 
            this.Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(475, 56);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(35, 35);
            this.Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add.TabIndex = 7;
            this.Add.TabStop = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.Location = new System.Drawing.Point(280, 64);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(27, 27);
            this.SearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchButton.TabIndex = 3;
            this.SearchButton.TabStop = false;
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SearchBox.Location = new System.Drawing.Point(70, 67);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(204, 20);
            this.SearchBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 BT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de productos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(70, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 333);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.Wrapper);
            this.Controls.Add(this.SidebarWrapper);
            this.Controls.Add(this.MenuTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuSidebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.SidebarWrapper.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Retroceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Wrapper.ResumeLayout(false);
            this.PanelChart.ResumeLayout(false);
            this.PanelChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuTop;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel SidebarWrapper;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel PanelChart;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Logo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape Separador;
        private System.Windows.Forms.PictureBox Retroceso;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.PictureBox MenuSidebar;
        private System.Windows.Forms.PictureBox Delete;
        private System.Windows.Forms.PictureBox Mod;
        private System.Windows.Forms.PictureBox Add;
    }
}

