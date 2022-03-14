
namespace Lab_1_Чисельні_методи_Корман_М_Б
{
    partial class Form1
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_calculate = new System.Windows.Forms.Button();
            this.button_ex2 = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_squ_d = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_frac = new System.Windows.Forms.TextBox();
            this.textBox_divr = new System.Windows.Forms.TextBox();
            this.textBox_divd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_squ_u = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.expression = new System.Windows.Forms.Label();
            this.example1 = new System.Windows.Forms.Label();
            this.example2 = new System.Windows.Forms.Label();
            this.example4 = new System.Windows.Forms.Label();
            this.example3 = new System.Windows.Forms.Label();
            this.example6 = new System.Windows.Forms.Label();
            this.example5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_exit.Location = new System.Drawing.Point(12, 361);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(150, 30);
            this.button_exit.TabIndex = 0;
            this.button_exit.Text = "Вихід";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_calculate
            // 
            this.button_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_calculate.Location = new System.Drawing.Point(12, 325);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(150, 30);
            this.button_calculate.TabIndex = 1;
            this.button_calculate.Text = "Обчислити";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // button_ex2
            // 
            this.button_ex2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ex2.Location = new System.Drawing.Point(12, 397);
            this.button_ex2.Name = "button_ex2";
            this.button_ex2.Size = new System.Drawing.Size(222, 30);
            this.button_ex2.TabIndex = 3;
            this.button_ex2.Text = "Перейти до завдання 2";
            this.button_ex2.UseVisualStyleBackColor = true;
            this.button_ex2.Click += new System.EventHandler(this.button_ex2_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(168, 325);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(66, 66);
            this.button_clear.TabIndex = 4;
            this.button_clear.Text = "AC";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введіть дані";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(73, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вираз 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(73, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вираз 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "√";
            // 
            // textBox_squ_d
            // 
            this.textBox_squ_d.Location = new System.Drawing.Point(37, 100);
            this.textBox_squ_d.Name = "textBox_squ_d";
            this.textBox_squ_d.Size = new System.Drawing.Size(44, 20);
            this.textBox_squ_d.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(87, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(136, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "=";
            // 
            // textBox_frac
            // 
            this.textBox_frac.Location = new System.Drawing.Point(166, 209);
            this.textBox_frac.Name = "textBox_frac";
            this.textBox_frac.Size = new System.Drawing.Size(44, 20);
            this.textBox_frac.TabIndex = 14;
            // 
            // textBox_divr
            // 
            this.textBox_divr.Location = new System.Drawing.Point(86, 209);
            this.textBox_divr.Name = "textBox_divr";
            this.textBox_divr.Size = new System.Drawing.Size(44, 20);
            this.textBox_divr.TabIndex = 13;
            // 
            // textBox_divd
            // 
            this.textBox_divd.Location = new System.Drawing.Point(12, 210);
            this.textBox_divd.Name = "textBox_divd";
            this.textBox_divd.Size = new System.Drawing.Size(44, 20);
            this.textBox_divd.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(62, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "/";
            // 
            // textBox_squ_u
            // 
            this.textBox_squ_u.Location = new System.Drawing.Point(116, 101);
            this.textBox_squ_u.Name = "textBox_squ_u";
            this.textBox_squ_u.Size = new System.Drawing.Size(44, 20);
            this.textBox_squ_u.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(240, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Розв\'язок";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(241, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(522, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "1) Знайти значення виразів з великою кількістю десядкових знаків:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(241, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(261, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "2) Обчислити абсолютні похибки:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(241, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "3) Обчислити відносні похибки:";
            // 
            // expression
            // 
            this.expression.AutoSize = true;
            this.expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expression.Location = new System.Drawing.Point(241, 407);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(472, 20);
            this.expression.TabIndex = 24;
            this.expression.Text = "4) Оскільки expression, то рівність example є більш тотожною.";
            // 
            // example1
            // 
            this.example1.AutoSize = true;
            this.example1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.example1.Location = new System.Drawing.Point(241, 88);
            this.example1.Name = "example1";
            this.example1.Size = new System.Drawing.Size(68, 20);
            this.example1.TabIndex = 25;
            this.example1.Text = "example";
            // 
            // example2
            // 
            this.example2.AutoSize = true;
            this.example2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.example2.Location = new System.Drawing.Point(241, 117);
            this.example2.Name = "example2";
            this.example2.Size = new System.Drawing.Size(68, 20);
            this.example2.TabIndex = 26;
            this.example2.Text = "example";
            // 
            // example4
            // 
            this.example4.AutoSize = true;
            this.example4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.example4.Location = new System.Drawing.Point(241, 233);
            this.example4.Name = "example4";
            this.example4.Size = new System.Drawing.Size(68, 20);
            this.example4.TabIndex = 28;
            this.example4.Text = "example";
            // 
            // example3
            // 
            this.example3.AutoSize = true;
            this.example3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.example3.Location = new System.Drawing.Point(241, 204);
            this.example3.Name = "example3";
            this.example3.Size = new System.Drawing.Size(68, 20);
            this.example3.TabIndex = 27;
            this.example3.Text = "example";
            // 
            // example6
            // 
            this.example6.AutoSize = true;
            this.example6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.example6.Location = new System.Drawing.Point(241, 361);
            this.example6.Name = "example6";
            this.example6.Size = new System.Drawing.Size(68, 20);
            this.example6.TabIndex = 30;
            this.example6.Text = "example";
            // 
            // example5
            // 
            this.example5.AutoSize = true;
            this.example5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.example5.Location = new System.Drawing.Point(241, 332);
            this.example5.Name = "example5";
            this.example5.Size = new System.Drawing.Size(68, 20);
            this.example5.TabIndex = 29;
            this.example5.Text = "example";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.example6);
            this.Controls.Add(this.example5);
            this.Controls.Add(this.example4);
            this.Controls.Add(this.example3);
            this.Controls.Add(this.example2);
            this.Controls.Add(this.example1);
            this.Controls.Add(this.expression);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_squ_u);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_divd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_frac);
            this.Controls.Add(this.textBox_divr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_squ_d);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_ex2);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.button_exit);
            this.Name = "Form1";
            this.Text = "Визначити, яка рівність точніша";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_calculate;
        private System.Windows.Forms.Button button_ex2;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_squ_d;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_frac;
        private System.Windows.Forms.TextBox textBox_divr;
        private System.Windows.Forms.TextBox textBox_divd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_squ_u;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label expression;
        private System.Windows.Forms.Label example1;
        private System.Windows.Forms.Label example2;
        private System.Windows.Forms.Label example4;
        private System.Windows.Forms.Label example3;
        private System.Windows.Forms.Label example6;
        private System.Windows.Forms.Label example5;
    }
}

