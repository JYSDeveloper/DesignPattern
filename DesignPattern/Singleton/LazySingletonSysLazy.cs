/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/25/2018 11:12:48 PM
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
    public class LazySingletonSysLazy
    {
        private static readonly Lazy<LazySingletonSysLazy> instance = new Lazy<LazySingletonSysLazy>(()=>new LazySingletonSysLazy());

        private LazySingletonSysLazy()
        { }
        public LazySingletonSysLazy GetInstance() { return instance.Value; }
    }
}
