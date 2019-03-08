using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //2 + 3
            string[] input = textBox2.Text.Split(' ');
            int res = int.Parse(input[0]) + int.Parse(input[2]);
            textBox3.Text = Convert.ToString(res);
        }
    }
}
