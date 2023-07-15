using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntVariables3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden kısa ve uzun kenarı girilen dikdörtgenin alan ve cevresini hesaplayın

            int kisaKenar, uzunKenar, cevre, alan;
            Console.WriteLine("Lütfen dikdörtgenin kısa kenar uzunluğunu girin : ");
            Console.WriteLine();
            kisaKenar = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Lütfen dikdörtgenin uzun kenar uzunlugunu girin : ");
            Console.WriteLine();
            uzunKenar = Convert.ToInt16(Console.ReadLine());
            cevre = 2*(kisaKenar+uzunKenar);
            alan = kisaKenar*uzunKenar;
            Console.WriteLine();
            Console.WriteLine("Girmis oldugunuz dikdörtgenin cevresi : " + cevre);
            Console.WriteLine();
            Console.WriteLine("Girmis oldugunuz dikdörtgenin alanı : " + alan);

            Console.Read();

        }
    }
}
