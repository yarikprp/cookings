using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_app_v2.Classes
{
    public class Type
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public Type(int id, string name)
        {
            Id = id;
            TypeName = name;
        }
    }
}
