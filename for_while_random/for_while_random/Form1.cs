using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_while_random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                lstbox_for.Items.Add(i);
            }
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (true)
            {
                lstbox_while.Items.Add(i);
                i++;
                if (i == 10)
                    break;
            }
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            lstbox_random.Items.Clear();
            Random rnd = new Random();

            while (true)
            {
                int sayi = rnd.Next(0, 20);
                lstbox_random.Items.Add(sayi);
                if (rnd.Next(20) <= 0)
                    break;

            }
        }
    }
}
