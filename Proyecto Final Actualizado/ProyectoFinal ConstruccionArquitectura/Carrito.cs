using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_ConstruccionArquitectura
{
    public partial class Carrito : Form
    {
        public Carrito()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio newform = new Inicio();
            newform.Show();
        }

        private void pnlBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pctbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos newform = new Productos();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform = new Form2();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMostrarListas newform = new frmMostrarListas();
            newform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
