using System;
using System.Windows.Forms;

namespace ValueTupleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var tuple = Tuple.Create(1, "rahim");

            var valueTuple = (1, "rahim");

            var valueTuple2 = CreateValueTuple();

            MessageBox.Show(valueTuple2.Item2);
        }

        private (int, string,string) CreateValueTuple()
        {
            return (20, "www.Heilton.com","RahimLotfi");
        }

    }
}
