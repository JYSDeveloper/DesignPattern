/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/25/2018 10:56:27 PM
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
    /// <summary>
    /// In This Way, It's not Thread Safe Way
    /// More than one thread maybe create different Instance
    /// </summary>
    public sealed class LazySingleton
    {
        private LazySingleton() { }
        private static LazySingleton Instance;
        public LazySingleton GetInstance()
        {
            if (Instance == null)
                Instance = new LazySingleton();
            return Instance;
        }
    }
}
