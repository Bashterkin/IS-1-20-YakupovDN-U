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
using static Three.Program;

namespace Three
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
                string sql = "SELECT * FROM Contract";
                dataGridView1.Columns.Add("id_contract", "ID Контракта");
                dataGridView1.Columns["id_contract"].Width = 50;
                dataGridView1.Columns.Add("hotel_contract", "Отель");
                dataGridView1.Columns["hotel_contract"].Width = 150;
                dataGridView1.Columns.Add("pricetour_contract", "Цена тура");       // датагрид придумали садисты
                dataGridView1.Columns["pricetour_contract"].Width = 70;
                dataGridView1.Columns.Add("tour_contract", "Страна");
                dataGridView1.Columns["tour_contract"].Width = 70;
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
              //Объявляем подключение
            connect = new Conn();
            connect.Connectreturn();
            conn = new MySqlConnection(connect.connStr);
        }
    }
}
