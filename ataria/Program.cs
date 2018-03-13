using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ataria
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainin = 0;
            int debugmain = 0;
        Main:
            Console.WriteLine("------------------------------------");
            Console.WriteLine("MARIANISTAS - Pagina del Alumno ");
            if (debugmain == 1)
            {
                Console.WriteLine("Debug: (" + mainin + ")");
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("     (1) Google[MENU]");
            Console.WriteLine("     (2) Educamos");
            Console.WriteLine("     (3) Burlington Books");
            Console.WriteLine("     (4) SmSaviaDigital");
            Console.WriteLine("");
            Console.WriteLine("     (5) Apagar Ordenador");
            Console.WriteLine("     (6) Salir");
            Console.WriteLine("");
            Console.WriteLine("Donde desea entrar? (1/2/3/4/5/6):");
            mainin = Int32.Parse(Console.ReadLine());


            switch (mainin)
            {
                case 2:
                    System.Diagnostics.Process.Start("http://marias-gasteiz.educamos.com/");
                    break;

                case 31415:
                    debugmain = 1;
                    break;
                case 3:
                    System.Diagnostics.Process.Start("https://webbook.burlingtonbooks.com/Login");
                    break;
                case 4:
                    System.Diagnostics.Process.Start("https://es-login.smsavia.com/");
                    break;
                case 5:
                    System.Diagnostics.Process.Start("shutdown", "/s /t 0");
                    break;
                case 6:
                    Environment.Exit(1);
                    break;
                default:
                    //Default code (not made)
                    break;
            }
            Console.Clear();
            goto Main;
        }
    }
}
