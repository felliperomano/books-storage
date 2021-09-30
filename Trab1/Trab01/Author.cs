using System;
using System.Collections.Generic;
using System.Text;
//Fellipe Soares Romano CB3005411
//Stefany Lisboa da Silva CB3005551
namespace Trab01
{
    class Author
    {
        public string name { get; set; }
        public string email { get; set; }
        public char gender { get; set; }

        public Author(string n, string e, char g)
        {
            name = n;
            email = e;
            gender = g;

        }
        public Author()
        {
            name = "nomeTeste";
            email = "EmailTeste";
            gender = 'T';

        }
    }
}
