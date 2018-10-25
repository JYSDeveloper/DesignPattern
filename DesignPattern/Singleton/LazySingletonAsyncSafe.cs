/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/25/2018 11:08:48 PM
 *
 * Contact by WeChat & QQ: 826420016  
 * Blog:  https://www.jianshu.com/u/fb4e636c3c21
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LazySingletonAsyncSafe
    {
        private LazySingletonAsyncSafe() { }
        private static LazySingletonAsyncSafe Instance;
        private static readonly object lockobj = new object();
        public LazySingletonAsyncSafe GetInstance()
        {
            if(Instance == null)
            {
                lock (lockobj)
                {
                    if (Instance == null)
                        Instance = new LazySingletonAsyncSafe();
                }
            }
            return Instance;
        }
    }
}
