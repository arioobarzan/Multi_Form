using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_forms
{
    public partial class SearchForm : Form
    {
        public PayForm pf;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("دانیال"))
            {
                pf.textBox1.Text = "14001037";
                this.Hide();
            }
        }
    }
}
