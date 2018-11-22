using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikac
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj1 = 1;
            int broj2 = 2;
            string tekst = "Zbroj 1 i 2 je: ";

            int rezultat = 0;

            rezultat = nasaMetoda(broj1, broj2);

            int nasaMetoda(int x, int y)
            {
                int retVal = x + y;

                return retVal;
            }

            Console.WriteLine("1 = Creature " +
                " 2 = Instant " +
                " 3 = Sorcery " +
                " 4 = Artifact " +
                " 5 = Enchantment " +
                " 6 = BossMiletov Archenemy) ");


            //instanciranje novog objekta
            Card MojaPrvaKarta = new Card();
            MojaPrvaKarta.Name = "Goyf";
            MojaPrvaKarta.Type = 1;

            Card MojaDrugaKarta = new Card();
            MojaDrugaKarta.Name = "Fatal Push";
            MojaDrugaKarta.Type = 2;

            Card MojaTrecaKarta = new Card();
            MojaTrecaKarta.Name = "Thoughtseize";
            MojaTrecaKarta.Type = 3;

            Card MojaCetvrtaKarta = new Card();
            MojaCetvrtaKarta.Name = "Sol Ring";
            MojaCetvrtaKarta.Type = 4;

            Card MojaPetaKarta = new Card();
            MojaPetaKarta.Name = "Zendikar Resurgence";
            MojaPetaKarta.Type = 5;

            Card EpicCommander = new Card();
            EpicCommander.Name = "Animar, Soul of Elements";
            EpicCommander.Type = 6;

            List<Card> ListaKarata = new List<Card>();
            ListaKarata.Add(MojaPrvaKarta);
            ListaKarata.Add(MojaDrugaKarta);
            ListaKarata.Add(MojaTrecaKarta);
            ListaKarata.Add(MojaCetvrtaKarta);
            ListaKarata.Add(MojaPetaKarta);
            ListaKarata.Add(EpicCommander);


            for (int i = 0; i < 6; i++)
            {
                string ime = ListaKarata.ElementAt(i).Name;
                int tip = ListaKarata.ElementAt(i).Type;
                Console.WriteLine(ime + "  " + tip);
            }

            Console.WriteLine("------------------------------------");
            Console.WriteLine("" +
                "");


            //instanciranje novog objekta

            Auto PrviAuto = new Auto();
            PrviAuto.Name = "Ford Fiesta ST";
            PrviAuto.Type = "Front Wheel Drive";


            Auto DrugiAuto = new Auto();
            DrugiAuto.Name = "Honda S660";
            DrugiAuto.Type = "Rear Wheel Drive";

            Auto TreciAuto = new Auto();
            TreciAuto.Name = "Dodge Charger";
            TreciAuto.Type = "All Wheel Drive";

            List<Auto> ListaAuta = new List<Auto>();
            ListaAuta.Add(PrviAuto);
            ListaAuta.Add(DrugiAuto);
            ListaAuta.Add(TreciAuto);

            for (int i = 0; i < 3; i++)
            {

                string ime = ListaAuta.ElementAt(i).Name;
                string tip = ListaAuta.ElementAt(i).Type;
                Console.WriteLine(ime + "      " + tip);

            }
            


        
            

            Console.ReadKey();


        }
    }
    class Card
    {
        public string Name { get; set; }
        // Type 1 - Creature
        // Type 2 - Instant
        // Type 3 - Sorcery
        // Type 4 - Artifact
        // Type 5 - Enchantment
        // Type 6 - BossMiletov Archenemy
        public int Type { get; set;  }



    }

    class Auto
    {
        public string Name { get; set; }

        public string Type { get; set;  }
	
        // Type 1 - Front Wheel Drive
        // Type 2 - Rear Wheel Drive
        // Type 3 - All Wheel Drive
        

        // ewqe
        // milebossssssss
    }

} 
