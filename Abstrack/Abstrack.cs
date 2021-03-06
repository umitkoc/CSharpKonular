using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrack
{
    class Program
    {
        static void Main(string[] args)
        {
            RuyaManager manager = new RuyaManager(new Umut());
            manager.KimNeGordu("Ümit");
            Console.ReadKey();
        }
    }
    class RuyaManager
    {
        private ARuya _ruya;

        public RuyaManager(ARuya ruya)
        {
            _ruya = ruya;
        }

        public void KimNeGordu(string name)
        {
            _ruya.name = name;
            _ruya.Ruyam();
            _ruya.Uyandı();
        }
    }

    class Umut : ARuya
    {
        public override void Ruyam()
        {
            Console.WriteLine("rüyamda özel okulda eğitim görüyordum");
        }
    }
    class Elif : ARuya
    {
        public override void Ruyam()
        {
            Console.WriteLine("rüyamda güzel bir arabam vardı ve sürüyordum");
        }
    }
    abstract class ARuya
    {
        public abstract void Ruyam();
        public string name;
        public void Uyandı()
        {
            Console.WriteLine($"{name}:Sonra uyandım ve bitti");
        }

    }
}