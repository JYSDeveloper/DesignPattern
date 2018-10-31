/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/31/2018 9:21:38 PM
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

namespace EasyFactory
{
    public class Menu
    {
        /// <summary>
        /// 根据需求创建对应的产品，没有对应的工厂类，把Client和工厂类合并一起，就是简单工厂
        /// </summary>
        /// <param name="foodName"></param>
        /// <returns></returns>
        public static string ChooseFood(string foodName)
        {
            switch (foodName)
            {
                case "SeaFood":
                    return new SeaFood().Destription();
                case "Vegetable":
                    return new Vegetable().Destription();
            }
            return null;
        }
    }
}
