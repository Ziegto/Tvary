using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KnihovnaTvar
{
    public class Ctverec : Obdelnik
    {
        public Ctverec(int stranaA) : base(stranaA, stranaA)
        {

        }

        public Ctverec(int stranaA, int x, int y, Color barva) : base(stranaA, stranaA, x, y, barva)
        {

        }

        public Ctverec()
        {

        }

        public override double VypocitatObvod()
        {
            return base.VypocitatObvod();
        }

        public override double VypocitatObsah()
        {
            return base.VypocitatObsah();
        }

        public override String ToString()
        {
            return "Ctverec{" +
                    "sirka=" + sirka +
                    ", vyska=" + vyska +
                    '}';
        }
    }
}
