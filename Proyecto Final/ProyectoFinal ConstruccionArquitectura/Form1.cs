using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ProyectoFinal_ConstruccionArquitectura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pctbxMinimizacionVentana.Visible = false;
        }
        //Para las listas que se quieren crean, se deberian crear un listado para esas listas
        //Deberia poderse crear una tabla para cada lista creada unida a un usuario
        //Dicho listado debe contener dentro de ella cada lista creada por el usuario (Una lista de listas)
        #region Metodos de barra de titulo
        private void pctbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pctbxMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pctbxMaximizar.Visible = false;
            pctbxMinimizacionVentana.Visible = true;
        }

        private void pctbxMinimizacionVentana_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pctbxMinimizacionVentana.Visible = false;
            pctbxMaximizar.Visible = true;
        }

        private void pctbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
        #region Inter operations services
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            //Crea lista y tablas
        }

        private void btnOtrosListados_Click(object sender, EventArgs e)
        {
            //Muestra los listados que fueron creados por el usuario
        }

        private void btnListaDefecto_Click(object sender, EventArgs e)
        {
            //Muestra la tabla por defecto que viene con el usuario (Ejemplo: Wishlist o favoritos)
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //Dentro de un datagrid, deberia poderse ver los elementos dentro de listado, relacionado a su tabla en la base de datos
    }
}
