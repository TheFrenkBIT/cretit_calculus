using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace credit_calculus
{
    public class credit
    {
        public struct paying
        {
            public int month;
            public double s;
            public paying(int month, double s)
            {
                this.month = month;
                this.s = s;
            }
        }
        public struct tableRow
        {
            public int i;
            public double mpay;
            public double credit_pay;
            public double percent_pay;
            public double remains;
            public tableRow(int i, double mpay, double credit_pay, double percent_pay, double remains)
            {
                this.i = i;
                this.mpay = mpay;
                this.credit_pay = credit_pay;
                this.percent_pay = percent_pay;
                this.remains = remains;
            }
        }

        public List<tableRow> tableRows;
        public List<paying> datapayingList;
        public List<paying> sumpayingList;
        public int sum { get; set; }
        public int months { get; set; }
        public double percent { get; set; }
        public double mpay { get; set; }
        public double over { get; set; }
        public double overPercent { get; set; }
        public double dop_plateg { get; set; }

        public credit(int sum, int months, double percent)
        {
            this.dop_plateg = 0;
            this.datapayingList= new List<paying>();
            this.sumpayingList= new List<paying>();
            this.tableRows= new List<tableRow>();
            this.sum = sum;
            this.months = months;
            this.percent = percent;
            if (sum != 0)
            {
                this.mpay = this.monthly_payment();
                this.over = this.Over();
                this.overPercent = this.OverPercent();
                this.fill_table();                
            }
            else
            {
                this.mpay = 0;
                this.over = 0;
                this.overPercent = 0;
            }
        }
        protected void fill_table()
        {
            double remains = sum;
            for (int i = 1; i <= this.months; i++)
            {
                double pecent_pay = remains * this.percent / 12;
                remains = remains - mpay + pecent_pay;
                tableRows.Add(
                    new tableRow
                        (
                        i,
                        mpay,
                        (double)Math.Round((decimal)(mpay - pecent_pay), 2),
                        (double)Math.Round((decimal)(pecent_pay), 2),
                        (double)Math.Round((decimal)(remains), 2)
                        )
                    );
            }
        }

        public credit()
        {
        }
        public void pay_all_mounths(DataGridView dataGridView1)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < this.months; i++)
            {
                tableRow row = this.tableRows[i];
                dataGridView1.Rows.Add(
                    row.i,
                    row.mpay,
                    row.credit_pay,
                    row.percent_pay,
                    row.remains
                    );
            }
        }
        protected void new_table()
        {
            foreach (paying el in sumpayingList)
            {
                double remains = this.tableRows[el.month].remains - el.s ;
                
                credit c = new credit((int)Math.Round((decimal)remains, 0), this.months - el.month - 1, this.percent);
                this.dop_plateg += el.s;
                for (int i = el.month+1; i <= tableRows.Count; i++)
                {
                    double pecent_pay = remains * this.percent / 12;

                    this.tableRows[i-1] = (
                    new tableRow
                        (
                        i,
                        c.mpay,
                        (double)Math.Round((decimal)(c.mpay - pecent_pay), 2),
                        (double)Math.Round((decimal)(pecent_pay), 2),
                        (double)Math.Round((decimal)(remains), 2)
                        )
                    );

                    remains = remains - c.mpay + pecent_pay;
                }
            }
            sumpayingList.Clear();
            foreach (paying el in datapayingList)
            {
                this.dop_plateg += el.s;
                double remains = this.tableRows[el.month].remains - el.s;
                for (int i = el.month + 1; i <= tableRows.Count; i++)
                {
                    double pecent_pay = (remains+mpay) * this.percent / 12;
                    if (remains < 0)
                    {
                        this.tableRows[i - 1] = (
                    new tableRow
                        (
                        i,
                        mpay + remains,
                        (double)Math.Round((decimal)(mpay + remains - pecent_pay), 2),
                        (double)Math.Round((decimal)(pecent_pay), 2),
                        (double)Math.Round((decimal)(0), 2)
                        )
                        );
                        this.tableRows.RemoveRange(i, this.tableRows.Count - i);
                        this.months = this.tableRows.Count;
                        break;
                    }
                    this.tableRows[i - 1] = (
                    new tableRow
                        (
                        i,
                        mpay,
                        (double)Math.Round((decimal)(mpay - pecent_pay), 2),
                        (double)Math.Round((decimal)(pecent_pay), 2),
                        (double)Math.Round((decimal)(remains), 2)
                        )
                    );
                    remains = remains - mpay + (remains) * this.percent / 12; ;
                }
            }
            datapayingList.Clear();
        }
        public void add_pay(int month, double s, bool term)
        {
            paying p = new paying(month, s);
            if (term )
            {
                datapayingList.Add(p);
            }
            else
            {
                sumpayingList.Add(p);
            }
            this.new_table();


        }


        private double monthly_payment()
        {
            double i = this.percent / 12;
            double mp = (double)this.sum * (i + (i / (Math.Pow(i+1, (double)this.months) - 1)));
            return (double)Math.Round((decimal)mp, 2);

        }
        private double Over()
        {
            double over = this.mpay * (double)this.months - (double)this.sum;
            return (double)Math.Round((decimal)over, 2); ;
        }
        private double OverPercent()
        {
            double overPercent = this.over / (double)this.sum * 100;
            return (double)Math.Round((decimal)overPercent, 2); ;
        }
    }
}
