using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
                Stack : int  sayi = 10  int,double,decimal,bool (value type)  .Değer tipler stack de tanımlar sadece o tanımı etkiler.
                Heap  : Reference type arrayların hepsi reference type 'dir (absctract,class ve interface reference type'dir)
              
             */

            string[] sehirler = new string[] { "istanbul", "ankara", "izmir" }; // string[] sehirler  s1 diyelim burada s1 (101) stackde tanımlanırken
                                                                                // içinde sehir değerleri heap tarafında tutuluyor.
            string[] sehirler2 = new string[] { "Adana", "Bursa", "Bolu" }; // string[] sehirler  s1 diyelim burada s2 (102) stackde tanımlanırken
                                                                            // içinde sehir değerleri heap tarafında tutuluyor.
            sehirler2 = sehirler; // burada stack de olduğu gibi değil buradaki işlem stack de bulunan 102 ' yi 101 karşılık gelen heap kısmına gider  
            sehirler2[0] = "Eskişehir"; // biz burada sehirler2 nin ilk elemanı olan İstanbulu eskişehir diye atadık fakat diyelim ki
            Console.WriteLine(sehirler[0]); // burada sehirler2 nin elemanına eskişehir atadığım halde sehirler'in ilk elemanı ekrana yazdırdığımda eskisehiri atadı burada stack ve heap olayını gösteriyor
            Console.ReadLine(); //  ilk basta sehirler2 için oluşturulan 102 heap kısmında boş kaldı  yani referansı kalmamış yani o referansı hiçbir tanım kalmamışsa
                                //  birazdan onu bellekten uçuracak yapıdır.(garbage collector 102 siler)
                                // String value type mi reference type mi ? (reference typedir fakat çalışma mantığı value type'dir)

        }
    }
}
