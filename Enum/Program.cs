using System;

namespace Enum
{
    class Program
    {
        //Aldığı değeri vermek için int ekledim
         
        static void Main(string[] args)
        {
            Console.WriteLine((int)Kategoriler.Elektronikler);
            Console.ReadKey();

        }
        //Önemli bir yeri vardır çünkü tekrar yazımları kodları engeller Hız ve verim kazandırır
        enum Kategoriler
        {
            Elektronikler = 3,
            Hırdavat=2,
            Güzellik=4,
            Giyim=5
             }
    }
}
