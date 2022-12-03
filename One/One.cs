using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One
{
    public partial class One : Form
    {
        public One()
        {
            InitializeComponent();
        }

        private void Onee_Load(object sender, EventArgs e)
        {

        }
        public abstract class Сomponents<P>
        {
            public P articul;
            public int price;
            public int date;
            public Сomponents(int Price, int Date, P Articul)
            {
                price = Price;
                date = Date;
                articul = Articul;
            }
            public string Display()
            {
                return($"Артикул: {articul} Цена:{price} Год выпуска: {date} ");
            }
        }
        public class Harddrive<P> : Сomponents<P>
        {
            public int turnovers { get; set; }
            public string interfac { get; set; }
            public int volume { get; set; }

            public Harddrive(int Price, int Date, int Turnovers, string Interfac, int Volume, P Articul) : base(Price, Date, Articul)
            {
                turnovers = Turnovers;
                interfac = Interfac;
                volume = Volume;

            }

            public new string Display()
            {
                return($"Артикул:{articul} Цена:{price} Год выпуска: {date} Количество оборотов: {turnovers} Интерфейс: {interfac} Объем: {volume} Гб");
            }
        }
        class Videocard<P> : Сomponents<P>
        {
            public int freq { get; set; }
            public string manufacturer { get; set; }
            public int memory { get; set; }
            public Videocard(int Price, int Date, int Freq, string Manufacturer, int Memory, P Articul) : base(Price, Date, Articul)
            {
                freq = Freq;
                manufacturer = Manufacturer;
                memory = Memory;
            }
            public new string Display()
            {
                return($"Артикул: {articul} Цена: {price} Год выпуска: {date} Частота: {freq} Производитель: {manufacturer} Видеопамять: {memory} Гб");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Harddrive<int> v1 = new Harddrive<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox9.Text));
            listBox1.Items.Add(v1.Display());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Videocard<int> v1 = new Videocard<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text));
            listBox1.Items.Add(v1.Display());
        }
    }
}
