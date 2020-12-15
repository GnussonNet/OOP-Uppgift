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
            double area = Math.Pow(radie, 2) * Math.PI;
            return area;
        }

        public double Omkrets()
        {
            double omkrets = radie * 2 * Math.PI;
            return omkrets;
        }
    }
}
