using kulinaria_app_v2.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kulinaria_app_v2.Model
{
    internal static class BaseFromDb
    {
        public static async Task<List<Base>> GetBases()
        {
            List<Base> bases = new List<Base>();

            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString);

            try
            {
                await connection.OpenAsync();

                string getBases = "SELECT base_id, base_name, base_exit FROM public.dish_base";

                NpgsqlCommand command = new NpgsqlCommand(getBases, connection);

                NpgsqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        bases.Add(new Base(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2)));
                    }
                }
                await reader.CloseAsync();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                await connection.CloseAsync();
            }

            return bases;
        }
    }
}
