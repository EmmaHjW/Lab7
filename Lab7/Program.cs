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

            cirkel.Draw();
            Console.WriteLine();
            fyrkant.Draw();
            Console.WriteLine();
            rektangel.Draw();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
