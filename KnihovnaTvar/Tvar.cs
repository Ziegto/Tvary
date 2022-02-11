using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace KnihovnaTvar
{
    public abstract class Tvar
    {
        protected int sirka;
        protected int vyska;

        protected int x;
        protected int y;
        protected Color barva;

        public Tvar()
        {

        }
        public Tvar(int sirka)
        {
            this.sirka = sirka;
            this.vyska = sirka;
        }
        public Tvar(int sirka, int vyska)
        {
            this.sirka = sirka;
            this.vyska = vyska;
        }
        public Tvar(int sirka, int x, int y, Color barva)
        {
            this.sirka = sirka;
            this.vyska = sirka;
            this.x = x;
            this.y = y;
            this.barva = barva;
        }
        public Tvar(int sirka, int vyska, int x, int y, Color barva)
        {
            this.sirka = sirka;
            this.vyska = vyska;
            this.x = x;
            this.y = y;
            this.barva = barva;
        }
        public abstract void Nakreslit();
        public abstract void Nakreslit(Graphics platno);
        public abstract double VypocitatObvod();
        public abstract double VypocitatObsah();
        public override string ToString()
        {
            return "Tvar{" + "sirka=" + sirka + ", vyska=" + vyska + '}';
        }
        public void PosunNahoru()
        {
            y = y - 5;
        }
        public void PosunDolu()
        {
            y = y + 5;
        }
        public void PosunDoprava()
        {
            x = x + 5;
        }
        public void PosunDoleva()
        {
            x = x - 5;
        }
        public void Zvetsi()
        {
            sirka = sirka + 5;
            vyska = vyska + 5;
        }
        public void Zmensi()
        {
            sirka = sirka - 5;
            vyska = vyska - 5;
        }
    }
}
