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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_k.Clear();
            textBox_k_mis.Clear();
            textBox_m.Clear();
            textBox_m_mis.Clear();
            textBox_n.Clear();
            textBox_n_mis.Clear();

            label_m_ex.Text = "example";
            label_example1.Text = "example";
            label_example2.Text = "example";
            label_example3.Text = "example";
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox_m.Text),
                   m_mis = Convert.ToDouble(textBox_m_mis.Text),
                   n = Convert.ToDouble(textBox_n.Text),
                   n_mis = Convert.ToDouble(textBox_n_mis.Text),
                   k = Convert.ToDouble(textBox_k.Text),
                   k_mis = Convert.ToDouble(textBox_k_mis.Text),
                   m_del,
                   app_val,
                   abs_err,
                   rel_err;

            m_del = (m * m_mis) / 100;

            label_m_ex.Text = "Δm = m * ∂m = " + m + " * " + m_mis + " = " + m_del;

            abs_err = (Math.Abs(((3 * Math.Pow(m, 2)) - (6 * m * k) + (3 * Math.Pow(k, 2))) / (Math.Sqrt(n))) * m_del) +
                      (Math.Abs(((3 * Math.Pow(m, 2)) - (6 * m * k) + (3 * Math.Pow(k, 2))) / (Math.Sqrt(n))) * k_mis) +
                      (Math.Abs(-((Math.Pow((m - k), 3)) / (2 * n * (Math.Sqrt(n)))))) * (n_mis);

            app_val = Math.Pow((m - k), 3) / Math.Sqrt(n);

            rel_err = abs_err / app_val;

            string str_example_1 = "Δ(∫*) = |(3∙" + m + "^2" + " - 6∙" + m + "∙" + k + " + 3∙" + k + "^2) / √" + n + "|∙" + m_del + " + \n + " +
                                   "|(3∙" + m + "^2" + " - 6∙" + m + "∙" + k + " + 3∙" + k + "^2) / √" + n + "|∙" + k_mis + " + \n + " +
                                   "|-(" + m + " - " + k + ")^3 / 2∙" + n + "∙√" + n + "|" + "∙" + n_mis + " = " + abs_err,

                   str_example_2 = "∫(x*, y*, z*) = ((" + m + " - " + k + ") ^ 3) / " + "(√" + n + ") = " + app_val,
                   str_example_3 = "∂(∫*) = " + abs_err + " / " + app_val + " =\n= " + rel_err;

            label_example1.Text = str_example_1;
            label_example2.Text = str_example_2;
            label_example3.Text = str_example_3;

        }
    }
}
