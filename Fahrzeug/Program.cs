using System;
using System.Collections.Generic;


namespace Fahrzeug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrzeug Iwas...!");

            Auto bmw = new Auto("BMW", 2, 4, 10, 200, Antriebsart.Benzin, 10.0, 100, 5);


            Fahrrad drahtesel = new Fahrrad("Drahtesel", 2, 2, 10, 30, Antriebsart.Muskel, true);
            Fahrrad pegasus = new Fahrrad("pegasus", 2, 2, 10, 30, Antriebsart.Muskel, true);



            while (bmw.Geschwindigkeit < bmw.MaxGeschwindigkeit)
            {
                bmw.beschleunigen();
            }

            while (bmw.Geschwindigkeit > 0)
            {
                bmw.bremsen();
            }


            Console.WriteLine();


            while (drahtesel.Geschwindigkeit < drahtesel.MaxGeschwindigkeit)
            {
                drahtesel.beschleunigen();
            }

            while (drahtesel.Geschwindigkeit > 0)
            {
                drahtesel.bremsen();
            }


            Console.WriteLine();
            Console.WriteLine();


            List<Fahrzeug> listeFahrzeuge = new List<Fahrzeug>();

            listeFahrzeuge.Add(bmw);
            listeFahrzeuge.Add(drahtesel);
            listeFahrzeuge.Add(pegasus);


            foreach (Fahrzeug fz in listeFahrzeuge)
            {
                Console.WriteLine("Name: {0}\t TopSpeed: {1} ", fz.Name, fz.MaxGeschwindigkeit);



                if (fz.GetType() == typeof(Fahrrad))
                {
                    Fahrrad rad = (Fahrrad)fz;
                    Console.WriteLine("hat einen Helm auf {0}", rad.Helm);
                }




            }




            Console.ReadKey();
        }
    }
}
