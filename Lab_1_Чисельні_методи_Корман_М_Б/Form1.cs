using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_Чисельні_методи_Корман_М_Б
{
     public partial class Form1 : Form
     {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e) // Кнопка виходу
        {
            Application.Exit();
        }

        private void button_clear_Click(object sender, EventArgs e) // Кнопка очищення textbox та label
        {
            textBox_divd.Clear();
            textBox_divr.Clear();
            textBox_frac.Clear();
            textBox_squ_d.Clear();
            textBox_squ_u.Clear();

            example1.Text = "example";
            example2.Text = "example";
            example3.Text = "example";
            example4.Text = "example";
            example5.Text = "example";
            example6.Text = "example";

            expression.Text = "4) Оскільки expression, то рівність example є більш тотожною.";
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double divd = Convert.ToDouble(textBox_divd.Text),      // Отримання значень змінних із textbox
                   divr = Convert.ToDouble(textBox_divr.Text),      //
                   frac = Convert.ToDouble(textBox_frac.Text),      //
                   squ_d = Convert.ToDouble(textBox_squ_d.Text),    //
                   squ_u = Convert.ToDouble(textBox_squ_u.Text);    //

            double rep_div, rep_squ;

            rep_squ = Math.Sqrt(squ_d);
            rep_div = div_func(divd, divr);

            double ab_div, ab_squ;

            ab_squ = sub_func(rep_squ, squ_u);
            ab_div = sub_func(rep_div, frac);

            double rel_div, rel_squ;

            rel_div = div_func(ab_squ, squ_u);
            rel_squ = div_func(ab_div, frac);

            string str_example1 =  divd + " / " + divr + " = " + rep_div,                       // Виведення всіх операцій на екран
                   str_example2 = "√" + squ_d + " = " + rep_squ,                                //
                   str_example3 = "Δ1 = " + rep_div + " - " + frac + " = " + ab_div,            //
                   str_example4 = "Δ2 = " + rep_squ + " - " + squ_u + " = " + ab_squ,           //
                   str_example5 = "∂1 = Δ1 / a1 = " + ab_div + " / " + frac + " = " + rel_squ,  //
                   str_example6 = "∂2 = Δ2 / a2 = " + ab_squ + " / " + squ_u + " = " + rel_div; //
                                                                                                //
            example1.Text = str_example1;                                                       //
            example2.Text = str_example2;                                                       //
            example3.Text = str_example3;                                                       //
            example4.Text = str_example4;                                                       //
            example5.Text = str_example5;                                                       //
            example6.Text = str_example6;                                                       //

            if (squ_u >= 0) // Операція порівняння точночті виразів
            {
                if (Math.Abs(rel_div) > Math.Abs(rel_squ))
                {
                    expression.Text = "4) Оскільки ∂1 < ∂2, то рівність " + divd + " / " + divr + " = " + frac + " є більш тотожною.";
                }
                if (Math.Abs(rel_div) < Math.Abs(rel_squ))
                {
                    expression.Text = "4) Оскільки ∂1 > ∂2, то рівність " + "√" + squ_d + " = " + squ_u + " є більш тотожною.";
                }
                if (Math.Abs(rel_div) == Math.Abs(rel_squ))
                {
                    expression.Text = "4) Оскільки ∂1 = ∂2, то рівність " + "NONE" + " є більш тотожною.";
                }
            }
            if (squ_u < 0)
            { 
                expression.Text = "4) Оскільки ∂2 < 0, то рівність " + divd + " / " + divr + " = " + frac + " є більш тотожною.";
            }
        }

        private void button_ex2_Click(object sender, EventArgs e) // Кнопка входу до завдання 2
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }
        public static double div_func(double divd, double divr) // Функція ділення
        {
            double sum;

            sum = divd / divr;

            return sum;
        }
        public static double sub_func(double red, double sub) // Функція віднімання
        {
            double frac;

            frac = red - sub;

            return frac;
        }
     }
}
