using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleTon
{
    class Counter
    {
        public int count = 0;

        public static Counter c = new Counter();
        public int counts() 
        {
            return count++;
        }

        public static Counter cMethod()
        {
            return c;
        }
    }
}
