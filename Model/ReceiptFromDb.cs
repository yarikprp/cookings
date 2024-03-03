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
    internal class ReceiptFromDb
    {
        public async static Task<Receipt> GetReceiptByDishId(int dish_id)
        {
            Receipt receipt = null;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString))
                {
                    await connection.OpenAsync();

                    string getReceipt = "SELECT * FROM public.recipe where dishes_id = @id";
                    NpgsqlCommand command = new NpgsqlCommand(getReceipt, connection);
                    command.Parameters.AddWithValue("id", dish_id);

                    NpgsqlDataReader reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            receipt = new Receipt(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2));
                        }
                    }
                    await reader.CloseAsync();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return receipt;
        }

        public async static Task AddNewReceipt(Receipt receipt)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString))
                {
                    await connection.OpenAsync();

                    string newRec = "INSERT INTO public.recipe(dishes_id, recipe_text) VALUES (@dish_id, @text)";
                    NpgsqlCommand command = new NpgsqlCommand(newRec, connection);
                    command.Parameters.AddWithValue("dish_id", receipt.Dish_id);
                    command.Parameters.AddWithValue("text", receipt.Recipe_text);

                    if (await command.ExecuteNonQueryAsync() == 1)
                    {
                        MessageBox.Show("Рецепт добавлен");
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

        public static async Task UpdateReceipt(Receipt receipt)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString))
                {
                    await connection.OpenAsync();

                    string update = "UPDATE public.recipe SET recipe_text = @text WHERE recipe_id = @id;";
                    NpgsqlCommand command = new NpgsqlCommand(update, connection);
                    command.Parameters.AddWithValue("id", receipt.Id);
                    command.Parameters.AddWithValue("text", receipt.Recipe_text);

                    if (await command.ExecuteNonQueryAsync() == 1)
                    {
                        MessageBox.Show("Рецепт обновлён");
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

        public static async Task DeleteReceipt(int rec_id)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(DbConnection.ConnectionString))
                {
                    await connection.OpenAsync();

                    string delete = "DELETE FROM public.recipe WHERE recipe_id = @id";
                    NpgsqlCommand command = new NpgsqlCommand(delete, connection);
                    command.Parameters.AddWithValue("id", rec_id);

                    if (await command.ExecuteNonQueryAsync() == 1)
                    {
                        MessageBox.Show("Рецепт удалён");
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
