using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    public class Rektangel : Tekning
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public Rektangel(double Width = 3, double Length = 6)
        {
            this.Width = Width;
            this.Length = Length;
        }
        public override void Draw()
        {
            Console.WriteLine($"Räknar ut arean av en rektangel: {Area()}");
        }
        public override double Area()
        {
            double area = Width * Length;
            return area;
        }
        public override void PrintInfo()
        {
            this.Draw();
            this.Area();
        }

    }
}
