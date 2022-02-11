using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KnihovnaTvar;

namespace TvaryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Tvar> poleTvaru = new List<Tvar>();

            Console.Write("Zadejte šířku prvního obdélníku: ");
            int sirka = int.Parse(Console.ReadLine());

            Console.Write("Zadejte výšku prvního obdélníku: ");
            int vyska = int.Parse(Console.ReadLine());

            poleTvaru.Add(new Obdelnik(sirka, vyska));
            poleTvaru.Add(new Obdelnik(random.Next(10) + 1, random.Next(10) + 1));

            Console.Write("Zadejte šířku prvního čtverce: ");
            int stranaA = int.Parse(Console.ReadLine());
            poleTvaru.Add(new Ctverec(stranaA));
            poleTvaru.Add(new Ctverec(random.Next(10) + 1));

            Console.Write("Zadejte šířku prvního kruhu: ");
            int prumer = int.Parse(Console.ReadLine());
            poleTvaru.Add(new Kruh(prumer));
            poleTvaru.Add(new Kruh(random.Next(10) + 1));

            foreach (Tvar t in poleTvaru)
            {
                Console.WriteLine(t.ToString());
                Console.Write("Obvod: {0}\n", t.VypocitatObvod());
                Console.Write("Obsah: {0}\n", t.VypocitatObsah());

                Console.WriteLine();

                t.Nakreslit();

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
