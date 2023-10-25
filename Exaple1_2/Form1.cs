using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exaple1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name,textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void eğikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name,textBox1.Font.Size,textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void altıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name, textBox1.Font.Size, textBox1.Font.Style ^ FontStyle.Underline);
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.Cut();

            else
                MessageBox.Show("Seçili Alan yok");
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.Copy();

            else 
                
                MessageBox.Show("Seçili Alan yok");
            
                
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

    }
}
