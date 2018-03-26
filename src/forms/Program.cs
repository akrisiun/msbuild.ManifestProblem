using System;
using System.Windows.Forms;

namespace forms2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var f = new Form1();
            f.Output = (ff) => {
                f.label1.Text = "Hello Forms net47";
            };
            Application.Run(f);
        }
    }
}
