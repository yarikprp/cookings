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
    internal static class ProductsFromDb
    {
        public static async Task<List<Product>> GetProducts()
        {
            List<Product> products = new List<Product>();

            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString);

            try
            {
                await connection.OpenAsync();

                string getProd = "SELECT prod_id, prod_name, prod_protein, prod_fats, prod_carboh FROM public.products";

                NpgsqlCommand command = new NpgsqlCommand(getProd, connection);

                NpgsqlDataReader reader = await command.ExecuteReaderAsync();
                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        products.Add(new Product(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4)));
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

            return products;
        }

        public static async Task DeleteProduct(int prodId)
        {
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString);
            NpgsqlCommand command = connection.CreateCommand();

            try
            {
                await connection.OpenAsync();

                command.CommandText = "select Count(*) from dishes join scructure on dish_id = dishes_id " +
                    "join products on products_id = prod_id where prod_id = @id";
                command.Parameters.AddWithValue("id", prodId);

                int count = Convert.ToInt32(await command.ExecuteScalarAsync());

                if (count == 0)
                {
                    command.CommandText = "delete from products where prod_id = @id";

                    if (await command.ExecuteNonQueryAsync() == 1)
                    {
                        MessageBox.Show("Продукт удалён");
                    }
                    else
                    {
                        MessageBox.Show("Запрос отклонён");
                    }
                }
                else
                {
                    MessageBox.Show($"Продукт используется в {count} блюдах. Невозможно удалить продукт");
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static async Task AddProduct(string name, int prot, int fats, int carb)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString))
                {
                    await connection.OpenAsync();

                    string add = "INSERT INTO public.products(prod_name, prod_protein, prod_fats, prod_carboh) " +
                        "VALUES (@name, @prot, @fats, @carb)";
                    NpgsqlCommand command = new NpgsqlCommand(add, connection);
                    command.Parameters.AddWithValue("name", name);
                    command.Parameters.AddWithValue("prot", prot);
                    command.Parameters.AddWithValue("fats", fats);
                    command.Parameters.AddWithValue("carb", carb);

                    if (await command.ExecuteNonQueryAsync() == 1)
                    {
                        MessageBox.Show($"Продукт {name} добавлен");
                    }
                    else
                    {
                        MessageBox.Show("Запрос отклонён");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
