using System.Windows.Forms;

namespace EventApp
{
    public class PrintHelper
    {
        public delegate void BeforePrintDelegate();

        public event BeforePrintDelegate BeforePrintEvent;

        public void Print(string message)
        {
            //if (BeforePrintEvent != null)
            //    BeforePrintEvent();

            BeforePrintEvent?.Invoke();


            MessageBox.Show(message);
        }
    }
}
