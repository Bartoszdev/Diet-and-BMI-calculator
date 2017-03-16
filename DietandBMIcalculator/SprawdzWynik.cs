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
    public partial class SprawdzWynik : Form
    {
        public SprawdzWynik()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.Hide();
            StronaKalkulatora f2 = new StronaKalkulatora();
            f2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wynik BMI : Niedowaga" , "Twój Wynik");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wynik BMI : W normie", "Twój Wynik");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wynik BMI : Nadwaga", "Twój Wynik");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wynik BMI : Otyłość" , "Twój Wynik");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wynik BMI : Duża otyłość", "Twój Wynik");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wynik BMI : Ekstremalna otyłość", "Twój Wynik");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
