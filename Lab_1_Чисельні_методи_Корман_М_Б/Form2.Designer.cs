
namespace Lab_1_Чисельні_методи_Корман_М_Б
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_clear = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_m = new System.Windows.Forms.TextBox();
            this.textBox_n = new System.Windows.Forms.TextBox();
            this.textBox_k = new System.Windows.Forms.TextBox();
            this.textBox_m_mis = new System.Windows.Forms.TextBox();
            this.textBox_n_mis = new System.Windows.Forms.TextBox();
            this.textBox_k_mis = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_func = new System.Windows.Forms.Label();
            this.label_m_ex = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_example1 = new System.Windows.Forms.Label();
            this.label_example2 = new System.Windows.Forms.Label();
            this.label_example3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(168, 358);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(66, 66);
            this.button_clear.TabIndex = 7;
            this.button_clear.Text = "AC";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_calculate.Location = new System.Drawing.Point(12, 358);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(150, 30);
            this.button_calculate.TabIndex = 6;
            this.button_calculate.Text = "Обчислити";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(12, 394);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 30);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Вихід";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Функція";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введіть дані";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "m =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "n =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "k =";
            // 
            // textBox_m
            // 
            this.textBox_m.Location = new System.Drawing.Point(65, 217);
            this.textBox_m.Name = "textBox_m";
            this.textBox_m.Size = new System.Drawing.Size(39, 20);
            this.textBox_m.TabIndex = 13;
            // 
            // textBox_n
            // 
            this.textBox_n.Location = new System.Drawing.Point(60, 264);
            this.textBox_n.Name = "textBox_n";
            this.textBox_n.Size = new System.Drawing.Size(44, 20);
            this.textBox_n.TabIndex = 14;
            // 
            // textBox_k
            // 
            this.textBox_k.Location = new System.Drawing.Point(59, 312);
            this.textBox_k.Name = "textBox_k";
            this.textBox_k.Size = new System.Drawing.Size(45, 20);
            this.textBox_k.TabIndex = 15;
            // 
            // textBox_m_mis
            // 
            this.textBox_m_mis.Location = new System.Drawing.Point(140, 216);
            this.textBox_m_mis.Name = "textBox_m_mis";
            this.textBox_m_mis.Size = new System.Drawing.Size(60, 20);
            this.textBox_m_mis.TabIndex = 16;
            // 
            // textBox_n_mis
            // 
            this.textBox_n_mis.Location = new System.Drawing.Point(140, 263);
            this.textBox_n_mis.Name = "textBox_n_mis";
            this.textBox_n_mis.Size = new System.Drawing.Size(60, 20);
            this.textBox_n_mis.TabIndex = 17;
            // 
            // textBox_k_mis
            // 
            this.textBox_k_mis.Location = new System.Drawing.Point(140, 312);
            this.textBox_k_mis.Name = "textBox_k_mis";
            this.textBox_k_mis.Size = new System.Drawing.Size(60, 20);
            this.textBox_k_mis.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(110, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "±";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(110, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "±";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(110, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "±";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(203, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "%";
            // 
            // label_func
            // 
            this.label_func.AutoSize = true;
            this.label_func.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_func.Location = new System.Drawing.Point(9, 63);
            this.label_func.Name = "label_func";
            this.label_func.Size = new System.Drawing.Size(95, 25);
            this.label_func.TabIndex = 23;
            this.label_func.Text = "(m - k)^3";
            // 
            // label_m_ex
            // 
            this.label_m_ex.AutoSize = true;
            this.label_m_ex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_m_ex.Location = new System.Drawing.Point(263, 14);
            this.label_m_ex.Name = "label_m_ex";
            this.label_m_ex.Size = new System.Drawing.Size(68, 20);
            this.label_m_ex.TabIndex = 29;
            this.label_m_ex.Text = "example";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(262, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Розв\'язок";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(263, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Абсолютна похибка:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(263, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(412, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Знайдемо значення функції у наближених значеннях:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(263, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "Відносна пожибка:";
            // 
            // label_example1
            // 
            this.label_example1.AutoSize = true;
            this.label_example1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_example1.Location = new System.Drawing.Point(263, 105);
            this.label_example1.Name = "label_example1";
            this.label_example1.Size = new System.Drawing.Size(68, 20);
            this.label_example1.TabIndex = 34;
            this.label_example1.Text = "example";
            // 
            // label_example2
            // 
            this.label_example2.AutoSize = true;
            this.label_example2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_example2.Location = new System.Drawing.Point(263, 236);
            this.label_example2.Name = "label_example2";
            this.label_example2.Size = new System.Drawing.Size(68, 20);
            this.label_example2.TabIndex = 35;
            this.label_example2.Text = "example";
            // 
            // label_example3
            // 
            this.label_example3.AutoSize = true;
            this.label_example3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_example3.Location = new System.Drawing.Point(263, 333);
            this.label_example3.Name = "label_example3";
            this.label_example3.Size = new System.Drawing.Size(68, 20);
            this.label_example3.TabIndex = 36;
            this.label_example3.Text = "example";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "—————————————";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(25, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 25);
            this.label15.TabIndex = 38;
            this.label15.Text = "n^0,5";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_example3);
            this.Controls.Add(this.label_example2);
            this.Controls.Add(this.label_example1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_m_ex);
            this.Controls.Add(this.label_func);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_k_mis);
            this.Controls.Add(this.textBox_n_mis);
            this.Controls.Add(this.textBox_m_mis);
            this.Controls.Add(this.textBox_k);
            this.Controls.Add(this.textBox_n);
            this.Controls.Add(this.textBox_m);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.button_exit);
            this.Name = "Form2";
            this.Text = "Обчислити та визначити похибку результату";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_m;
        private System.Windows.Forms.TextBox textBox_n;
        private System.Windows.Forms.TextBox textBox_k;
        private System.Windows.Forms.TextBox textBox_m_mis;
        private System.Windows.Forms.TextBox textBox_n_mis;
        private System.Windows.Forms.TextBox textBox_k_mis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_func;
        private System.Windows.Forms.Label label_m_ex;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label_example1;
        private System.Windows.Forms.Label label_example2;
        private System.Windows.Forms.Label label_example3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
    }
}