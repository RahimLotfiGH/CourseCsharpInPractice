using System;
using System.Windows.Forms;

namespace FuncApp
{
    public partial class Form1 : Form
    {
        //private delegate int SumDelegate(int x, int y);
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, System.EventArgs e)
        {
            //SumDelegate sumFunc = Sum;

            Func<int, int, int> sumFunc = Sum;

            var result = sumFunc(10, 20);
            MessageBox.Show(result.ToString());
        }
        private int Sum(int a, int b)
        {
            return a + b;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            Func<int> GetRandom = delegate
            {
                return new Random().Next(1000);
            };

            MessageBox.Show(GetRandom().ToString());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Func<int> GetRandom = () => new Random().Next(1000);

            MessageBox.Show(GetRandom().ToString());

        }
    }
}
