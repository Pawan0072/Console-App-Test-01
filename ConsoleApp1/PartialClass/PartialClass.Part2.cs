using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.PartialClass
{
    public partial class PartialClass
    {
        public PartialClass(string test)
        {
            Console.WriteLine("PartialClass constructor called. " + test);
        }

        public void Method2()
        {
            Console.WriteLine("Method2 called at second created file.");
        }
    }
}
