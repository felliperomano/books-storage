using System;
using System.Collections.Generic;
using System.Text;
//Fellipe Soares Romano CB3005411
//Stefany Lisboa da Silva CB3005551
namespace WebTrab01
{
    class FakeAuthorRepository
    {
        public Author[] authors = new Author[4];

        public FakeAuthorRepository()
        {
            authors[0] = new Author("nome1","email1",'A');
            authors[1] = new Author("nome2", "email2", 'B');
            authors[2] = new Author("nome3", "email3", 'C');
            authors[3] = new Author("nome4", "email4", 'D');
        }
    }
}
