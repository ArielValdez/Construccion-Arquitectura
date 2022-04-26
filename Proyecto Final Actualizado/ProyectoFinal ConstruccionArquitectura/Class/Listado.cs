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
        public List<Object> Productos { get; set; } //Los objetos guardados en el listado
        public int Existencia { get; set; }
        public DateTime createdDate { get => DateTime.Now; }
        public Listado()
        {
            if (!Directory.Exists($"C:\\Documentos\\CarpetaEjemplo"))
            {
                Directory.CreateDirectory($"C:\\Documentos\\CarpetaEjemplo");
            }
        }
        public void CrearListado()
        {
            using (StreamWriter sw = File.CreateText($"C:\\Documentos\\CarpetaEjemplo\\{NombreListado}.csv")) { }
        }
        public void EliminarListado()
        {
            if (!File.Exists($"C:\\Documentos\\CarpetaEjemplo\\{NombreListado}.csv")) return;
            else File.Delete($"C:\\Documentos\\CarpetaEjemplo\\{NombreListado}.csv");
        }
    }
}
