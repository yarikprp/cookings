using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_app_v2.Classes
{
    internal class DishStructure
    {
        public int Dish_Id { get; set; }
        public string Prod_Name { get; set; }
        public int Weight { get; set; }

        public DishStructure(int id, string prod_name, int weight)
        {
            Dish_Id = id;
            Prod_Name = prod_name;
            Weight = weight;
        }
    }
}
