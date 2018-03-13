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
        Main:
            Console.WriteLine("------------------------------------");
            Console.WriteLine("MARIANISTAS - Pagina del Alumno ");
            Console.WriteLine("Debug: (" + mainin + ")");
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

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Typed /" + mainin + "/");
                    Console.WriteLine();
                    break;
            }
            Console.Clear();
            goto Main;
        }
    }
}
