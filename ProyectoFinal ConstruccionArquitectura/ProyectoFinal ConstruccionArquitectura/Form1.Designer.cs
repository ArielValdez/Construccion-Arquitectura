
namespace ProyectoFinal_ConstruccionArquitectura
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
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pnlListdos = new System.Windows.Forms.Panel();
            this.pnlMostrarLista = new System.Windows.Forms.Panel();
            this.pctbxMinimizacionVentana = new System.Windows.Forms.PictureBox();
            this.pctbxMaximizar = new System.Windows.Forms.PictureBox();
            this.pctbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pctbxCerrar = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btnListaDefecto = new System.Windows.Forms.Button();
            this.btnOtrosListados = new System.Windows.Forms.Button();
            this.btnCrearLista = new System.Windows.Forms.Button();
            this.pnlBarraTitulo.SuspendLayout();
            this.pnlListdos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizacionVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlBarraTitulo.Controls.Add(this.pctbxMinimizacionVentana);
            this.pnlBarraTitulo.Controls.Add(this.pctbxMaximizar);
            this.pnlBarraTitulo.Controls.Add(this.pctbxMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.pctbxCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(960, 64);
            this.pnlBarraTitulo.TabIndex = 0;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // pnlListdos
            // 
            this.pnlListdos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlListdos.Controls.Add(this.btnCrearLista);
            this.pnlListdos.Controls.Add(this.btnOtrosListados);
            this.pnlListdos.Controls.Add(this.btnListaDefecto);
            this.pnlListdos.Controls.Add(this.Logo);
            this.pnlListdos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListdos.Location = new System.Drawing.Point(0, 64);
            this.pnlListdos.Name = "pnlListdos";
            this.pnlListdos.Size = new System.Drawing.Size(260, 476);
            this.pnlListdos.TabIndex = 1;
            // 
            // pnlMostrarLista
            // 
            this.pnlMostrarLista.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMostrarLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMostrarLista.Location = new System.Drawing.Point(260, 64);
            this.pnlMostrarLista.Name = "pnlMostrarLista";
            this.pnlMostrarLista.Size = new System.Drawing.Size(700, 476);
            this.pnlMostrarLista.TabIndex = 2;
            // 
            // pctbxMinimizacionVentana
            // 
            this.pctbxMinimizacionVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxMinimizacionVentana.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pctbxMinimizacionVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxMinimizacionVentana.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.maximizar_tamano;
            this.pctbxMinimizacionVentana.Location = new System.Drawing.Point(878, 12);
            this.pctbxMinimizacionVentana.Name = "pctbxMinimizacionVentana";
            this.pctbxMinimizacionVentana.Size = new System.Drawing.Size(32, 32);
            this.pctbxMinimizacionVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxMinimizacionVentana.TabIndex = 3;
            this.pctbxMinimizacionVentana.TabStop = false;
            this.pctbxMinimizacionVentana.Click += new System.EventHandler(this.pctbxMinimizacionVentana_Click);
            // 
            // pctbxMaximizar
            // 
            this.pctbxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxMaximizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pctbxMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxMaximizar.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.maximizar;
            this.pctbxMaximizar.Location = new System.Drawing.Point(878, 12);
            this.pctbxMaximizar.Name = "pctbxMaximizar";
            this.pctbxMaximizar.Size = new System.Drawing.Size(32, 32);
            this.pctbxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxMaximizar.TabIndex = 2;
            this.pctbxMaximizar.TabStop = false;
            this.pctbxMaximizar.Click += new System.EventHandler(this.pctbxMaximizar_Click);
            // 
            // pctbxMinimizar
            // 
            this.pctbxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxMinimizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pctbxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxMinimizar.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.minimizar;
            this.pctbxMinimizar.Location = new System.Drawing.Point(840, 12);
            this.pctbxMinimizar.Name = "pctbxMinimizar";
            this.pctbxMinimizar.Size = new System.Drawing.Size(32, 32);
            this.pctbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxMinimizar.TabIndex = 1;
            this.pctbxMinimizar.TabStop = false;
            this.pctbxMinimizar.Click += new System.EventHandler(this.pctbxMinimizar_Click);
            // 
            // pctbxCerrar
            // 
            this.pctbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxCerrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pctbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxCerrar.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.cerrar;
            this.pctbxCerrar.Location = new System.Drawing.Point(916, 12);
            this.pctbxCerrar.Name = "pctbxCerrar";
            this.pctbxCerrar.Size = new System.Drawing.Size(32, 32);
            this.pctbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxCerrar.TabIndex = 0;
            this.pctbxCerrar.TabStop = false;
            this.pctbxCerrar.Click += new System.EventHandler(this.pctbxCerrar_Click);
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(260, 120);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // btnListaDefecto
            // 
            this.btnListaDefecto.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnListaDefecto.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnListaDefecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaDefecto.Location = new System.Drawing.Point(3, 145);
            this.btnListaDefecto.Name = "btnListaDefecto";
            this.btnListaDefecto.Size = new System.Drawing.Size(254, 64);
            this.btnListaDefecto.TabIndex = 1;
            this.btnListaDefecto.Text = "Listado Predeterminado";
            this.btnListaDefecto.UseVisualStyleBackColor = true;
            this.btnListaDefecto.Click += new System.EventHandler(this.btnListaDefecto_Click);
            // 
            // btnOtrosListados
            // 
            this.btnOtrosListados.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOtrosListados.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOtrosListados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtrosListados.Location = new System.Drawing.Point(3, 208);
            this.btnOtrosListados.Name = "btnOtrosListados";
            this.btnOtrosListados.Size = new System.Drawing.Size(254, 74);
            this.btnOtrosListados.TabIndex = 2;
            this.btnOtrosListados.Text = "Listas Creadas (Ampliar ComboBox?)";
            this.btnOtrosListados.UseVisualStyleBackColor = true;
            this.btnOtrosListados.Click += new System.EventHandler(this.btnOtrosListados_Click);
            // 
            // btnCrearLista
            // 
            this.btnCrearLista.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCrearLista.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearLista.Location = new System.Drawing.Point(3, 119);
            this.btnCrearLista.Name = "btnCrearLista";
            this.btnCrearLista.Size = new System.Drawing.Size(254, 27);
            this.btnCrearLista.TabIndex = 3;
            this.btnCrearLista.Text = "Crear Lista";
            this.btnCrearLista.UseVisualStyleBackColor = true;
            this.btnCrearLista.Click += new System.EventHandler(this.btnCrearLista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pnlMostrarLista);
            this.Controls.Add(this.pnlListdos);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBarraTitulo.ResumeLayout(false);
            this.pnlListdos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizacionVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlListdos;
        private System.Windows.Forms.Panel pnlMostrarLista;
        private System.Windows.Forms.PictureBox pctbxMinimizacionVentana;
        private System.Windows.Forms.PictureBox pctbxMaximizar;
        private System.Windows.Forms.PictureBox pctbxMinimizar;
        private System.Windows.Forms.PictureBox pctbxCerrar;
        private System.Windows.Forms.Button btnOtrosListados;
        private System.Windows.Forms.Button btnListaDefecto;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btnCrearLista;
    }
}

