using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KnihovnaTvar
{
    public class Obdelnik : Tvar
    {
        public Obdelnik()
        {

        }
        public Obdelnik(int sirka, int vyska) : base(sirka, vyska)
        {

        }
        public Obdelnik(int sirka, int vyska, int x, int y, Color barva) : base(sirka, vyska, x, y, barva)
        {

        }
        public override void Nakreslit()
        {
            for (int y = 0; y < vyska; y++)
            {
                for (int x = 0; x < sirka; x++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("");
            }
        }
        public override void Nakreslit(Graphics platno)
        {
            Pen pen = new Pen(barva, 5);
            platno.DrawRectangle(pen, x, y, sirka, vyska);
        }
        public override double VypocitatObvod()
        {
            return 2 * (sirka + vyska);
        }
        public override double VypocitatObsah()
        {
            return sirka * vyska;
        }
        public override string ToString()
        {
            return "Obdelnik{" +
                    "sirka=" + sirka +
                    ", vyska=" + vyska +
                    '}';
        }
    }
}
