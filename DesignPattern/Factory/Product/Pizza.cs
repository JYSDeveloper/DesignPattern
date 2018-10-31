/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/31/2018 9:39:02 PM
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
    public class Pizza : AbstractFood
    {
        public override string Discription()
        {
            return typeof(Pizza).Name;
        }
    }
}
