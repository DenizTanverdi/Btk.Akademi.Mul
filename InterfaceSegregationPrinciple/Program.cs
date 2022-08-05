using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface ITankAtesEt
    {
        bool AtesEt();
    }
    interface ITankMesafeOlc
    {
        double DusmanIleMesafeOlc();
    }
    interface ITankHareketEt
    {
        bool HareketEt();
    }
    interface ITank : ITankMesafeOlc, ITankHareketEt, ITankAtesEt
    {
    }
    class Tank1 : ITank
    {
        public bool AtesEt() => true;
        public double DusmanIleMesafeOlc()
        {
            //Mesafa ölçme işlemleri
            return 100;
        }
        public bool HareketEt() => true;
    }
    class Tank2 : ITankHareketEt, ITankMesafeOlc
    {
        public double DusmanIleMesafeOlc()
        {
            //Mesafa ölçme işlemleri
            return 230;
        }
        public bool HareketEt() => true;
    }
    class Tank3 : ITankAtesEt, ITankHareketEt
    {
        public bool AtesEt() => true;
        public bool HareketEt() => true;
    }

    //Birbirlerinden bağımsız birden fazla yeteneği tek bir Interface’de tutmak yerine,
    //her yetenek farklı bir Interface yapısında tutulmakta ve ihtiyac doğrultusunda ilgili sınıfa ilgili arayüzler uygulanmaktadır.
    //Bu sayede lüzumsuz metod ve işlev uygulaması yapılmamakta ve ilgili Derived Class’larımızın nitelikleri neyse içerikleride birebir aynı olmaktadır.
    //İşte Arayüz Ayrım olarak nitelendirilen bu faydalı ve oldukça kullanışlı manevra boşuna prensip edinilmemiştir.
}
