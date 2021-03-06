using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            AMevzuat aMevzuat = new AMevzuat();
            aMevzuat.Degerlendir();
            aMevzuat.Kaydet();
            Console.ReadLine();
        }
    }
    abstract class MevzuatBase
    {
        public abstract void Degerlendir();
        public void Kaydet()
        {
            Console.WriteLine("Kaydedildi.");
        }
    }

    class AMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.Write("A mevzuatına göre değerlendirildi");
        }
    }
    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.Write("B mevzuatına göre değerlendirildi");
        }
    }

    class CustemerManager //class operasyonları tutar - metodları tutar
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


    class Customer //class prop ları tutar
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
