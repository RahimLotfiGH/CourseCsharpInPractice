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

namespace QueueApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Queue queue= new Queue();

            queue.Enqueue("rahim lotfi");
            queue.Enqueue("www.heilton.com");
            queue.Enqueue(1);

            while (queue.Count > 0)
                MessageBox.Show(queue.Dequeue().ToString());

            // MessageBox.Show(queue.Peek().ToString());

        }
    }
}
