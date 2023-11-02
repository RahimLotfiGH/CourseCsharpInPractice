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

namespace ArrayListApp
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
            var arrayList= new ArrayList();
            arrayList.Add(100);
            arrayList.Add(500);
            arrayList.Add(50);
            arrayList.Add(10);
            arrayList.Add("heilton.com");
            arrayList.Add(50.60);
            //var index = arrayList.IndexOf(500);
            //MessageBox.Show(arrayList[index].ToString());

            foreach (var item in arrayList)
            {
                MessageBox.Show(item.ToString());
            }




            // arrayList.Remove(500);
            // arrayList.RemoveAt(3);
            // arrayList.RemoveRange(0,2);
            // arrayList.Sort();
            // arrayList.Reverse();
            //arrayList.Insert(2,"RahimLotfi");
            //var arraList2= new ArrayList();
            //arraList2.Add("test1");
            //arraList2.Add("test2");
            // arrayList.InsertRange(2,arraList2);


        }
    }
}
