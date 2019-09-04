using System;
using System.Collections.Generic;
using System.Text;

namespace Fahrzeug
{

    enum Antriebsart
    {
        Benzin,
        Elektro,
        Muskel
    };


    class Fahrzeug
    {
        protected string name;
        protected int anzahlAchsen;
        protected int anzahlRaeder;
        protected int geschwindigkeit;
        protected int kilometer;
        protected int max_geschwindigkeit;
        protected Antriebsart art;



        public Fahrzeug(string name, int anzahlAchsen, int anzahlRaeder, int kilometer, int max_geschwindigkeit, Antriebsart art)
        {
            this.name = name;
            this.anzahlAchsen = anzahlAchsen;
            this.anzahlRaeder = anzahlRaeder;
            this.kilometer = kilometer;
            this.max_geschwindigkeit = max_geschwindigkeit;
            this.art = art;
        }


        public string Name { get { return name; } }

        public int AnzahlAchsen { get { return anzahlAchsen; } }
        public int AnzahlRaeder { get { return anzahlRaeder; } }
        public int Geschwindigkeit { get { return geschwindigkeit; } }
        public int Kilometer { get { return kilometer; } }
        public int MaxGeschwindigkeit { get { return max_geschwindigkeit; } }
        public Antriebsart AntriebsArt { get { return art; } }



        public virtual void beschleunigen()
        {
            Console.WriteLine(name + " beschleunigt...");
            geschwindigkeit += 5;
            

            if(geschwindigkeit > max_geschwindigkeit)
            {
                Console.WriteLine(name + " kann nicht weiter beschleunigen...");
                geschwindigkeit = max_geschwindigkeit;
            }
        }

        public virtual void bremsen()
        {
            Console.WriteLine(name + " bremst...");
            geschwindigkeit -= 5;

            if(geschwindigkeit < 0)
            {
                Console.WriteLine(name + " steht bereits...");
                geschwindigkeit = 0;
            }

        }

    }
}
