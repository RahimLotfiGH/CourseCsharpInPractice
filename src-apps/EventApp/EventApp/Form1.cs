using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var printHelper= new PrintHelper();

            printHelper.BeforePrintEvent += ShowBeforePrint;


            printHelper.Print("www.Heilton.com");


        }

        public void ShowBeforePrint()
        {
            MessageBox.Show("ShowBeforePrint");
        }

    }
}
