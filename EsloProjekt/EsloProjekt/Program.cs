using System;

namespace EsloProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanulo elsoTanulo = new Tanulo("Kiss István", 17, "férfi", 78945612378);
            elsoTanulo.Kiiras();

            Tanulo masodikTaanulo = new Tanulo("Nagy Natália", 18, "nő", 78945612345);
            masodikTaanulo.Kiiras();

            Tanulo harmadikTaanulo = new Tanulo("Petőfi Kázmér", 20, "férfi", 76945218345);
            harmadikTaanulo.Kiiras();

            Tanulo negyedikTaanulo = new Tanulo("Lakatos Rozália", 18, "nő", 78975692438);
            negyedikTaanulo.Kiiras();
            /*
            elsoTanulo.eletKor = 17;
            elsoTanulo.Nev = "Kiss István";
            elsoTanulo.nem = "férfi";
            elsoTanulo.oktatasiAzonosito = 78945612378;
            */

            Console.ReadKey(true);
        }
    }

    class Tanulo
    {
        public string Nev { get; set; }
        public int EletKor { get; set; }
        public string Nem { get; set; }
        public long OktatasiAzonosito { get; set; }

        public Tanulo(string nev, int eletkor, string nem , long oktatasiAzonosito)
        {
            this.Nev = nev;
            this.EletKor = eletkor;
            this.Nem = nem;
            this.OktatasiAzonosito = oktatasiAzonosito;
        }

        public void Kiiras()
        {
            if (this.EletKor < 19)
                {
                string kiir = $"Tanuló neve: {this.Nev}, ";
                kiir += $"tanuló életkora: {this.EletKor}";
                Console.WriteLine(kiir);
            }
        }


    }
}
