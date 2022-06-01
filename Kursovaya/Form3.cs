using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Kursovaya
{
    public partial class Form3 : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand command;

        public string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clair\source\repos\Kursovaya\Kursovaya\Database1.mdf;Integrated Security=True";

        private int customer_id;

        private async void refresh()
        {
            dgv_parts.Rows.Clear();
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            command = new SqlCommand("SELECT * FROM [parts]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    dgv_parts.Rows.Add(Convert.ToString(sqlReader["Id"]), Convert.ToString(sqlReader["name"]),
                        Convert.ToString(sqlReader["parts_type"]), Convert.ToString(sqlReader["car"]),
                        Convert.ToString(sqlReader["amount"]), Convert.ToString(sqlReader["price"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }

        public Form3(int name)
        {
            InitializeComponent();
            customer_id = name;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private async void bt_order_Click(object sender, EventArgs e)
        {
            int[] id = new int[dgv_parts.SelectedRows.Count];
            int j = 0;
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = Convert.ToInt32(dgv_parts.SelectedRows[i].Cells[0].Value);
            }

            for (int i = 0; i < id.Length; i++)
            {
                command = new SqlCommand("INSERT INTO [order] (id_client, id_parts) VALUES (@ids, @parts)",
                    sqlConnection);
                command.Parameters.AddWithValue("ids", customer_id);
                command.Parameters.AddWithValue("parts", id[i]);
                await command.ExecuteNonQueryAsync();

                command = new SqlCommand("UPDATE [parts] SET [amount] = [amount] - 1 WHERE [Id]=@ids",
                    sqlConnection);
                command.Parameters.AddWithValue("ids", id[i]);
                await command.ExecuteNonQueryAsync();
            }

            refresh();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void bt_orders_Click(object sender, EventArgs e)
        {
            Form4 newform = new Form4(customer_id);
            newform.Show();
            newform.Focus();
        }
    }
}