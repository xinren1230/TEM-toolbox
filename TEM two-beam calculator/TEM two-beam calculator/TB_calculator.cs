using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEM_two_beam_calculator
{
    public partial class TB_calculator : Form
    {
        public TB_calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double tb_index = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text) + Convert.ToDouble(textBox3.Text) * Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox6.Text);
                textBox7.Text = tb_index.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected error");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
