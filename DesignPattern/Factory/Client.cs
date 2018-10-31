/*
 * CreateBy:  Alex.Jiang
 *
 * DateTime: 10/31/2018 9:45:49 PM
 *
 * Contact by WeChat & QQ: 826420016  
 * Blog:  https://www.jianshu.com/u/fb4e636c3c21
 * GitHub: https://github.com/JYSDeveloper
 */
using Factory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Client
    {
        public static void GetFood(string kindOfFood)
        {
            IRestaurant restaurant;
            switch (kindOfFood)
            {
                case "China":
                    restaurant = new ChinaRestaurant();
                    break;
                case "Foreign":
                    restaurant = new WesternRestaurant();
                    break;
                default:
                    restaurant = new ChinaRestaurant();
                    break;
            }
            Console.WriteLine(restaurant.CookFood().Discription());

            //Can Modify by RefactorAPI, get Factory without Switch Case
        }
    }
}
