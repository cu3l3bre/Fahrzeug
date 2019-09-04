using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeug
{
    class Fahrrad : Fahrzeug
    {
        private bool hatHelm;



        
        public Fahrrad(string name, int anzahlAchsen, int anzahlRaeder, int kilometer, int max_geschwindigkeit, Antriebsart art, bool hatHelm) : base(name, anzahlAchsen, anzahlRaeder, kilometer, max_geschwindigkeit, art)
        {
            this.hatHelm = hatHelm;
        }


        public bool Helm { get { return hatHelm; } }


        public override void beschleunigen()
        {
            Console.WriteLine(name + " tritt in die Pedale...");
            geschwindigkeit += 5;


            if (geschwindigkeit > max_geschwindigkeit)
            {
                Console.WriteLine(name + " kann nicht schneller treten...");
                geschwindigkeit = max_geschwindigkeit;
            }
        }

        public override void bremsen()
        {
            Console.WriteLine(name + " zieht den Bremshebel...");
            geschwindigkeit -= 5;

            if (geschwindigkeit < 0)
            {
                Console.WriteLine(name + " steht und verliert schon fast das Gleichgewicht...");
                geschwindigkeit = 0;
            }

        }




    }
    
}
