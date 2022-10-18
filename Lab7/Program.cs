using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Tekning cirkel = new Cirkel();
            Tekning fyrkant = new Fyrkant();
            Tekning rektangel = new Rektangel();

            cirkel.PrintInfo();
            Console.WriteLine();
            fyrkant.PrintInfo();
            Console.WriteLine();
            rektangel.PrintInfo();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
