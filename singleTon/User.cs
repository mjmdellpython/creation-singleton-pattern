using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleTon
{
    public class User
    {
        public int userInter = 0;

        private static User user = new User();//singleton pattren
        private User()
        {
                
        }
        
        public void addUser()
        {
            userInter++;
        }

        //the metod should be static to can call it to implementing program
        public static User getUser()//singleton pattren, using static to
                                    //not make another copy for it in memory
        {
            return user;
        }
    }


}
