﻿using System;
using System.Net;

namespace ataria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Title = "Ataria - Open Source Student Hub";
            Methods.delFile();
            MainProgram();
        }

        internal static void MainProgram()
        {
            Main:
            string mainout;
            int mainin = 0;
            int debugmain = 0;
            int googlemenu = 0;

            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                WebClient client = new WebClient();
                client.Proxy = null;
                string reply = client.DownloadString("https://atariafiles.000webhostapp.com/");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Pagina del Alumno - v1.4");
                Console.WriteLine(reply);
            }
            else
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Pagina del Alumno - v1.4");
            }
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
                Console.WriteLine("");
                Console.WriteLine("     (help) Página de Ayuda");
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
                Console.WriteLine("");
                Console.WriteLine("     (help) Página de Ayuda");
            }

            Console.WriteLine("");
            Console.WriteLine("Donde desea entrar? (1/2/3/4/5/6):");
            mainout = Console.ReadLine();
            if (Int32.TryParse(mainout, out mainin))
            {
            }
            else
            {
                switch (mainout)
                {
                    case "github":
                        System.Diagnostics.Process.Start("https://github.com/theasern/ataria");
                        break;
                    case "camara":
                        System.Diagnostics.Process.Start("http://arllc.net/findipcam/");
                        break;
                    case "noticias":
                        System.Diagnostics.Process.Start("https://files.000webhost.com/");
                        break;
                    case "help":
                        System.Diagnostics.Process.Start("https://atariafiles.000webhostapp.com/help/");
                        break;
                    case "exit":
                        Environment.Exit(1);
                        break;
                    case "panic":
                        Console.Clear();
                        Console.WriteLine("Desinstalando...");
                        Methods.Uninstall();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        goto Main;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Clear();
                goto Main;
            }
            if (googlemenu == 1)
            {
                switch (mainin)
                {


                    case 1:
                        System.Diagnostics.Process.Start("http://google.com");
                        break;
                    case 2105:
                        ataria.Methods.extMethod();
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        goto Main;
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
                    case 2105:
                        ataria.Methods.extMethod();
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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        goto Main;
                        break;

                }
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            goto Main;
        }
    }
}
