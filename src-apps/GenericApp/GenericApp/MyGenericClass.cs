using System.Windows.Forms;

namespace GenericApp
{
    public class MyGenericClass<T1,T2>
    {

        public T1 Id1 { get; set; }

        public T2 Id2 { get; set; }

        public T1 ShowValue(T2 value)
        {

            MessageBox.Show(value.ToString() + " : " + typeof(T2).ToString());

            return Id1;
        }

    }
}
