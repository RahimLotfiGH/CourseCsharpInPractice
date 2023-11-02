using System;
using System.Windows.Forms;

namespace DelegateFuncApp
{
    public partial class Form1 : Form
    {

        public delegate void Print(string value);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Print myFunc = PrintName;
            myFunc += PrintLastName;

            myFunc("rahim");

            myFunc -= PrintLastName;

            myFunc("Heilton.com");
        }
        private void PrintName(string name)
        {
            MessageBox.Show("Name : " + name);
        }
        private void PrintLastName(string lastName)
        {
            MessageBox.Show("Last Name : " + lastName);
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            ShowName(PrintName);
        }
        public void ShowName(Print print)
        {
            MessageBox.Show("ShowName");

            print("Rahim Lotfi");
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            Print myFunc = delegate(string value)
            {
                MessageBox.Show("delegate=" + value);
            };

            myFunc("www.Heilton.com");

        }
    }
}
