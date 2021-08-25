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

        private static Counter c = new Counter();
        public virtual int counts()
        {
            return count++;
        }
        private static object threadObj = new object();// double thread

        public static Counter cMethod()
        {
            if (c == null)// for duble thread save
            {
                lock (threadObj)// for save double thread
                {
                    //Lazy call
                    //**
                    if (c == null)
                    {
                        c = new Counter();//normal using
                    }
                    //***
                }
            }
            

            return c;
        }
    }
}
