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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(BankDbEntities bank = new BankDbEntities())
            {
                bank.People.Add(new Person() { Name = textBox1.Text, Surname = textBox2.Text, PassportNumber = textBox3.Text });

                bank.SaveChanges();
               
            }

            SecondForm secondForm = new SecondForm();
            secondForm.ShowDialog();
        }
    }
}
