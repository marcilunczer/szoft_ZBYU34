using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatkotes
{
    public partial class Form2 : Form
    {
        public CountryData Country;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = Country;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; 
        }
    }
}
