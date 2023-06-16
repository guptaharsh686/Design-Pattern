using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern_Exercise
{
    public class Demo
    {
        public static void show()
        {
            var twitterApi = new TwitterAPI("appid", "key");
            var tweets = twitterApi.getRescentTweets();
        }
    }
}
