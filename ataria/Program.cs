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
            Console.Title = "Ataria - Open Source Student Hub";
            int mainin = 0;
            int debugmain = 0;
            int googlemenu = 0;
        Main:

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Pagina del Alumno - v1.0");
            if (debugmain == 1)
            {
                Console.WriteLine("Debug: (" + mainin + ")");
            }

            Console.WriteLine("------------------------------------");
            if (googlemenu == 1)
            {

                Console.WriteLine("Google - [MENU]");
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine();
            if (googlemenu == 1)
            {
                Console.WriteLine("     (1) Google.com");
                Console.WriteLine("     (2) Google Drive");
                Console.WriteLine("     (3) Google Mail (Gmail)");
                Console.WriteLine("     (4) Google Maps");
                Console.WriteLine("     (5) Youtube");
                Console.WriteLine("");
                Console.WriteLine("     (6) Menu Principal");
                Console.WriteLine("     (7) Salir");
            }
            else
            {
                Console.WriteLine("     (1) Google[MENU]");
                Console.WriteLine("     (2) Educamos");
                Console.WriteLine("     (3) Burlington Books");
                Console.WriteLine("     (4) SmSaviaDigital");
                Console.WriteLine("");
                Console.WriteLine("     (5) Apagar Ordenador");
                Console.WriteLine("     (6) Salir");
            }

            Console.WriteLine("");
            Console.WriteLine("Donde desea entrar? (1/2/3/4/5/6):");
            mainin = Int32.Parse(Console.ReadLine());

            if (googlemenu == 1)
            {
                switch (mainin)
                {


                    case 1:
                        System.Diagnostics.Process.Start("http://google.com");
                        break;

                    case 31415:
                        debugmain = 1;
                        break;
                    case 2:
                        System.Diagnostics.Process.Start("https://drive.google.com");
                        break;
                    case 3:
                        System.Diagnostics.Process.Start("https://mail.google.com");
                        break;
                    case 4:
                        System.Diagnostics.Process.Start("https://maps.google.com");
                        break;
                    case 5:
                        System.Diagnostics.Process.Start("https://youtube.com");
                        break;
                    case 6:
                        googlemenu = 0;
                            break;
                    case 7:
                        Environment.Exit(1);
                        break;
                    default:
                        //Default code (not made)
                        break;

                }
            }
            else
            {
                switch (mainin)
                {
                    case 1:
                        googlemenu = 1;
                        break;
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
            }
            Console.Clear();
            goto Main;
        }
    }
}
