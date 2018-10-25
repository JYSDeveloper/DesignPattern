/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/25/2018 10:53:20 PM
 *
 * Contact by WeChat & QQ: 826420016  
 * Blog:  https://www.jianshu.com/u/fb4e636c3c21
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
namespace Main
{
    public class SingletonTest
    {
        public static void Main(string[] arg)
        {
            var t1 = EagerSingleton.Instance;
            var t2 = EagerSingleton.Instance;
            Console.WriteLine(t1.GetHashCode());
            Console.WriteLine(t2.GetHashCode());
        }
    }
}
