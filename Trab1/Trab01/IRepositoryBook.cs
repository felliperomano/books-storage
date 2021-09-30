using System;
using System.Collections.Generic;
using System.Text;
//Fellipe Soares Romano CB3005411
//Stefany Lisboa da Silva CB3005551
namespace Trab01
{
    interface IRepositoryBook
    {
        BookList ToRead { get; }

        BookList Reading { get; }

        BookList Read { get; }

        IEnumerable<Book> All { get; }

        void Add(Book book);
    }
}
