using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_app_v2.Classes
{
    public class Dish
    {
        public int Id { get; set; }
        public string DishName { get; set; }
        public string DishType { get; set; }
        public string DishBase { get; set; }
        public int DishExit { get; set; }
        public Image Image { get; set; }

        public Dish(int id, string dishName, string dishType, string dishBase, int dishExit, string image)
        {
            Id = id;
            DishName = dishName;
            DishType = dishType;
            DishBase = dishBase;
            DishExit = dishExit;

            if (image != "")
            {
                Image = Image.FromFile(image);
            }
            else
            {
                Image = Image.FromFile(@"..\..\Images\picture.jpg");
            }
        }
    }
}
