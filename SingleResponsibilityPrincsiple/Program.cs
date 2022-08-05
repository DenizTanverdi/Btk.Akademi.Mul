using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class AlisVeris
    {
        public double UrunFiyati { get; set; }
        public bool LimitYeterliMi()
        {
            return true;
        }
        public bool AlisVerisTamamla()
        {
            return true;
        }
    }

    //Evet, gördüğünüz gibi bu iki işlemi tek bir sınıf içerisinde yaparak SRP’yi çiğnemiş olduk. 
    //Çünkü limit kontrolü ile alişverişi tamamlama işlemleri birbirlerinden farklı işlemlerdir.Yapmamız gereken bu işlemlere özel sınıflar oluşturmaktır.

    class LimitKontrol
    {
        public bool LimitYeterliMi()
        {
            return true;
        }
    }

    class AlisVerisYapici
    {
        public bool AlisVerisTamamla()
        {
            return true;
        }
    }

    class AlisVeris2
    {
        public double UrunFiyati { get; set; }
    }
}
