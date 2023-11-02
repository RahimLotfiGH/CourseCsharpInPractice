using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SwitchCaseApp
{
    public enum EOperations
    {
        Sum = 1,
        Min = 2,
        Mul = 3,
        Div = 4,

    }

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
            MessageBox.Show(GetOperations(EOperations.Sum));
        }

        public string GetOperations(EOperations op)
        {
            return op switch
            {

                EOperations.Sum => "+",
                EOperations.Min => "-",
                EOperations.Mul => "*",
                EOperations.Div => "/",
                _ => "Not Find"
            };

        }

        public string GetOperations1(EOperations op) => op switch
                {

                EOperations.Sum => "+",
                EOperations.Min => "-",
                EOperations.Mul => "*",
                EOperations.Div => "/",
                _ => "Not Find"
                };

        

    }
}
