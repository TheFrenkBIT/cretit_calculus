using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace credit_calculus
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderText = "Месяц";
            dataGridView1.Columns[1].HeaderText = "Аннуитетный платеж";
            dataGridView1.Columns[2].HeaderText = "Платеж по кредиту";
            dataGridView1.Columns[3].HeaderText = "Платеж по процентам";
            dataGridView1.Columns[4].HeaderText = "Остаток";
            form1.cred.pay_all_mounths(dataGridView1);
            labels();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int pay = int.Parse(textBox2.Text);
                int months = (int)numericUpDown4.Value * 12 + (int)numericUpDown5.Value;
                if (months >= form1.cred.months)
                {
                    MessageBox.Show("К этому времени вы уже заплатите за кредит", "Ошибка!");
                }
                else
                {
                    bool term = (bool)radioButton1.Checked;
                    form1.cred.add_pay(months, pay, term);
                    form1.cred.pay_all_mounths(dataGridView1);
                    labels();
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели некорректные данные", "Ошибка!");
                int pay = int.Parse(textBox2.Text);
                int months = (int)numericUpDown4.Value * 12 + (int)numericUpDown5.Value;
                if (months >= form1.cred.months)
                {
                    MessageBox.Show("К этому времени вы уже заплатите за кредит", "Ошибка!");
                }
                else
                {
                    bool term = (bool)radioButton1.Checked;
                    form1.cred.add_pay(months, pay, term);
                    form1.cred.pay_all_mounths(dataGridView1);
                    labels();
                }
            }
        }
        private void labels()
        {
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
            }
            sum += form1.cred.dop_plateg;
            label2.Text = "Всего заплачено:" + Math.Round((decimal)(sum), 2).ToString();
            label3.Text = "Переплата:" + Math.Round((decimal)(sum - form1.cred.sum), 2).ToString();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void data_todark(bool t)
        {
            if (t)
            {
                this.dataGridView1.GridColor = Color.FromArgb(0, 2, 24);
                this.dataGridView1.BackgroundColor= Color.FromArgb(0, 2, 24);
                this.dataGridView1.ForeColor = Color.White;
                dataGridView1.DefaultCellStyle.BackColor = Color.Black;
                    
                
            }
            else
            {
                this.dataGridView1.BackgroundColor = Color.White;
                this.dataGridView1.ForeColor = Color.Black;
            }
        }
    }
}
