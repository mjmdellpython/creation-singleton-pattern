using System;
using System.Threading.Tasks;

namespace singleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            /* User u1 = User.getUser();
             User u2 = User.getUser();
             //User u2 = new User();Old virsion

             u1.addUser();
             u2.addUser();

             Console.WriteLine($"user1 : "+ u1.userInter.ToString());
             Console.WriteLine($"user2 : "+ u2.userInter.ToString());
             Console.WriteLine();
             u1.addUser();
             Console.WriteLine($"user1 : " + u1.userInter.ToString());
             Console.WriteLine($"user2 : " + u2.userInter.ToString());*/


            //other examble for add counter to implement singleton
            //Counter c1 = new Counter();
            //Counter c2 = new Counter();

            /*The normal using without threading
             Counter c1 = Counter.cMethod();
                c1.counts();
                c1.counts();
                Console.WriteLine($"count _ 1 : " + c1.count.ToString());
            Counter c2 = Counter.cMethod();
                c2.counts();
                c2.counts();
                Console.WriteLine($"count _ 2 : " + c2.count.ToString());

             */

            Task t1 = Task.Factory.StartNew(()=>
            {
                Counter c1 = Counter.cMethod();
                c1.counts();
                c1.counts();
                Console.WriteLine($"count _ 1 : " + c1.count.ToString());
            });

            Task t2 = Task.Factory.StartNew(()=> {
                Counter c2 = Counter.cMethod();
                c2.counts();
                //c2.counts();
                Console.WriteLine($"count _ 2 : " + c2.count.ToString());
            });
            t1.Wait();
            t2.Wait();

            
            
        }
    }
}
