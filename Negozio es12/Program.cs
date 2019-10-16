using System;

namespace Negozio_es12
{
    class Program
    {
        static void Main(string[] args)
        {
            double sconto20 = 0;
            double sconto = 0;
            double prezzofinale = 0;
            Console.Write("Quanto hai speso? ");
            double tot = double.Parse(Console.ReadLine());
            if(tot > 300)
            {
                sconto = (300 / 100) * 10;
                double resto = tot - 300;
                Console.WriteLine("Applico uno sconto... ");
                sconto20 = (resto / 100) * 20;
                prezzofinale = 270 + resto - sconto20;
                Console.WriteLine($"Importo scontato da pagare {prezzofinale} applicando uno sconto di {sconto} euro sui primi 300 euro e uno sconto di {sconto20} euro sul resto.");
            }
            if(tot < 300)
            {
                sconto = (tot / 100) * 10;
                prezzofinale = tot - sconto;
                Console.WriteLine($"Importo scontato da pagare {prezzofinale} applicando uno sconto di {sconto}");
            }
            Console.ReadLine();
        }
    }
}
