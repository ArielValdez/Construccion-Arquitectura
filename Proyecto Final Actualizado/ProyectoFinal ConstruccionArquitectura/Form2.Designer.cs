
namespace ProyectoFinal_ConstruccionArquitectura
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRemoveFromList = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pctbxMinimizacionVentana = new System.Windows.Forms.PictureBox();
            this.pctbxMaximizar = new System.Windows.Forms.PictureBox();
            this.pctbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pctbxCerrar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizacionVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 100);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(328, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(514, 96);
            this.listBox2.Margin = new System.Windows.Forms.Padding(2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(248, 147);
            this.listBox2.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(373, 134);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 276);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(328, 159);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(373, 385);
            this.btnFinalize.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(93, 32);
            this.btnFinalize.TabIndex = 4;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(373, 327);
            this.btnRemoveAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(93, 32);
            this.btnRemoveAll.TabIndex = 5;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Location = new System.Drawing.Point(373, 266);
            this.btnAddAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(93, 32);
            this.btnAddAll.TabIndex = 6;
            this.btnAddAll.Text = "Add All";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(373, 200);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(93, 32);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRemoveFromList
            // 
            this.btnRemoveFromList.Location = new System.Drawing.Point(514, 276);
            this.btnRemoveFromList.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveFromList.Name = "btnRemoveFromList";
            this.btnRemoveFromList.Size = new System.Drawing.Size(248, 32);
            this.btnRemoveFromList.TabIndex = 8;
            this.btnRemoveFromList.Text = "Remove From List";
            this.btnRemoveFromList.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(514, 251);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(248, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.Gwauin;
            this.pictureBox1.Location = new System.Drawing.Point(514, 314);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
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
            this.pnlBarraTitulo.TabIndex = 11;
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
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFinal_ConstruccionArquitectura.Properties.Resources.Gwauin;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(722, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Mi lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Products";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Listado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnRemoveFromList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizacionVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbxCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRemoveFromList;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox pctbxMinimizacionVentana;
        private System.Windows.Forms.PictureBox pctbxMaximizar;
        private System.Windows.Forms.PictureBox pctbxMinimizar;
        private System.Windows.Forms.PictureBox pctbxCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}