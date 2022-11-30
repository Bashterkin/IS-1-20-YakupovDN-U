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

namespace Учебная
{
    public partial class Two : Form
    {
        public Two()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        Conn connect;

        class Conn
        {
            string server = "chuc.caseum.ru";
            string port = "33333";
            string user = "uchebka";
            string database = "uchebka";
            string password = "uchebka";
            public string connStr;
            public string Connectreturn()
            {
                return connStr = $"host={server};port={port};user={user};database={database};password={password}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connect = new Conn();
                connect.Connectreturn();
                conn = new MySqlConnection(connect.connStr);
                conn.Open();
                MessageBox.Show("Подключение открыто");

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
