using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifszerkezet
{
    class DiakBeker
    {
        public string Nev { get; set; }
        public int eletKor { get; set; }

        public DiakBeker(string nev, int eletKor)
        {
                this.Nev = nev;
                this.eletKor = eletKor;
        }

        public void AdatKiir()
        {
            Console.WriteLine($"Név: {this.Nev} és életkor: {this.eletKor}");
        }
    }
}
