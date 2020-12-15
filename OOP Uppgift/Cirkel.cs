using System;

namespace OOP_Uppgift
{
    class Cirkel
    {
        public double radie { get; set; }
        public Cirkel(double r)
        {
            radie = r;
        }

        public double Area()
        {
            return Math.Pow(radie, 2) * Math.PI;
        }

        public double Omkrets()
        {
            return radie * 2 * Math.PI;
        }
    }
}
