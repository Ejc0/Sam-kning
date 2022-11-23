namespace Samåkning
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            double avstånd, drivmedelspris; // drivmedelskostnad Liter och Mil
            double milförbrukning;
            double kördamil, maxmil, tidigaremil; //service kostnad
            double livslängd, nypris; //däcklivslängd
            double kostnad, pris, servicepris;
            
            
            avstånd = 8.8; drivmedelspris = 27; milförbrukning = 0.65;

            kördamil = 10; maxmil = 150; tidigaremil = 100; servicepris = 5000;

            livslängd = 4250; nypris = 5000;
            double driftkostnad = avstånd * drivmedelspris * milförbrukning;
            double servicekostnad = (kördamil / maxmil) * servicepris;
            double däckkostnad = (kördamil / livslängd) * nypris;
            double totalkostnad = driftkostnad + servicekostnad + däckkostnad;
            totalkostnad = totalkostnad / 2;
            Console.WriteLine(avstånd * drivmedelspris * milförbrukning);
            Console.WriteLine((kördamil/maxmil)* servicepris);
            Console.WriteLine((kördamil/livslängd)*nypris);
            Console.WriteLine(totalkostnad);
            Console.WriteLine("Hello, World!");
            
            
        }
    }
}