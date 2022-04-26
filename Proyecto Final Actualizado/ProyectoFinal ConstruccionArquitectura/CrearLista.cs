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
    public partial class frmMostrarListas : Form
    {
        public frmMostrarListas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Seguro que quieres agregar?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes) //Deberia poder guardar datos en un csv seleccionado
            {


                //if (string.IsNullOrEmpty(textBox1.Text))
                //    return;
                //listBox1.Items.Add(textBox1.Text);
                //textBox1.Clear();
                //textBox1.Focus();

                string path = $@".\{textBox1.Text}.csv";

                try
                {
                    // Create the file, or overwrite if the file exists.
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                        // Add some information to the file.
                        fs.Write(info, 0, info.Length);
                    }

                    // Open the stream and read it back.
                    using (StreamReader sr = File.OpenText(path))
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {

                        }
                    }
                }

                catch (Exception ex)
                {

                }
                listBox1.Items.Clear();
                Refresh();

            }
            else
            {
                MessageBox.Show("", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult diag = MessageBox.Show("Seguro que quieres eliminar?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (diag == DialogResult.Yes) //Deberia poder guardar datos en un csv seleccionado
            {

                if (listBox1.Items.Count > 0 && File.Exists($@".\{textBox1.Text}.csv"))
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                    File.Delete($@".\{textBox1.Text}.csv");
                }
            }
            else
            {
                MessageBox.Show("", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listBox1.Items.Clear();
            Refresh();
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

        private void button4_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carrito newform = new Carrito();
            newform.Show();
        }

        private void frmMostrarListas_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void Refresh()
        {
            var folderName = @".\";
            var results = Directory
                .GetFiles(folderName, "*.csv")
                .Select(file => Path.GetFileName(file))
                .ToArray();

            listBox1.Items.AddRange(results);
        }
    }
}
