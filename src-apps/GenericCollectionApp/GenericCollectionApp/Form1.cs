using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GenericCollectionApp
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
            var names = new List<string>();

            names.Add("Ali");
            names.Add("Rahim");
            names.Add("Abas");
            names.Add("Erfan");

            foreach (var name in names)
            {
                MessageBox.Show(name);
            }


        }
    }
}
