using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;
            wynik_box.Text = "";
            Console.Out.WriteLine(m_box.Text);
            int m = int.Parse(m_box.Text);
            int z = int.Parse(z_box.Text);
            Random rnd = new Random();
            int d = 10;
            int l = 100000;
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = 0;
            single.X2 = 100;
            single.Area = Math.Pow(single.X2, 3) / 3 - Math.Pow(single.X1, 3) / 3;
            bool czy1 = false;
            bool czy2 = false;
            for (int j = 0; j < m; j++)
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0;
                double n = rnd.Next(d, l);
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i) * (i - old_i);

                    old_i = i;
                };
                if (Math.Abs(single.Area - f) / single.Area < z / 100.0 && !czy2)
                {

                    string wynik = "metoda prostokatów parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t\t";
                    wynik_box.Text += wynik;
                    czy1 = true;
                }
                f = 0.0F;

                n = rnd.Next(d, l);
                old_i = 0;
                for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };
                if (Math.Abs(single.Area - f) / single.Area < z / 100.0 && !czy1)
                {
                    string wynik = "metoda trapezów parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t";
                    wynik_box.Text += wynik;
                    czy2 = true;
                }
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;
            wynik_box.Text = "";
            int m = 1;
            double z = double.Parse(z_box.Text);
            Random rnd = new Random();
            int d = 10;
            int l = 100000;
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = 0;
            single.X2 = 100;
            single.Area = Math.Pow(single.X2, 4) / 4 - Math.Pow(single.X1, 4) / 4;
            int n = 0;
            bool czy1 = false;
            bool czy2 = false;

            while (true)
            {
                n += 1;

                f = 0.0F;
                int licz = 0;
                double old_i = 0;

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i * i) * (i - old_i);

                    old_i = i;
                };
                if (Math.Abs(single.Area - f) / single.Area < z / 100.0 && !czy1)
                {

                    string wynik = "metoda prostokatow parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t\t";
                    wynik_box.Text += wynik;
                    czy1 = true;
                }
                f = 0.0F;

                n = rnd.Next(d, l);
                old_i = 0;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i * i) + (old_i * old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };
                if (Math.Abs(single.Area - f) / single.Area < z / 100.0 && !czy2)
                {
                    string wynik = "metoda trapezów parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t";
                    wynik_box.Text += wynik;
                    czy2 = true;
                }
            };
        }

        private void button8_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;
            wynik_box.Text = "";

            int m = 6;
            double z = 0;
            Random rnd = new Random();
            int d = 10;
            int l = 100000;
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = double.Parse(x1_box.Text);
            single.X2 = double.Parse(x2_box.Text);
            single.Area = (single.X2 * single.X2 * single.X2) / 3 - (single.X1 * single.X1 * single.X1) / 3;
            double blad_kwadrat = 0;
            double blad_trapez = 0;
            for (int j = 0; j < m; j++)
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0;
                double n = Math.Pow(10, j + 1);

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i) * (i - old_i);

                    old_i = i;
                };



                f = 0.0F;

                n = Math.Pow(10, j + 1);
                old_i = 0;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };



            };
            string wynik2 = "blad sredniokwadratowy prostokąty = ";
            blad_kwadrat = blad_kwadrat / 6;
            wynik2 += blad_kwadrat.ToString();
            wynik2 += "   blad sredniokwadratowy trapezy = ";
            blad_trapez = blad_trapez / 6;
            wynik2 += blad_trapez.ToString();
            wynik_box.Text += wynik2;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;
            wynik_box.Text = "";
            double n = double.Parse(k_box.Text);
            n = Math.Pow(10, n);
            int z = int.Parse(z_box.Text);
            Random rnd = new Random();
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = double.Parse(x1_box.Text);
            single.X2 = double.Parse(x2_box.Text);
            single.Area = (Math.Pow(single.X1, 4) / 4) - (Math.Pow(single.X2, 4) / 4);
            while (true)
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0;

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i * i) * (i - old_i);

                    old_i = i;
                };

                double kwadrat_f = f;
                f = 0.0F;

                old_i = 0;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i * i) + (old_i * old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };
                bool czy = false;
                bool czy2 = false;
                if (Math.Floor(kwadrat_f) % z == 0 && !czy)
                {
                    string napis = "     prostokaty: X1 = " + single.X1.ToString() + "  X2 = " + single.X2.ToString();
                    wynik_box.Text += napis;
                    czy = true;
                }
                if (Math.Floor(f) % z == 0 && !czy2)
                {
                    string napis = "     trapez: X1 = " + single.X1.ToString() + "  X2 = " + single.X2.ToString();
                    wynik_box.Text += napis;
                    czy2 = true;
                }
                if (czy && czy2)
                {
                    break;
                }

                Console.Out.WriteLine(Math.Floor(kwadrat_f) % z);
                single.X2 += 0.1;

            };
        }

        private void button4_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;
            wynik_box.Text = "";
            double n = int.Parse(k_box.Text);
            n = Math.Pow(10, n);
            List<int> wartosci = new List<int>();


            Random rnd = new Random();

            double f = 0.0F;

            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = 0;
            single.X2 = 100;
            double f2 = 0.0F;
            for (int j = -10; j < 10; j++)
            {
                for (int j2 = -10; j2 < 10; j2++)
                {
                    single.X1 = j;
                    single.X2 = j2;
                    f = 0.0F;
                    f2 = 0.0F;
                    int licz = 0;
                    double old_i = 0;

                    for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                    {

                        licz += 1;
                        f += (i * i) * (i - old_i);

                        old_i = i;
                    };
                    for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                    {

                        licz += 1;
                        f2 += (i * i * i) * (i - old_i);

                        old_i = i;
                    };

                    if (f == f2)
                    {
                        string wynik = " prostokaty   x1 = " + single.X1.ToString() + " x2 = " + single.X2.ToString();
                        wynik_box.Text += wynik;
                    }

                    f = 0.0F;
                    f2 = 0.0F;
                    old_i = 0;
                    for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                    {

                        licz += 1;
                        f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                        old_i = i;
                    };
                    old_i = 0;
                    for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                    {

                        licz += 1;
                        f2 += (((i * i * i) + (old_i * old_i * old_i)) / 2) * (i - old_i);

                        old_i = i;
                    };
                    if (Math.Floor(f) == Math.Floor(f2))
                    {
                        string wynik = " trapezy   x1 = " + single.X1.ToString() + " x2 = " + single.X2.ToString();
                        wynik_box.Text += wynik;
                    }
                };
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;
            wynik_box.Text = "";

            double n = double.Parse(k_box.Text);
            n = Math.Pow(10, n);
            int m = int.Parse(m_box.Text);
            Random rnd = new Random();

            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = 0;
            single.X2 = 100;
            Random rmd = new Random();
            double min = Double.MaxValue;
            double min2 = Double.MaxValue;
            double minx11 = 0F;
            double minx12 = 0F;
            double minx21 = 0F;
            double minx22 = 0F;
            double minx111 = 0F;
            double minx112 = 0F;
            double minx121 = 0F;
            double minx122 = 0F;
            for (int j = 0; j < m; j++)
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0;


                single.X1 = rmd.Next(0, 50);
                single.X2 = rmd.Next(50, 100);

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i) * (i - old_i);

                    old_i = i;
                };
                double f1 = 0.0F;

                old_i = 0;

                double x1old = single.X1;
                double x2old = single.X2;

                single.X1 = rmd.Next(0, 50);
                single.X2 = rmd.Next(50, 100);

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {


                    f1 += (i * i * i) * (i - old_i);

                    old_i = i;
                };
                double roznica = Math.Abs(f - f1);
                if (roznica < min)
                {
                    min = roznica;
                    minx11 = x1old;
                    minx12 = x2old;
                    minx21 = single.X1;
                    minx22 = single.X2;
                }
                f = 0.0F;

                single.X1 = rmd.Next(0, 50);
                single.X2 = rmd.Next(50, 100);
                old_i = 0;
                for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };


                f1 = 0.0F;
                single.X1 = rmd.Next(0, 50);
                single.X2 = rmd.Next(50, 100);
                old_i = 0;
                for (double i = 0.0F; i <= 100.0; i = i + 100F / n)
                {

                    licz += 1;
                    f1 += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };

                roznica = Math.Abs(f - f1);
                if (roznica < min2)
                {
                    min = roznica;
                    minx111 = x1old;
                    minx112 = x2old;
                    minx121 = single.X1;
                    minx122 = single.X2;
                }
            };

            wynik_box.Text += "  prostokąty: x1 = " + minx11.ToString() + " x2 = " + minx12.ToString() + " x1 = " + minx21.ToString() + " x2 = " + minx22.ToString() + " roznica = " + min.ToString();
            wynik_box.Text += "  trapezy: x1 = " + minx111.ToString() + " x2 = " + minx112.ToString() + " x1 = " + minx121.ToString() + " x2 = " + minx122.ToString() + " roznica = " + min2.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {

            float true_wynik = 1000000 / 3;
            wynik_box.Text = "";
            int z = int.Parse(z_box.Text);
            Random rnd = new Random();

            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            bool czy1 = false;
            bool czy2 = false;
            single.X1 = double.Parse(x1_box.Text);
            single.X2 = double.Parse(x2_box.Text);
            for (double j = 10; j < 100000; j = j + 1)
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0;
                double n = j;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (i * i) * (i - old_i);

                    old_i = i;
                };
                if (Math.Floor(f) % z == 0)
                {
                    Console.Out.WriteLine("wartosc f = " + f.ToString() + " ");
                    wynik_box.Text += " prostokaty n = " + n.ToString();
                    czy1 = true;
                }
                f = 0.0F;

                n = j;
                old_i = 0;

                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += (((i * i) + (old_i * old_i)) / 2) * (i - old_i);

                    old_i = i;
                };

                if (Math.Floor(f) % z == 0)
                {
                    wynik_box.Text += " trapezy n = " + n.ToString();
                    czy2 = true;
                }
                if (czy1 && czy2)
                {
                    break;
                }
            };
        }

        private void button5_Click(object sender, EventArgs e)
        {



            wynik_box.Text = "";
            int z = int.Parse(z_box.Text);
            Random rnd = new Random();
            int d = 10;
            int l = 100000;
            double f = 0.0F;
            int o = 0;
            WindowsFormsApp.SingleCount single = new SingleCount();
            single.X1 = 0;
            single.X2 = Math.PI / 2;
            single.Area = Math.Sin(single.X2) - Math.Sin(single.X1);
            bool czy1 = false;
            bool czy2 = false;
            for (double n = 100000.0F; n > 0; n -= Math.Max(n * 0.1, 10))
            {


                f = 0.0F;
                int licz = 0;
                double old_i = 0.0F;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += Math.Cos(i) * (i - old_i);

                    old_i = i;
                };
                if ((Math.Abs(single.Area - f) / single.Area >= z / 100.0) && !czy1)
                {

                    string wynik = "metoda prostokatów parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t\t";
                    wynik_box.Text += wynik;
                    czy1 = true;
                }
                f = 0.0F;

                old_i = 0.0F;
                for (double i = single.X1; i <= single.X2; i = i + 100F / n)
                {

                    licz += 1;
                    f += ((Math.Cos(i) + Math.Cos(old_i)) / 2) * (i - old_i);

                    old_i = i;
                };
                if ((Math.Abs(single.Area - f) / single.Area >= z / 100.0) && !czy2)
                {
                    double xxx = f;

                    string wynik = "metoda trapezów parametry to n=";
                    wynik += n.ToString();
                    wynik += "  wynik to =";
                    wynik += f.ToString();
                    wynik += "\t\t";
                    wynik_box.Text += wynik;
                    czy2 = true;
                }
                if (czy1 && czy2)
                {
                    break;
                }
            };
        }
    }
}
