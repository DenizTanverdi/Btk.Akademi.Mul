using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversiponPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IGida
    {
        void Yap(bool Kakao);
    }

    class Imalat
    {
        //High Level Class
        IGida gida;
        public Imalat()
        {
            gida = new Kek();
        }
        public void Olustur()
        {
            gida.Yap(true);
        }
    }

    class Kek : IGida
    {
        //Low Level Method
        public void Yap(bool Kakao)
        {
            //Process
        }
    }
}
