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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clair\source\repos\Kursovaya\Kursovaya\Database1.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlCommand command;
            command = new SqlCommand("INSERT INTO [customer] (name) VALUES (@name)", sqlConnection);
                command.Parameters.AddWithValue("name", tb_username.Text);
                await command.ExecuteNonQueryAsync();
                this.Close();
        }
    }
}
