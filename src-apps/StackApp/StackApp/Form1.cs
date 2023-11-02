using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackApp
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
            Stack stack= new Stack();
            
            stack.Push("ali");
            stack.Push("rahim");
            stack.Push(1);


            while (stack.Count>0)
            {
                MessageBox.Show(stack.Pop().ToString());
            }

            //MessageBox.Show(stack.Peek().ToString());



        }
    }
}
