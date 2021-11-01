using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lucrare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Echipa e1 = new Echipa("e1", false, 345, new int[] { 2002});
            Echipa e2 = new Echipa("e2", false, 245, new int[] { 2003 });
            bool rez = e1 > e2;
            if (rez)
            {
                Console.WriteLine("Exemplificare supraincarcare operator: e1.buget > e2.buget");
            }
            else
            {
                Console.WriteLine("Exemplificare supraincarcare operator: e1.buget < e2.buget");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormEchipe());
        }
    }
}
