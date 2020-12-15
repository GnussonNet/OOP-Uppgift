using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            // Window title
            #region window title
            Console.Title = "Cirkel och Cylinder";
            #endregion

            // Input radie
            #region input radie
            double inputRadie;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Skriv en radie på en cirkel:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ");
            bool isnumbersRadie = double.TryParse(Console.ReadLine(), out inputRadie);
            #endregion

            // Input höjd
            #region input höjd
            double inputHöjd;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Skriv en höjd på en cirkel:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ");
            bool isnumbersHöjd = double.TryParse(Console.ReadLine(), out inputHöjd);
            #endregion

            // Rensa kod för bättre UX
            Console.Clear();

            // Felkoder
            #region felkoder
            if (!isnumbersRadie && !isnumbersHöjd)
                error("Radie och höjd");
            if (!isnumbersRadie)
                error("Radie");
            if (!isnumbersHöjd)
                error("Höjd");
            #endregion

            // Cirkel
            #region printa cirkel
            Cirkel cirkel = new Cirkel(inputRadie);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Cirkelns area är: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Math.Round(cirkel.Area(), 4));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Cirkelns omkrets är: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Math.Round(cirkel.Omkrets(), 4));
            #endregion

            // Radbrytare för bättre UX
            Console.Write("\n");

            // Cylinder
            #region printa cylinder
            Cylinder cylinder = new Cylinder(inputRadie,inputHöjd);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Cylinderns volym är: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Math.Round(cylinder.Volym(), 4));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Cylinderns yta är: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Math.Round(cylinder.Yta(), 4));
            #endregion

            // Läs sista utskrivt innan consolen stängs
            Console.ReadLine();
        }

        // Error handler
        public static void error(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fel input. ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(error);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" får endast innehålla siffror och punkt...");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
