using credit_calculus;
namespace credit_calculus
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public credit cred;
        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            try
            {
                this.form2 = new Form2(this);
                sum = int.Parse(textBox1.Text);
                int months = (int)numericUpDown1.Value * 12 + (int)numericUpDown2.Value;
                double percent = (double)numericUpDown3.Value / 100;
                this.cred = new credit(sum, months, percent);
                label11.Text = cred.mpay.ToString() + " ₽";
                label12.Text = cred.over.ToString() + " ₽";
                label13.Text = cred.overPercent.ToString() + " %";
                form2.Show();
            }
            catch
            {
                MessageBox.Show("Вы ввели некорректные данные", "Ошибка!");
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.BackColor = Color.FromArgb(0, 2, 24);
                form2.BackColor = Color.FromArgb(0, 2, 24);
                foreach (Label label in panel1.Controls.OfType<Label>())
                {
                    label.ForeColor = System.Drawing.Color.White;
                }
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = System.Drawing.Color.White;
                }
                
                foreach (CheckBox rb in panel1.Controls.OfType<CheckBox>())
                {
                    rb.ForeColor = System.Drawing.Color.White;
                }
                foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
                {
                    rb.ForeColor = System.Drawing.Color.White;
                }

                foreach (Label label in form2.Controls.OfType<Label>())
                {
                    label.ForeColor = System.Drawing.Color.White;
                }
                foreach (CheckBox rb in form2.Controls.OfType<CheckBox>())
                {
                    rb.ForeColor = System.Drawing.Color.White;
                }
                foreach (RadioButton rb in form2.Controls.OfType<RadioButton>())
                {
                    rb.ForeColor = System.Drawing.Color.White;
                }


                //form2.data_todark(true);
            }
            else {
                form2.data_todark(false);
                this.BackColor = Form1.DefaultBackColor;
                form2.BackColor = Form1.DefaultBackColor;
                foreach (Label label in panel1.Controls.OfType<Label>())
                {
                    label.ForeColor = System.Drawing.Color.Black;
                }
                foreach (Label label in this.Controls.OfType<Label>())
                {
                    label.ForeColor = System.Drawing.Color.Black;
                }
                foreach (RadioButton rb in this.Controls.OfType<RadioButton>())
                {
                    rb.ForeColor= System.Drawing.Color.Black;
                }
                foreach (CheckBox rb in panel1.Controls.OfType<CheckBox>())
                {
                    rb.ForeColor = System.Drawing.Color.Black;
                }


                foreach (Label label in form2.Controls.OfType<Label>())
                {
                    label.ForeColor = System.Drawing.Color.Black;
                }
                foreach (RadioButton rb in form2.Controls.OfType<RadioButton>())
                {
                    rb.ForeColor = System.Drawing.Color.Black;
                }
                foreach (CheckBox rb in form2.Controls.OfType<CheckBox>())
                {
                    rb.ForeColor = System.Drawing.Color.Black;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}