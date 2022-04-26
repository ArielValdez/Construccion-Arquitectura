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
    public partial class Productos : Form
    {
        DataTable dt = new DataTable();
        public Productos()
        {
            InitializeComponent();
            FillGrid();
            dataGridView1.DataSource = dt;
        }
        #region Method
        private void FillGrid()
        {
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Description");
            dt.Columns.Add("Price");
            dt.Columns.Add("Units");
            //Deberia entrar a un csv indicado en el combobox
            dt.Rows.Add("Manzana", "Fruta", 5.0, 12);
            dt.Rows.Add("Banana", "Fruta", 15.0, 12);
            dt.Rows.Add("Pera", "Fruta", 5.0, 12);
            dt.Rows.Add("Guanabana", "Fruta", 15.0, 12);
            dt.Rows.Add("Cereza", "Fruta", 25.0, 12);
            dt.Rows.Add("Naranja", "Fruta", 15.0, 12);
            dt.Rows.Add("Aguacate", "Fruta", 15.0, 12);
            dt.Rows.Add("Melocoton", "Fruta", 15.0, 12);
        }
        #endregion
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 newform = new Form2();
            newform.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio newform = new Inicio();
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
            this.Hide();
            Carrito newform = new Carrito();
            newform.Show();
        }

        private void pctbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
