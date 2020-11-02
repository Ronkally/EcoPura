namespace EcoPura
{
    partial class LoginVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginVentana));
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbContrasena = new System.Windows.Forms.PictureBox();
            this.pbIcono = new System.Windows.Forms.PictureBox();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrasena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbUsuario.Location = new System.Drawing.Point(186, 39);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(265, 26);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "Usuario";
            this.tbUsuario.Enter += new System.EventHandler(this.tbUsuario_Enter);
            this.tbUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsuario_KeyDown);
            this.tbUsuario.Leave += new System.EventHandler(this.tbUsuario_Leave);
            // 
            // tbContrasena
            // 
            this.tbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasena.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tbContrasena.Location = new System.Drawing.Point(186, 89);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '*';
            this.tbContrasena.Size = new System.Drawing.Size(265, 26);
            this.tbContrasena.TabIndex = 2;
            this.tbContrasena.Text = "Contraseña";
            this.tbContrasena.Enter += new System.EventHandler(this.tbContrasena_Enter);
            this.tbContrasena.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbContrasena_KeyDown);
            this.tbContrasena.Leave += new System.EventHandler(this.tbContrasena_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 2;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.Location = new System.Drawing.Point(327, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 38);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciar.Location = new System.Drawing.Point(147, 255);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(117, 38);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar sesión";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBody
            // 
            this.panelBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBody.Controls.Add(this.pbUsuario);
            this.panelBody.Controls.Add(this.pbContrasena);
            this.panelBody.Controls.Add(this.tbUsuario);
            this.panelBody.Controls.Add(this.tbContrasena);
            this.panelBody.Location = new System.Drawing.Point(-7, 73);
            this.panelBody.Margin = new System.Windows.Forms.Padding(2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(594, 154);
            this.panelBody.TabIndex = 37;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::EcoPura.Properties.Resources.boton_de_cuenta_redonda_con_usuario_dentro;
            this.pbUsuario.Location = new System.Drawing.Point(154, 37);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(26, 27);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 35;
            this.pbUsuario.TabStop = false;
            // 
            // pbContrasena
            // 
            this.pbContrasena.Image = global::EcoPura.Properties.Resources.bloquear;
            this.pbContrasena.Location = new System.Drawing.Point(154, 86);
            this.pbContrasena.Name = "pbContrasena";
            this.pbContrasena.Size = new System.Drawing.Size(26, 27);
            this.pbContrasena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContrasena.TabIndex = 36;
            this.pbContrasena.TabStop = false;
            // 
            // pbIcono
            // 
            this.pbIcono.Image = global::EcoPura.Properties.Resources.IconoEco;
            this.pbIcono.Location = new System.Drawing.Point(16, 17);
            this.pbIcono.Name = "pbIcono";
            this.pbIcono.Size = new System.Drawing.Size(29, 36);
            this.pbIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcono.TabIndex = 32;
            this.pbIcono.TabStop = false;
            // 
            // LoginVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 339);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.pbIcono);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginVentana";
            this.Text = "    Iniciar sesión";
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrasena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContrasena;
        private System.Windows.Forms.PictureBox pbIcono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbContrasena;
        private System.Windows.Forms.Panel panelBody;
    }
}