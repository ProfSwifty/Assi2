using System;

namespace Assi2
{
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
