using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Kursovaya
{
    public partial class Form4 : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand command;

        public static string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clair\source\repos\Kursovaya\Kursovaya\Database1.mdf;Integrated Security=True";

        private int id_client;

        public Form4(int id)
        {
            InitializeComponent();
            id_client = id;
        }

        private async void Form4_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            command = new SqlCommand(
                "SELECT * FROM [parts] join [order] on [order].[id_client] = @id_client AND [parts].[Id] = [order].[id_parts]",
                sqlConnection);
            command.Parameters.AddWithValue("id_client", id_client);
            sqlReader = await command.ExecuteReaderAsync();

            while (await sqlReader.ReadAsync())
            {
                dgv_orders.Rows.Add(Convert.ToString(sqlReader["Id"]), Convert.ToString(sqlReader["name"]),
                    Convert.ToString(sqlReader["parts_type"]), Convert.ToString(sqlReader["car"]),
                    Convert.ToString(sqlReader["amount"]), Convert.ToString(sqlReader["price"]));
            }

            for (int k = 0; k < dgv_orders.Rows.Count; k++)
            {
                int eq = Convert.ToInt32(dgv_orders.Rows[k].Cells[0].Value);
                int count = 1;
                for (int i = k + 1; i < dgv_orders.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgv_orders.Rows[i].Cells[0].Value) == eq)
                    {
                        count++;
                    }
                }

                dgv_orders.Rows[k].Cells[4].Value = count;
                dgv_orders.Rows[k].Cells[5].Value = Convert.ToInt32(dgv_orders.Rows[k].Cells[5].Value) * count;
                for (int i = k + 1; i < dgv_orders.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgv_orders.Rows[i].Cells[0].Value) == eq)
                    {
                        dgv_orders.Rows.RemoveAt(i);
                        Debug.Write("удалил говно " + i);
                    }
                }
            }

            //dgv_orders.Rows.RemoveAt(1);
            dgv_orders.Refresh();
            int sum = 0;
            for (int i = 0; i < dgv_orders.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dgv_orders.Rows[i].Cells[5].Value);
            }

            dgv_orders.Rows.Add("", "", "", "", "Итого:", sum);
            if (sqlReader != null)
            {
                sqlReader.Close();
            }
        }
    }
}