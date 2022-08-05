using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat=new AMevzuat();
            aMevzuat.Kaydet();
            aMevzuat.Degerlendir();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        // Class nedir ? Class içerisinde birbiriyle ilgili operasyonu tutar ayrıca field ve property tutabilir.
      public  void Add()
        {
            Console.WriteLine("Added");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
    class Customer
    {
        public int Id { get; set; }
    }

    // Tamamlanmış veya yarım operasyon tanımlayabiliriz.

    abstract class MevzuatBase
    {
        protected MevzuatBase() //protected olması daha doğru olur clean kod olmuyor
        {

        }
        public abstract void Degerlendir(); // Ortak olmayan methodları imza şeklinde tanımladık.
        public void Kaydet() {

            Console.WriteLine("Kaydedildi");
        
        }
        //Normnal classlardan tek farkı newlenemez
        //Abstract const içerir mi ? içerebilirler onu inherit  eden newleyebilir.
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir() // override edilmesinin sebebi kendine göre kullanılması
        {
            Console.WriteLine("A Mevzuatına Göre Değerlendirildi.");
        }
    }
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B Mevzuatına Göre Değerlendirildi.");
        }
    }
}
