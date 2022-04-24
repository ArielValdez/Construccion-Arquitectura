using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinal_ConstruccionArquitectura.Class
{
    class Listado
    {
        public int Id { get; set; }
        public string NombreListado { get; set; } //Nombre del documento
        public string Descripcion { get; set; } //Opcional, para lo que fue hecho el listado
        public List<string> Objetos { get; set; } //Los objetos guardados en el listado
        public Listado()
        {

        }
        public void CrearListado()
        {
            using (StreamWriter sw = File.CreateText($@"C:\Desktop\{NombreListado}.csv")) { }
        }
        public void EliminarListado()
        {
            if (!File.Exists($@"C:\Desktop{NombreListado}.csv")) return;
            else File.Delete($@"C:\Desktop{NombreListado}.csv");
        }
    }
}
