using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsloProjekt
{
    class Negyszog
    {
        public int AOldal { get; set; }
        public int BOldal { get; set; }

        public Negyszog(int aOldal, int bOldal)
        {
            this.AOldal = aOldal;
            this.BOldal = bOldal;
        }

        public int TeruletSzamol()
        {
            return this.AOldal * this.BOldal;
        }

        public int KeruletSzamol()
        {
            return 2 * (this.AOldal + this.BOldal);
        }
    }
}
