using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoCContainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var kernel = new StandardKernel();
            kernel.Bind<IMevzuat>().To<İkinciMevzuat>().InSingletonScope(); // Birisi burada Imevzuat istediğinde
                                                                             // ikinci mevzuatı getir deriz.Insingleton dediğimizde aynı mevzuatı döndür deriz

            CustomerManager customerManager = new CustomerManager(kernel.Get<IMevzuat>());
            customerManager.Add();
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private IMevzuat _mevzuat;
        public CustomerManager(IMevzuat mevzuat)
        {
            _mevzuat = mevzuat;
        }
        public void Add()
        {
            /*  int mevzuat = 1;

              if (mevzuat==1)
              {
                  Console.WriteLine("Müşteri birinci mevzuata göre  eklendi.");
              }
              else
              {
                  Console.WriteLine("Müşteri ikinici  mevzuata göre  eklendi.");
              }*/ //

            _mevzuat.islemYap(); // yukarıdaki if else'den tek satır ile hallettik

        }

    } // buradaki kodlama
    interface IMevzuat
    {
        void islemYap();
    }
    // Birinci mevzuat  bir IMevzuat  implementasyonudur.
    class BirinciMevzuat : IMevzuat
    {
        public void islemYap()
        {
            Console.WriteLine("Müşteri birinci mevzuata göre  eklendi.");
        }
    }
    // İkinci mevzuat  bir IMevzuat  implementasyonudur.
    class İkinciMevzuat : IMevzuat
    {
        public void islemYap()
        {
            Console.WriteLine("Müşteri ikinci mevzuata göre  eklendi.");
        }
    }
    // Üçüncü mevzuat  bir IMevzuat  implementasyonudur.
    class UcuncuMevzuat : IMevzuat // buraya yeni kod ekledim bu da open/closed örneğidir.
    {
        public void islemYap()
        {
            Console.WriteLine("Müşteri Üçüncü mevzuata göre  eklendi.");
        }
    }
}
