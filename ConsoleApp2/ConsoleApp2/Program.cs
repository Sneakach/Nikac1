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

            for (int i = 0; i < 3; i++)
            {
                string ime = ListaAuta.ElementAt(i).Name;
                int tip = ListaAuta.ElementAt(i).Type;

                string F = ("Front Wheel Drive");
                string R = ("Rear Wheel Drive");
                string A = ("All Wheel Drive");


                if (tip == 1)
                {
                    Console.WriteLine(ime + "   " + F);
                }
                else if (tip == 2)
                {
                    Console.WriteLine(ime + "   " + R);

                }
                else if (tip == 3)
                {
                    Console.WriteLine(ime + "   " + A);
                }








            }



            Console.ReadKey();









            //yoo23321






        }

    }

    class Auto
    {
        public string Name { get; set; }

        public int Type { get; set; }

        // Type 1 = Front wheel drive
        // Type 2 = Rear wheel drive
        // Type 3 = All wheel drive
    }









}
