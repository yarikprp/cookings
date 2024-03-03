using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Type = kulinaria_app_v2.Classes.Type;

namespace kulinaria_app_v2.Model
{
    internal static class TypeFromDb
    {
        public async static Task<List<Type>> LoadTypes()
        {
            List<Type> types = new List<Type>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString);

            try
            {
                await connection.OpenAsync();

                string getTypes = "SELECT type_id, type_name FROM public.dish_types";

                NpgsqlCommand command = new NpgsqlCommand(getTypes, connection);
                NpgsqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        types.Add(new Type(reader.GetInt32(0), reader.GetString(1)));
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await connection.CloseAsync();
            }

            return types;
        }
    }
}
