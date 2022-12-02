using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Учебная
{
    public partial class Four : Form
    {
        public Four()
        {
            InitializeComponent();
        }
        string server = "10.90.12.110";
        string port = "33333";
        string user = "st_1_20_32";
        string database = "is_1_20_st32_KURS";
        string password = "53092109";
        public string connStr;
        public string Connectreturn()   
        {
            return connStr = $"host={server};port={port};user={user};database={database};password={password}";
        }
    }
}
