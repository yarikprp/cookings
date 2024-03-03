using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_app_v2.Classes
{
    internal class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Exit { get; set; }

        public Base(int id, string name, int exit)
        {
            Id = id;
            Name = name;
            Exit = exit;
        }
    }
}
