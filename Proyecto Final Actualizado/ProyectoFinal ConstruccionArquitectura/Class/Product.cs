using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoFinal_ConstruccionArquitectura.Class
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Units { get; set; }
        public Product()
        {

        }
        public List<Product> LoadCSV(string csvFile)
        {
            var query = from l in File.ReadAllLines(csvFile)
                        let data = l.Split(',')
                        select new Product
                        {
                            Name = data[0],
                            Description = data[1],
                            Price = double.Parse(data[2]),
                            Units = int.Parse(data[3])
                        };
            return query.ToList();
        }
    }
}
