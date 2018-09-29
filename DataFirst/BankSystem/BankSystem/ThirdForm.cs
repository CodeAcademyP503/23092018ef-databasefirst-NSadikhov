using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class ThirdForm : Form
    {
        public ThirdForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThirdForm_Load(object sender, EventArgs e)
        {
            using (BankDbEntities bank = new BankDbEntities())
            {

                int Count = 0;
                for (int i = 0; i < bank.People.Count(); i++)
                {
                    Count++;
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = $"{bank.People.Find(Count).Name} {bank.People.Find(Count).Surname}";
                    dataGridView1.Rows[i].Cells[1].Value = bank.Kredits.Find(Count).price;

                }
            }
        }
    }
}
