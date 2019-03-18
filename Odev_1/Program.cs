using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace War_simulation
{
    public class Program
    {

        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //Form Uygulamasidir.
            //Program cizim yaptigi icin Form1 class'i icinden basliyor.
            //Uygulamada sadece askerler hareket ediyor. AtesEt() yetileri yoktur.
            //Ozgur Can Altinok
        }
    }
}
