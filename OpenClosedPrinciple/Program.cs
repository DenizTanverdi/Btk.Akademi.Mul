using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class AIslemi
    {
        public bool Islem() { Console.WriteLine("AIslemi"); return true; }
    }
    class BIslemi
    {
        public bool Islem() { Console.WriteLine("BIslemi"); return true; }
    }
    class CIslemi
    {
        public bool Islem() { Console.WriteLine("CIslemi"); return true; }
    }
    enum IslemTipi
    {
        AIslemi,
        BIslemi,
        CIslemi
    }

    class IslemYapici
    {
        AIslemi aIslemi;
        BIslemi bIslemi;
        CIslemi cIslemi;

        public IslemYapici()
        {
            aIslemi = new AIslemi();
            bIslemi = new BIslemi();
            cIslemi = new CIslemi();
        }

        public void IslemiYap(IslemTipi islemTipi)
        {
            switch (islemTipi)
            {
                case IslemTipi.AIslemi:
                    aIslemi.Islem();
                    break;
                case IslemTipi.BIslemi:
                    bIslemi.Islem();
                    break;
                case IslemTipi.CIslemi:
                    cIslemi.Islem();
                    break;
            }
        }
    }
    
    //Yukarıdaki örnek kod bloğunu ele alalım. “IslemYapici” sınıfımız “AIslemi”, 
    //“BIslemi” ve “CIslemi” sınıflarını bu şekilde kullanırsa eğer yeni bir “DIslemi” söz konusu olduğunda “IslemYapici” sınıfın değiştirilmesi gerekecektir.
    //Bu tarz bir tasarım bağımlılılardan dolayı hatalıdır.Doğal olarak OCP’ye de aykırıdır.

    //İşte bu tarz bir durumda aşağıdaki gibi bir tasarım OCP’ye uygun bir yaklaşım olacaktır ve yeni ekleme sonucunda bir tek gerekli olan sınıf inşa edilecek
    //lakin “IslemYapici” sınıf değiştirilmeyecektir.


    interface Islem
    {
        bool Islem();
    }
    class AIslemi2 : Islem
    {
        public bool Islem() { Console.WriteLine("AIslemi"); return true; }
    }
    class BIslemi2 : Islem
    {
        public bool Islem() { Console.WriteLine("BIslemi"); return true; }
    }
    class CIslemi2 : Islem
    {
        public bool Islem() { Console.WriteLine("CIslemi"); return true; }
    }
    class IslemYapici2
    {
        Islem islem;

        public IslemYapici2(Islem islem)
        {
            this.islem = islem;
        }

        public void IslemiYap()
        {
            islem.Islem();
        }
    }

    /*
         Gördüğünüz gibi “IslemYapici” sınıfımızda yaptığımız her yeni entegrasyonda ilgili sınıf hangi tipin verildiğiyle ilgilenmeyecek,

        doğal olarak bağımlılık minimize edilmiş olacaktır. Arayüz sayesinde bu işlemi gerçekleştirmekteyiz. 

        İşte bu arayüz sayesinde sınıfımızı genişletmiş oluyor, değişikliği önlemiş oluyoruz.

        Bu prensip(OCP) sayesinde 2 günde yapılan işi 3 günde değiştirmek zorunda kalmaktan kurtuluyoruz.
     */
}
