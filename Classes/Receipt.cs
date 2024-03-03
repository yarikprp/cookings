using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_app_v2.Classes
{
    public class Receipt
    {
        public int Id { get; set; }
        public int Dish_id { get; set; }
        public string Recipe_text { get; set; }

        public Receipt(int id, int dish_id, string text)
        {
            Id = id;
            Dish_id = dish_id;
            Recipe_text = text;
        }
    }
}
