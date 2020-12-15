using System;

namespace OOP_Uppgift
{
    class Cylinder : Cirkel
    {
        public double höjd { get; set; }
        public Cylinder(double radie, double h) : base(radie)
        {
            höjd = h;
        }

        public double Volym()
        {
            return Area() * höjd;
        }

        public double Yta()
        {
            return (Area()*2) + (Omkrets() * höjd);
        }
    }
}