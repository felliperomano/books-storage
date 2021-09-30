using System;
//Fellipe Soares Romano CB3005411
//Stefany Lisboa da Silva CB3005551
namespace Trab01
{
    class Program
    {
        static void Main(string[] args)
        {
            var _repo = new FakeBookRepository();

            ImprimeLista(_repo.ToRead);
            ImprimeLista(_repo.Reading);
            ImprimeLista(_repo.Read);





            Console.ReadKey();
        }

        static void ImprimeLista(BookList lista)
        {
            Console.WriteLine(lista);
        }
    }
}
