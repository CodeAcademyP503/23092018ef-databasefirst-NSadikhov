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
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BankDbEntities bank = new BankDbEntities())
            {
                bank.Kredits.Add(new Kredit() { User_id = bank.People.ToList().Last().Id, time = dateTimePicker1.Value, price = Convert.ToInt32(textBox3.Text) });

                bank.SaveChanges();
            }

            
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            using (BankDbEntities bank = new BankDbEntities())
            {
                textBox1.Text = $"{bank.People.ToList().Last().Name} {bank.People.ToList().Last().Surname}";
                dateTimePicker1.Value = DateTime.Now;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThirdForm thirdForm = new ThirdForm();
            thirdForm.ShowDialog();
            this.Close();
        }
    }
}
