using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static Учебная.Program;


namespace Учебная
{
    public partial class Three : Form
    {
            
            MySqlConnection conn;
            Conn connect;

        public Three()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                conn.Open();
                string sql = "SELECT * FROM Hotel";
                dataGridView1.Columns.Add("id_hotel", "ID Отеля");
                dataGridView1.Columns["id_hotel"].Width = 100;
                dataGridView1.Columns.Add("name_hotel", "Название");
                dataGridView1.Columns["name_hotel"].Width = 185;
                dataGridView1.Columns.Add("stars_hotel", "Количество звёзд");       // датагрид придумали садисты
                dataGridView1.Columns["stars_hotel"].Width = 185;
                dataGridView1.Columns.Add("country_hotel", "Страна");
                dataGridView1.Columns["country_hotel"].Width = 100;
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // ридер заполняет строки в гриде
                    dataGridView1.Rows.Add(reader["id_hotel"].ToString(), reader["name_hotel"].ToString(), reader["stars_hotel"].ToString(), reader["country_hotel"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void Three_Load(object sender, EventArgs e)
        {
            //  Объявляем подключение
            connect = new Conn();
            connect.Connectreturn();
            conn = new MySqlConnection(connect.connStr);
        }
    }
}
