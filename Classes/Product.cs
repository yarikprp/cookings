using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_app_v2.Classes
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Protein { get; set; }
        public int Fats { get; set; }
        public int Carboh { get; set; }

        public Product(int id, string name, int prot, int fats, int carboh)
        {
            Id = id;
            Name = name;
            Protein = prot;
            Fats = fats;
            Carboh = carboh;
        }
    }
}
