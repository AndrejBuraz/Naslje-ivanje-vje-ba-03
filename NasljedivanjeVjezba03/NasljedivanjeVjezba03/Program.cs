using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeVjezba03
{
    class ProgramskiJezik
    {
        public double postotak;

    }
    class Proceduralni : ProgramskiJezik
    {
        public Proceduralni(double postotak)
        {
            this.postotak = postotak;
        }
    }
    class Objektni : ProgramskiJezik
    {
        public Objektni(double postotak)
        {
            this.postotak = postotak;
        }
    }
    class Funkcionalni : ProgramskiJezik
    {
        public Funkcionalni(double postotak)
        {
            this.postotak = postotak;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi postotak za x: ");
            Proceduralni x = new Proceduralni(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Unesi postotak za y: ");
            Objektni y = new Objektni(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Unesi postotak za z: ");
            Funkcionalni z = new Funkcionalni(Convert.ToDouble(Console.ReadLine()));
            if(x.postotak + y.postotak + z.postotak != 100)
            {
                Console.WriteLine("Pogrešan unos!");
            }
            else
            {
                if (x.postotak > y.postotak && x.postotak > z.postotak)
                {
                    Console.WriteLine("Najzastupljeniji programski jezici su proceduralni");
                }
                else if(y.postotak > x.postotak && y.postotak > z.postotak)
                {
                    Console.WriteLine("Najzastupljeniji programski jezici su objektni");
                }
                else if (z.postotak > y.postotak && z.postotak > x.postotak)
                {
                    Console.WriteLine("Najzastupljeniji programski jezici su funkcionalni");
                }
            }
            Console.ReadKey();
        }
    }
}
