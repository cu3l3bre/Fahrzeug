using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeug
{
    class Auto : Fahrzeug
    {

        private double verbrauch;
        private int tankfuellstand;
        private int anzahlTueren;

        public Auto(string name, int anzahlAchsen, int anzahlRaeder, int kilometer, int max_geschwindigkeit, Antriebsart art , double verbrauch, int tankfuellstand, int anzahlTueren) : base( name,  anzahlAchsen, anzahlRaeder, kilometer, max_geschwindigkeit, art)
        {
            this.verbrauch = verbrauch;
            this.tankfuellstand = tankfuellstand;
            this.anzahlTueren = anzahlTueren;

        }






        public override void beschleunigen()
        {
            Console.WriteLine(name + " gibt Gas...");
            geschwindigkeit += 5;


            if (geschwindigkeit > max_geschwindigkeit)
            {
                Console.WriteLine(name + " gibt schon Vollgas...");
                geschwindigkeit = max_geschwindigkeit;
            }
        }

        public override void bremsen()
        {
            Console.WriteLine(name + " tritt aufs Bremspedal...");
            geschwindigkeit -= 5;

            if (geschwindigkeit < 0)
            {
                Console.WriteLine(name + " steht bereits...");
                geschwindigkeit = 0;
            }

        }






    }
}
