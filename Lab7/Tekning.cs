using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    public class Tekning
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public virtual double Area()
        {
            return Height * Width;
        }
        public virtual void Draw()
        {
            Console.WriteLine("Ritar basformen");
        }
        //public virtual void PrintInfo()
        //{

        //}
    }
}
