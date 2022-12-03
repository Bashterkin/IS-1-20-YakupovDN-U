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
                string sql = "SELECT hotel_contract, pricetour_contract, employ_contract, tour_contract, fio_contractor, id_contract, id_contractor FROM Contract INNER JOIN Contractor ON id_contract = id_contractor ORDER BY id_contract;";
                dataGridView1.Columns.Add("id_contract", "ID Контракта");
                dataGridView1.Columns["id_contract"].Width = 50;
                dataGridView1.Columns.Add("hotel_contract", "Отель");
                dataGridView1.Columns["hotel_contract"].Width = 150;
                dataGridView1.Columns.Add("pricetour_contract", "Цена тура");
                dataGridView1.Columns["pricetour_contract"].Width = 70;
                dataGridView1.Columns.Add("employ_contract", "Сотрудник");
                dataGridView1.Columns["employ_contract"].Width = 150;
                dataGridView1.Columns.Add("tour_contract", "Страна");
                dataGridView1.Columns["tour_contract"].Width = 70;
                dataGridView1.Columns.Add("fio_contractor", "ФИО");
                dataGridView1.Columns["fio_contractor"].Width = 150;
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // ридер заполняет строки в гриде
                    dataGridView1.Rows.Add(reader["id_contract"].ToString(), reader["hotel_contract"].ToString(), reader["pricetour_contract"].ToString(), reader["employ_contract"].ToString(), reader["tour_contract"].ToString(), reader["fio_contractor"].ToString());
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
