using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovsSubsititutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    interface IUcakKesif
    {
        bool KesifYap();
    }

    interface IHedefiVur
    {
        bool HedefiVur();
    }

    class UcakA : IUcakKesif, IHedefiVur
    {
        public bool HedefiVur()
        {
            Console.WriteLine("UcakA Hedefi vurdu.");
            return true;
        }
        public bool KesifYap()
        {
            Console.WriteLine("UcakA keşfi tamamladı.");
            return true;
        }
    }
    class UcakB : IUcakKesif, IHedefiVur
    {
        public bool HedefiVur()
        {
            Console.WriteLine("UcakB Hedefi vurdu.");
            return true;
        }
        public bool KesifYap()
        {
            Console.WriteLine("UcakB keşfi tamamladı.");
            return true;
        }
    }
    class UcakC : IUcakKesif, IHedefiVur
    {
        public bool HedefiVur()
        {
            Console.WriteLine("UcakC Hedefi vurdu.");
            return true;
        }
        public bool KesifYap()
        {
            Console.WriteLine("UcakC keşfi tamamladı.");
            return true;
        }
    }
    class UcakD : IUcakKesif
    {
        public bool KesifYap()
        {
            Console.WriteLine("UcakD keşfi tamamladı.");
            return true;
        }
    }

    class Savas
    {
        List<IHedefiVur> HedefVurucular;
        List<IUcakKesif> KesifYapicilar;
        public Savas(List<IUcakKesif> KesifYapicilar, List<IHedefiVur> HedefVurucular)
        {
            this.KesifYapicilar = KesifYapicilar;
            this.HedefVurucular = HedefVurucular;
        }

        public void KesifYap()
        {
            KesifYapicilar.ForEach(u =>
            {
                u.KesifYap();
            });
        }

        public void HedefiVur()
        {
            HedefVurucular.ForEach(u =>
            {
                u.HedefiVur();
            });
        }
    }
}
