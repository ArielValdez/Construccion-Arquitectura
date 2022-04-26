using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal_ConstruccionArquitectura
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();
        DataTable dtSelected = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            FillProducts();
            FillSelected();
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "Name";
            listBox2.DataSource = dtSelected;
            listBox2.DisplayMember = "Name";

            DirectoryInfo d = new DirectoryInfo(@".\");
            //DirectoryInfo d = new DirectoryIngo( //Poner aqui )
            FileInfo[] Files = d.GetFiles("*.csv"); //Getting Text files

            comboBox1.DataSource = Files;
        }
        #region methods
        private void FillProducts()
        {
            //Nombres de las columnas
            //Aqui deberia cargar un csv, si se piensa hacer un csv para los productos puestos
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
        private void FillSelected()
        {
            //Nombres de las columnas
            //Deberia guardar a un csv, sea el predeterminado o el creado por el usuario
            dtSelected.Columns.Add("Name", typeof(string));
            dtSelected.Columns.Add("Description");
            dtSelected.Columns.Add("Price");
            dtSelected.Columns.Add("Units");
        }
        #endregion
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                dtSelected.ImportRow(dt.Rows[listBox1.SelectedIndex]);
                dt.Rows[listBox1.SelectedIndex].Delete();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                dt.ImportRow(dtSelected.Rows[listBox2.SelectedIndex]);
                dtSelected.Rows[listBox2.SelectedIndex].Delete();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    dtSelected.ImportRow(dt.Rows[listBox1.SelectedIndex]);
                    dt.Rows[listBox1.SelectedIndex].Delete();
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                int count = dtSelected.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    dt.ImportRow(dtSelected.Rows[listBox2.SelectedIndex]);
                    dtSelected.Rows[listBox2.SelectedIndex].Delete();
                }
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Seguro que quieres agregar?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes) //Deberia poder guardar datos en un csv seleccionado
            {

                dataGridView1.DataSource = dtSelected;

                StringBuilder sb = new StringBuilder();

                var columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
                sb.AppendLine(string.Join(",", columnNames));

                foreach (DataRow row in dtSelected.Rows)
                {
                    var fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                    sb.AppendLine(string.Join(",", fields));
                }

                File.WriteAllText($"{comboBox1.Text}", sb.ToString());
            }
            else
            {
                MessageBox.Show("", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carrito newform = new Carrito();
            newform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMostrarListas newform = new frmMostrarListas();
            newform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Productos newform = new Productos();
            newform.Show();
        }

        private void pctbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio newform = new Inicio();
            newform.Show();
        }
    }
}
