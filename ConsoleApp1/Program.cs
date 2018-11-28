using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Auti
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciranje novog objekta

            Auto PrviAuto = new Auto();
            PrviAuto.Name = "Ford Fiesta ST";
            PrviAuto.Type = 1;

            Auto DrugiAuto = new Auto();
            DrugiAuto.Name = "Honda S660";
            DrugiAuto.Type = 2;

            Auto TreciAuto = new Auto();
            TreciAuto.Name = "Dodge Charger";
            TreciAuto.Type = 3;

            List<Auto> ListaAuta = new List<Auto>();
            ListaAuta.Add(PrviAuto);
            ListaAuta.Add(DrugiAuto);
            ListaAuta.Add(TreciAuto);

            for (int i = 0; i < 2; i++)
            {
                string ime = ListaAuta.ElementAt(i).Name;
                int tip = ListaAuta.ElementAt(i).Type;
                Console.WriteLine(ime + "   " + tip);


            }












            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    class Auto
    {
        public string Name { get; set; }

        public int Type { get; set; }

        // Type 1 = Front Wheel Drive
        // Type 2 = Rear Wheel Drive
        // Type 3 = All Wheel Drive



    }




}
