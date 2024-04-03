using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Task_4
{
    public interface ILibraryItem
    {
        public abstract string Title { get; set; }
        public abstract string Author { get; set; }
        public abstract int AvailableCopies { get; set; }



        public abstract void CheckOut();

        public abstract void Return();

    }
}
