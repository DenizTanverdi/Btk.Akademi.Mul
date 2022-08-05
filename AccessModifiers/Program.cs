using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // private,protected,Internal,Public ---------- sıralama böyle
        }
    }
    class CustomerManager  // böyle tanımnladığımız da internal olarak tanımlar. Default değeri internal.
                           // Diğer uygulamarımız buna referans veremez. Namespace içinde kullanabiliriz(internal)
                           //class private ve protected yapamayız.
    {
        protected int deger = 11; // private den farklı olarak inherit aldığı yerde de ulaşılabilir.
        public CustomerManager() //Farklı asemblylerde bizim classımıza ulaşabilir
        {

        }
        private class MyClass // Private ise onun üstündeki kıvırcık parantez ona erişebilir customermanager içinde olan herşey ulaşibilir;
        {
            int sayi=0; // field default değeri private 

            public MyClass()
            {
                sayi=6;
            }

        }
    }

    class MyClass:CustomerManager
    {
        public MyClass()
        {
            deger=5;
        }
    }
}
