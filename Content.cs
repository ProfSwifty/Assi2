using System;
using System.Collections.Generic;

namespace Assi2
{
    //abstract Content class, basis for all the Post classes,
    //Defines methods that will be implemented by the Post objects for various uses in the program.
    abstract class Content
    {
        public abstract Content Clone();
        public void Print()
        {
            Console.WriteLine(GetPrintableTitle());
            Console.WriteLine(GetPrintableBody());
        }
        public abstract string GetPrintableTitle();
        public abstract string GetPrintableBody();
    }
}