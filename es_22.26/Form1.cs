using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_22._26
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CONVERTI_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int i))
            {
                MessageBox.Show("Errore: inserire un numero");
                return;
            }
            listBox1.Items.Add(i);
        }

        private void btn_RESET_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
