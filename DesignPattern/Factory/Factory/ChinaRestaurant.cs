﻿/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/31/2018 9:43:33 PM
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
using Factory.Product;

namespace Factory.Factory
{
    public class ChinaRestaurant : IRestaurant
    {
        public AbstractFood CookFood()
        {
            return new Dumpling();
        }
    }
}
