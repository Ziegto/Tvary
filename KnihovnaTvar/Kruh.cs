using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KnihovnaTvar
{
    public class Kruh : Tvar
    {
        public Kruh() : base()
        {

        }
        public Kruh(int sirka) : base(sirka)
        {

        }
        public Kruh(int sirka, int x, int y, Color barva) : base(sirka, x, y, barva)
        {

        }
        public override double VypocitatObvod()
        {
            return Math.PI * sirka;
        }
        public override double VypocitatObsah()
        {
            return (Math.PI * ((sirka / 2.0) * (sirka / 2.0)));
        }
        public override void Nakreslit()
        {
            Console.WriteLine("Kruh není jednoduché v konzoli nakreslit");
        }
        public override void Nakreslit(Graphics platno)
        {
            Pen pen = new Pen(barva, 5);
            platno.DrawEllipse(pen, x, y, sirka, sirka);
        }
        public override string ToString()
        {
            return "Kruh{" +
                    "sirka=" + sirka +
                    ", vyska=" + vyska +
                    '}';
        }
    }
}
