using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CMevzuat cMevzuat = new CMevzuat();
            cMevzuat.Kaydet();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
     
        public void Add()
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

    

    abstract class MevzuatBase
    {
        protected MevzuatBase() 
        {

        }
        public abstract void Degerlendir(); 
        public virtual void Kaydet() //Yani kaydet hemen her yerde ortak ama bazı yerlerde farklı 
        {

            Console.WriteLine("Kaydedildi");

        }
       
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir() 
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
    class CMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("C Mevzuatına Göre Değerlendirildi.");
        }
        public override void Kaydet()
        {
            Console.WriteLine("C Mevzuatına Göre kaydetme işlemi kontrol edildi.");
            base.Kaydet();
        }
    }
}
