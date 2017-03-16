using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietandBMIcalculator
{
    public partial class StronaKalkulatora : Form
    {
        int WagaCzlowieka;
        double WzrostCzlowieka;
        double WynikBmi;

        public StronaKalkulatora()
        {
            


            
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WzrostCzlowieka = (double)numericUpDown1.Value;
            WagaCzlowieka = (int)numericUpDown2.Value;


            if (WagaCzlowieka > WzrostCzlowieka)
            {
                
                WynikBmi = WagaCzlowieka / (WzrostCzlowieka * WzrostCzlowieka);
                Wynik.Text = "Twój wynik to : " + WynikBmi.ToString();
            }
            else
            {
                MessageBox.Show("Błędna wartość", "Nie można obliczyć");

            }

              
            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SprawdzWynik f3 = new SprawdzWynik();
            f3.Show();
        }
    }
    }

