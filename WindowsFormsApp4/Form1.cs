using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        ScientistList scientistList = new ScientistList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach (var sc in scientistList.Scientists)
            {
                res += sc;
            }
            MessageBox.Show(res);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                scientistList.AddScientist(new Scientist(t1.Text, t2.Text, t3.Text, t3.Text, Convert.ToDecimal(t5.Text), Convert.ToInt32(t6.Text)));
                MessageBox.Show("Done!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                scientistList.EditScientist(new Scientist(t7.Text, t8.Text, t9.Text, t10.Text, Convert.ToDecimal(t11.Text), Convert.ToInt32(t12.Text)));
                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                scientistList.DeleteScientist(t13.Text);
                MessageBox.Show("Done!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            scientistList.LoadToFile();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            scientistList.LoadFromFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach (var sc in scientistList.FindByPIB(textBox1.Text))
            {
                res += sc;
            }
            MessageBox.Show(res);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach (var sc in scientistList.FindBySalary(Convert.ToDecimal(textBox2.Text)))
            {
                res += sc;
            }
            MessageBox.Show(res);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string res = "";
            foreach (var sc in scientistList.FindByCathedra(textBox3.Text))
            {
                res += sc;
            }
            MessageBox.Show(res);
        }

        private void t2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
