using System;
using System.Collections;
using System.Windows.Forms;

namespace HashtableApp
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
            var  hashtable = new Hashtable();

            hashtable.Add(1,"ali");
            hashtable.Add(2, "rahim");
            hashtable.Add(3, "lotfi");
            hashtable.Add(4, "amir");


            foreach (DictionaryEntry item in hashtable)
            {
                MessageBox.Show(item.Key + " : " + item.Value);
            }



            //var isExist = hashtable.Contains(5);
            //MessageBox.Show(isExist.ToString());
            // MessageBox.Show(hashtable.Count.ToString());
            //hashtable.Clear();

            //hashtable.Remove(2);

            // MessageBox.Show(hashtable[2].ToString());

        }
    }
}
