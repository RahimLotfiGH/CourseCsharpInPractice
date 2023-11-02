using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericApp
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
            MyGenericClass<int,string> myGenericClass=new MyGenericClass<int,string>();

            myGenericClass.Id1 = 10;
            myGenericClass.Id2 = "Ali";

            myGenericClass.ShowValue("rahim Lotfi");



        }
    }
}
