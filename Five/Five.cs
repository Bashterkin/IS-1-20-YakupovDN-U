using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Four;
using MySql.Data.MySqlClient;
using static Four.Class1;

namespace Five
{
    public partial class Five : Form
    {
        MySqlConnection conn;
        Class1 connect;
        public Five()
        {
            InitializeComponent();
        }

        private void Five_Load(object sender, EventArgs e)
        {
            connect = new Class1();
            connect.Connectreturn();
            conn = new MySqlConnection(connect.connStr);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text;
                DateTime date = DateTime.Now;
                conn.Open();
                string add = 
                    $"INSERT INTO t_Uchebka_Yakupov(fioStud, datetimeStud) " +
                    $"VALUES ('{name}', '{String.Format("{0:s}", date)}');" +
                    $"SELECT idStud FROM t_Uchebka_Yakupov WHERE(idStud = LAST_INSERT_ID());";
                MySqlCommand command = new MySqlCommand(add, conn);
                command.ExecuteScalar();
                MessageBox.Show("Данные введены");
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Обязательное поле");
                }
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
    }
}
