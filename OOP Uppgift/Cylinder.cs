namespace OOP_Uppgift
{
    class Cylinder : Cirkel
    {
        public double höjd;
        public Cylinder(double radie, double h) : base(radie)
        {
            höjd = h;
        }

        public double Volym()
        {
            return 0;
        }

        public double Yta()
        {
            return 0;
        }
    }
}