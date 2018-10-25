/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/25/2018 10:48:41 PM
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
    public sealed class EagerSingleton
    {
        private EagerSingleton() { }
        public static readonly EagerSingleton Instance = new EagerSingleton();
    }
}
