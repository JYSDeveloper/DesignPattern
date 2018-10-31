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

namespace EasyFactory
{
    public abstract class AbstractFood
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public abstract string Destription();
    }
}
