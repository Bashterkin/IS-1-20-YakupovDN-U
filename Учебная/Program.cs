﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учебная
{
    internal static class Program
    {
        public class Conn
        {
            // реквизиты входа
            string server = "10.90.12.110";
            string port = "33333";
            string user = "st_1_20_32";
            string database = "is_1_20_st32_KURS";
            string password = "53092109";
            public string connStr;
            public string Connectreturn()   //метод возвращающий строку подключения
            {
                return connStr = $"host={server};port={port};user={user};database={database};password={password}";
            }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
