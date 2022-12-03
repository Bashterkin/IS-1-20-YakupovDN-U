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
using static Four.Class1;

namespace Four
{
    public partial class Four : Form
    {
        MySqlConnection conn;
        Class1 connect;
        public Four()
        {
            InitializeComponent();
        }

        private void Four_Load(object sender, EventArgs e)
        {
            connect = new Class1();
            connect.Connectreturn();
            conn = new MySqlConnection(connect.connStr);
            try
            {
                conn.Open();
                string sql = "SELECT * FROM t_datatime";
                dataGridView1.Columns.Add("fio", "ФИО");
                dataGridView1.Columns["fio"].Width = 150;
                dataGridView1.Columns.Add("date_of_Birth", "Дата рождения"); // датагрид придумали садисты
                dataGridView1.Columns["date_of_Birth"].Width = 150;
                MySqlCommand command = new MySqlCommand(sql, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["fio"].ToString(), reader["date_of_Birth"].ToString());
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            conn.Open();

            // 1 - тоби
            // 2 - эндрю 
            // 3 - том

            // Переменная id берёт индекс строки и прибавляет 1, таким образом мы равняем переменную id с id пользователей в БД
            int id = dataGridView1.SelectedCells[0].RowIndex + 1;
            string url = $"SELECT photoUrl FROM t_datatime WHERE id = {id}";
            MySqlCommand com = new MySqlCommand(url, conn);
            string name = com.ExecuteScalar().ToString();
            conn.Close();
            pictureBox1.ImageLocation = $"{name}";
        }
    }
}
