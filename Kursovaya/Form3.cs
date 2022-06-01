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
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clair\source\repos\Kursovaya\Kursovaya\Database1.mdf;Integrated Security=True";
        private string customer_name;
        private async void refresh()
        {
            dgv_parts.Rows.Clear();
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            command = new SqlCommand("SELECT * FROM [customer]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                
                while (await sqlReader.ReadAsync())
                {
                    dgv_parts.Rows.Add(Convert.ToString(sqlReader["Id"]),Convert.ToString(sqlReader["name"]),Convert.ToString(sqlReader["parts_type"]),Convert.ToString(sqlReader["car"]),Convert.ToString(sqlReader["amount"]),Convert.ToString(sqlReader["price"]));
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

        public Form3(string name)
        {
            InitializeComponent();
            customer_name = name;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
