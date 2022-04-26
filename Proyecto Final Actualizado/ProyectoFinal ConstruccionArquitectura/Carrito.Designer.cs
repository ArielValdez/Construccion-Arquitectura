
namespace ProyectoFinal_ConstruccionArquitectura
{
    partial class Carrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Carrito));
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pctbxMinimizacionVentana = new System.Windows.Forms.PictureBox();
            this.pctbxMaximizar = new System.Windows.Forms.PictureBox();
            this.pctbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pctbxCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizacionVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(800, 33);
            this.pnlBarraTitulo.TabIndex = 1;
            this.pnlBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBarraTitulo_Paint);
            // 
            // pctbxMinimizacionVentana
            // 
            this.pctbxMinimizacionVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbxMinimizacionVentana.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pctbxMinimizacionVentana.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctbxMinimizacionVentana.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.maximizar_tamano;
            this.pctbxMinimizacionVentana.Location = new System.Drawing.Point(738, 10);
            this.pctbxMinimizacionVentana.Margin = new System.Windows.Forms.Padding(2);
            this.pctbxMinimizacionVentana.Name = "pctbxMinimizacionVentana";
            this.pctbxMinimizacionVentana.Size = new System.Drawing.Size(24, 14);
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
            this.pctbxMaximizar.Location = new System.Drawing.Point(738, 10);
            this.pctbxMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.pctbxMaximizar.Name = "pctbxMaximizar";
            this.pctbxMaximizar.Size = new System.Drawing.Size(24, 14);
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
            this.pctbxMinimizar.Location = new System.Drawing.Point(710, 10);
            this.pctbxMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.pctbxMinimizar.Name = "pctbxMinimizar";
            this.pctbxMinimizar.Size = new System.Drawing.Size(24, 14);
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
            this.pctbxCerrar.Location = new System.Drawing.Point(767, 10);
            this.pctbxCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.pctbxCerrar.Name = "pctbxCerrar";
            this.pctbxCerrar.Size = new System.Drawing.Size(24, 14);
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
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.Gwauin;
            this.pictureBox2.Location = new System.Drawing.Point(11, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(725, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mi lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 278);
            this.dataGridView1.TabIndex = 4;
            // 
            // Carrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Carrito";
            this.Text = "Carrito";
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizacionVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox pctbxMinimizacionVentana;
        private System.Windows.Forms.PictureBox pctbxMaximizar;
        private System.Windows.Forms.PictureBox pctbxMinimizar;
        private System.Windows.Forms.PictureBox pctbxCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}