using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NakladniAuto autak = new NakladniAuto(textBox1.Text, (int)numericUpDown1.Value);
                autak.NalozNaklad((int)numericUpDown2.Value);     
                autak.VylozNaklad((int)numericUpDown3.Value);             
                MessageBox.Show(autak.ToString());
            }
            catch
            {
                MessageBox.Show("Chyba");
            }

        }
    }
}
