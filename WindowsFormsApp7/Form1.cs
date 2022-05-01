using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Mas = new int[18];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 0; i < 18; i++)
            {
                Mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add("Mas[" + i.ToString() + "] = " + Mas[i].ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double[] P = new double[18];
            listBox2.Items.Clear();
            for (int i = 0; i < 18; i++)            
            {
                P[i] = 0.13 * Mas[i] * Mas[i] * Mas[i] - 2.5 * Mas[i] + 8.0;
                listBox2.Items.Add("Mas[" + Convert.ToString(i) + "] = " + P[i].ToString());

            }
        }       
    }
}
