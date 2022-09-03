using P02AplikacjaPogodaUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03AsynchronicznaPogoda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //}

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            ManagerPogody mp = new ManagerPogody(Jednostka.Celcjusz);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string miasto = listBox1.Items[i].ToString();

                var t = Task.Run<double>(() =>
                {
                    double d = mp.PodajTemperature(miasto);
                    return d;
                });

                t.GetAwaiter().OnCompleted(() =>
                {
                    listBox2.Items.Add($"temp w miescie {miasto} wynosi {t.Result}");
                });
                //listBox2.Items.Add($"temp w miescie {miasto} wynosi {temp}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            ManagerPogody mp = new ManagerPogody(Jednostka.Celcjusz);

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string miasto = listBox1.Items[i].ToString();
                double temp = mp.PodajTemperature(miasto);

                listBox2.Items.Add($"temp w miescie {miasto} wynosi {temp}");
            }
        }
    }
}