using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Kursovaya
{
    
    public partial class Form1 : Form
    {
        public SqlConnection sqlConnection;
        public SqlCommand command;
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Clair\source\repos\Kursovaya\Kursovaya\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private async void refresh()
        {
            dataGridView1.Rows.Clear();
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            command = new SqlCommand("SELECT * FROM [customer]", sqlConnection);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                
                while (await sqlReader.ReadAsync())
                {
                    dataGridView1.Rows.Add(Convert.ToString(sqlReader["name"]));
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

        private async void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            newForm.Focus();
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void bt_choose_Click(object sender, EventArgs e)
        {
            string name = dataGridView1.SelectedCells[0].Value.ToString();
            Form3 newform = new Form3(name);
            newform.Show();
            newform.Focus();
        }
    }
}
