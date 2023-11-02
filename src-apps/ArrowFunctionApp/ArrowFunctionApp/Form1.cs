using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrowFunctionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Sum(10, 20).ToString());
            MessageBox.Show(Sum2(10, 20).ToString());
        }


        public int Sum(int a, int b) => a + b;

        public int Sum2(int a, int b)
        {
            return a + b;
        }

    }
}
