/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/31/2018 9:37:47 PM
 *
 * Contact by WeChat & QQ: 826420016  
 * Blog:  https://www.jianshu.com/u/fb4e636c3c21
 * GitHub: https://github.com/JYSDeveloper
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Product
{
    public abstract class AbstractFood
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public abstract string Discription();
    }
}
