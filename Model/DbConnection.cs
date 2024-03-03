using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kulinaria_app_v2.Model
{
    internal static class DbConnection
    {
        public readonly static string ConnectionString = "Host=localhost;Port=5432;Database=kulinaria_db;Username=postgres;Password=1";
    }
}
