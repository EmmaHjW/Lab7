using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    public class Cirkel : Tekning
    {
        public double Radius { get; set; } 
        public Cirkel(double Radius = 5)
        {
            this.Radius = Radius;
        }
        public override void Draw()
        {
            Console.WriteLine($"Räknar ut arean av en cirkel: {Area()}");
        }
        public override double Area()
        {
           return Math.Round(Math.PI * Math.Pow(Radius, 2));
        }
    }
}
