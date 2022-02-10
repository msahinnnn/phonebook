using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BookOperations newBook = new BookOperations();
            newBook.showMenu();
            Console.ReadKey();
            
        }
    }
}
