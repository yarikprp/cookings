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
    internal static class DishFromDb
    {
        public async static Task<List<Dish>> LoadDishes()
        {
            List<Dish> dishes = new List<Dish>();

            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString);

            try
            {
                await connection.OpenAsync();

                string getDishes = "SELECT dish_id, dish_name, type_name, base_name, base_exit, dish_image" +
                    " FROM public.dishes join public.dish_types on dish_type_id = type_id join public.dish_base" +
                    " on dish_base_id = base_id order by dish_id;";

                NpgsqlCommand cmd = new NpgsqlCommand(getDishes, connection);
                NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        dishes.Add(new Dish(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader[5].ToString()));
                    }
                    await reader.CloseAsync();
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
            return dishes;
        }

        public static async Task<List<Dish>> FilterDishesByType(int idType)
        {
            List<Dish> filtered_dishes = new List<Dish>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString);

            try
            {
                await connection.OpenAsync();

                string filterDishes = "SELECT dish_id, dish_name, type_name, base_name, base_exit, dish_image" +
                    " FROM public.dishes join public.dish_types on dish_type_id = type_id join public.dish_base" +
                    " on dish_base_id = base_id where dish_type_id = @type_id order by dish_id";

                NpgsqlCommand cmd = new NpgsqlCommand(filterDishes, connection);
                cmd.Parameters.AddWithValue("type_id", idType);

                NpgsqlDataReader reader = await cmd.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        filtered_dishes.Add(new Dish(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader[5].ToString()));
                    }
                    await reader.CloseAsync();
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

            return filtered_dishes;
        }

        public static async Task<List<DishStructure>> DishStructureFromDb(int idDish)
        {
            List<DishStructure> structures = new List<DishStructure>();

            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString);

            try
            {
                await connection.OpenAsync();

                string getStruct = "SELECT prod_name, weight FROM public.scructure " +
                    "join public.products on products_id = prod_id where dishes_id = @dish_id";

                NpgsqlCommand command = new NpgsqlCommand(getStruct, connection);
                command.Parameters.AddWithValue("dish_id", idDish);

                NpgsqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        structures.Add(new DishStructure(idDish, reader.GetString(0), reader.GetInt32(1)));
                    }
                    await reader.CloseAsync();
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

            return structures;
        }

        public static async Task DeleteDish(int idDish)
        {
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString);

            try
            {
                await connection.OpenAsync();

                string deleteDish = "DELETE FROM public.dishes WHERE dish_id = @dish_id";

                NpgsqlCommand command = new NpgsqlCommand(deleteDish, connection);
                command.Parameters.AddWithValue("dish_id", idDish);

                int i = await command.ExecuteNonQueryAsync();

                if (i == 1)
                {
                    MessageBox.Show("Блюдо удалено");
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
        }

        public static async Task AddNewDish(Dish newDish, List<DishStructure> dishStructure, int idType, string picPath)
        {
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString);

            await connection.OpenAsync();

            NpgsqlTransaction transaction = connection.BeginTransaction();
            NpgsqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;

            try
            {
                command.CommandText = "INSERT INTO public.dishes (dish_name, dish_type_id, dish_base_id, dish_image) VALUES " +
                    "(@name, @type_id, (SELECT base_id FROM public.dish_base where base_name = @base_name), @path)";

                command.Parameters.AddWithValue("name", newDish.DishName);
                command.Parameters.AddWithValue("type_id", idType);
                command.Parameters.AddWithValue("base_name", newDish.DishBase);
                command.Parameters.AddWithValue("path", picPath);

                await command.ExecuteNonQueryAsync();

                command.CommandText = "select max(dish_id) from public.dishes";
                int idDish = Convert.ToInt32(await command.ExecuteScalarAsync());

                for (int i = 0; i < dishStructure.Count; i++)
                {
                    command.CommandText = $"INSERT INTO public.scructure (dishes_id, products_id, weight) VALUES ({idDish}, " +
                        $"(select prod_id from public.products where prod_name = '{dishStructure[i].Prod_Name}'), {dishStructure[i].Weight})";

                    await command.ExecuteNonQueryAsync();
                }

                MessageBox.Show("Блюдо добавлено");
                await transaction.CommitAsync();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                await transaction.RollbackAsync();
            }
            finally
            {
                await connection.CloseAsync();
            }
        }

        public static async Task<List<Dish>> SearchDish(string search)
        {
            List<Dish> dishList = new List<Dish>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString))
                {
                    await connection.OpenAsync();

                    NpgsqlCommand command = new NpgsqlCommand(search, connection);

                    NpgsqlDataReader reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            dishList.Add(new Dish(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader[5].ToString()));
                        }
                    }
                    await reader.CloseAsync();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dishList;
        }
    }
}
