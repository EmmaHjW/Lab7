using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    public class Fyrkant : Tekning
    {
        public int Side { get; set; }
        public Fyrkant(int Side = 10)
        {
            this.Side = Side;
        }
        public override void Draw()
        {
            Console.WriteLine($"Räknar ut arean av en fyrkant: {Area()}");
        }
        public override double Area()
        {
            int area = Side * Side;
            return area;
        }
        public override void PrintInfo()
        {
            this.Draw();
            this.Area();
        }
    }
}
