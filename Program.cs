namespace Samåkning
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            double avstånd, drivmedelspris, milförbrukning;// drivmedelskostnad Liter och Mil
            double kördamil, serviceintervall, servicepris; //service kostnad
            double livslängd, nypris; //däcklivslängd
            double kostnad, pris;
            int passagerare = 2;
            
            avstånd = 8.88; drivmedelspris = 24; milförbrukning = 0.65;

            kördamil = 8.88; serviceintervall = 3000; servicepris = 3500;

            livslängd = 4250; nypris = 5000;

            double driftkostnad = avstånd * drivmedelspris * milförbrukning;
            double servicekostnad = (kördamil / serviceintervall) * servicepris;
            double däckkostnad = (kördamil / livslängd) * nypris;
            double totalkostnad = driftkostnad + servicekostnad + däckkostnad;
            totalkostnad = totalkostnad / passagerare;

            Console.WriteLine("drivmedelskostnad: " + driftkostnad);
            Console.WriteLine("Servicekostnad: " + servicekostnad);
            Console.WriteLine("Däckslitage: " + däckkostnad);
            Console.WriteLine("Totala summan: " + totalkostnad);
            Console.WriteLine("Hello, World!");
            
            
        }
    }
}