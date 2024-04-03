using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Task_4
{
    internal class Magazine : ILibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int AvailableCopies { get; set; }

        public void CheckOut()
        {
            if (AvailableCopies > 0)
                Console.WriteLine($"{Title} - Satildi");
            else
                Console.WriteLine("Mehsul elde yoxdur");
        }

        public void Return()
        {
            Console.WriteLine("Mehsulu geri qaytardiniz");
        }
    }
}
