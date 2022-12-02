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
    public partial class One : Form
    {
        public One()
        {
            InitializeComponent();
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
            public void Display()
            {
                MessageBox.Show($"Артикул: {articul}\nЦена:{price}\nГод выпуска: {date} ");
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

            public new void Display()
            {
                MessageBox.Show($"Артикул: {articul}\nЦена:{price}\nГод выпуска: {date}\nКоличество оборотов: {turnovers}\nИнтерфейс: {interfac}\nОбъем: {volume} Гб");
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
            public new void Display()
            {
                MessageBox.Show($"Артикул: {articul}\nЦена: {price}\nГод выпуска: {date}\nЧастота: {freq}\nПроизводитель: {manufacturer}\nВидеопамять: {memory} Гб");
            }
        }

        private void One_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"Артикул: {textBox9.Text}");
            listBox1.Items.Add($"Цена: {textBox1.Text}");
            listBox1.Items.Add($"Год Выпуска: {textBox2.Text}");
            listBox1.Items.Add($"Частота оборотов: {textBox3.Text}");
            listBox1.Items.Add($"Интерфейс: {textBox4.Text}");
            listBox1.Items.Add($"Объем: {textBox5.Text} Гб");
            Harddrive<int> v1 = new Harddrive<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), textBox4.Text, Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox9.Text));
            v1.Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add($"Артикул: {textBox9.Text}");
            listBox1.Items.Add($"Цена: {textBox1.Text}");
            listBox1.Items.Add($"Год Выпуска: {textBox2.Text}"); // стандартная практика
            listBox1.Items.Add($"Частота: {textBox6.Text}");
            listBox1.Items.Add($"Производитель: {textBox7.Text}");
            listBox1.Items.Add($"Видеопамять: {textBox8.Text} Гб");
            Videocard<int> v1 = new Videocard<int>(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox6.Text), textBox7.Text, Convert.ToInt32(textBox8.Text), Convert.ToInt32(textBox9.Text));
            v1.Display();
        }
    }
}
