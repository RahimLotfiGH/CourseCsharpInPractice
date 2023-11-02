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

namespace SortedListApp
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
            var sortedList = new SortedList();

            sortedList.Add(10,"ali");
            sortedList.Add(100, "abas");
            sortedList.Add(1, "rahim");
            sortedList.Add(20, "amir");

           // var value = sortedList.GetByIndex(2);
           // MessageBox.Show(value.ToString());

           foreach (DictionaryEntry item in sortedList)
           {
               MessageBox.Show(item.Key + " : " + item.Value);
           }


            // sortedList.Remove(20);
            //sortedList.RemoveAt(2);

        }
    }
}
