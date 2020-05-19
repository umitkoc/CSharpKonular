using System;


namespace Abstrack
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstrackManager manager=new AbstrackManager(new maruf());
            manager.Loading("maruf");

            Console.ReadKey();
        }
    }
    class AbstrackManager
    {
        private Property _property;

        public AbstrackManager(Property property)
        {
            _property = property;
        }
        public void Loading(string name)
        {
            _property.Name(name);
            _property.property(name);
        }
    }
    abstract class Property
    {
        public virtual void property(string name)
        {
            Console.WriteLine("default information  loading...");
        }
        public abstract void Name(string name);
    }
    class maruf:Property
    {
        public override void property(string name)
        {
            Console.WriteLine($"{name} information  loading...");
        }

        public override void Name(string name)
        {
           Console.WriteLine($"{name} 22 years old and student");
        }
    }

    class Umit:Property
    {
        public override void Name(string name)
        {
            Console.WriteLine($"{name} 21 years old and student");
        }
        public override void property(string name)
        {
            Console.WriteLine($"{name} information  loading...");
        }
    }



}
