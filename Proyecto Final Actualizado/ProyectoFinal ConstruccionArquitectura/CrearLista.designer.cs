
namespace ProyectoFinal_ConstruccionArquitectura
{
    partial class frmMostrarListas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMostrarListas));
            this.frmCreacionLista = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pctbxMinimizacionVentana = new System.Windows.Forms.PictureBox();
            this.pctbxMaximizar = new System.Windows.Forms.PictureBox();
            this.pctbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pctbxCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizacionVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // frmCreacionLista
            // 
            this.frmCreacionLista.AutoSize = true;
            this.frmCreacionLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmCreacionLista.Location = new System.Drawing.Point(15, 106);
            this.frmCreacionLista.Name = "frmCreacionLista";
            this.frmCreacionLista.Size = new System.Drawing.Size(348, 46);
            this.frmCreacionLista.TabIndex = 1;
            this.frmCreacionLista.Text = "Creacion de Lista";
            this.frmCreacionLista.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(447, 238);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 42);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(569, 238);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 42);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 175);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(128, 175);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(58, 17);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(11, 314);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(757, 116);
            this.listBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(15, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Este listbox muestra las listas ya creadas, Seleccionar para eliminar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(317, 208);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(351, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion";
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
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1067, 39);
            this.pnlBarraTitulo.TabIndex = 10;
            // 
            // pctbxMinimizacionVentana
            // 
            this.pctbxMinimizacionVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxMinimizacionVentana.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pctbxMinimizacionVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxMinimizacionVentana.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.maximizar_tamano;
            this.pctbxMinimizacionVentana.Location = new System.Drawing.Point(984, 12);
            this.pctbxMinimizacionVentana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbxMinimizacionVentana.Name = "pctbxMinimizacionVentana";
            this.pctbxMinimizacionVentana.Size = new System.Drawing.Size(32, 17);
            this.pctbxMinimizacionVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxMinimizacionVentana.TabIndex = 3;
            this.pctbxMinimizacionVentana.TabStop = false;
            // 
            // pctbxMaximizar
            // 
            this.pctbxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxMaximizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pctbxMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxMaximizar.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.maximizar;
            this.pctbxMaximizar.Location = new System.Drawing.Point(984, 12);
            this.pctbxMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbxMaximizar.Name = "pctbxMaximizar";
            this.pctbxMaximizar.Size = new System.Drawing.Size(32, 17);
            this.pctbxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxMaximizar.TabIndex = 2;
            this.pctbxMaximizar.TabStop = false;
            // 
            // pctbxMinimizar
            // 
            this.pctbxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxMinimizar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pctbxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxMinimizar.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.minimizar;
            this.pctbxMinimizar.Location = new System.Drawing.Point(947, 12);
            this.pctbxMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbxMinimizar.Name = "pctbxMinimizar";
            this.pctbxMinimizar.Size = new System.Drawing.Size(32, 17);
            this.pctbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxMinimizar.TabIndex = 1;
            this.pctbxMinimizar.TabStop = false;
            // 
            // pctbxCerrar
            // 
            this.pctbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxCerrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pctbxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxCerrar.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.cerrar;
            this.pctbxCerrar.Location = new System.Drawing.Point(1023, 12);
            this.pctbxCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctbxCerrar.Name = "pctbxCerrar";
            this.pctbxCerrar.Size = new System.Drawing.Size(32, 17);
            this.pctbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbxCerrar.TabIndex = 0;
            this.pctbxCerrar.TabStop = false;
            this.pctbxCerrar.Click += new System.EventHandler(this.pctbxCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 50);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.Gwauin;
            this.pictureBox2.Location = new System.Drawing.Point(15, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(111, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(967, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 9);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mi lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(132, 9);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "Products";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(824, 9);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 0;
            this.button5.Text = "Listado";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmMostrarListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.frmCreacionLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMostrarListas";
            this.Text = "Mostrar_Listas";
            this.Load += new System.EventHandler(this.frmMostrarListas_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizacionVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label frmCreacionLista;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox pctbxMinimizacionVentana;
        private System.Windows.Forms.PictureBox pctbxMaximizar;
        private System.Windows.Forms.PictureBox pctbxMinimizar;
        private System.Windows.Forms.PictureBox pctbxCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}