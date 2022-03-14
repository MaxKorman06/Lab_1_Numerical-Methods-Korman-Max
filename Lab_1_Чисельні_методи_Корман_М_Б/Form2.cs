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
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double m = Convert.ToDouble(textBox_m.Text), 
                   m_mis = Convert.ToDouble(textBox_m_mis.Text),
                   n = Convert.ToDouble(textBox_n.Text), 
                   n_mis = Convert.ToDouble(textBox_n_mis.Text), 
                   k = Convert.ToDouble(textBox_k.Text), 
                   k_mis = Convert.ToDouble(textBox_k_mis.Text),
                   m_del;

            m_del = (m * m_mis) / 100;

            label_m_ex.Text = "Δm = m * ∂m = " + m + " * " + m_mis + " = " + m_del;
        }

        private void button_save_func_Click(object sender, EventArgs e)
        {
            label_func.Text = textBox_func.Text;
            textBox_func.Clear();
        }

        private void button_clear_func_Click(object sender, EventArgs e)
        {
            label_func.Text = "((m + n) ^3) / (n ^0,5)";
        }
    }
}
