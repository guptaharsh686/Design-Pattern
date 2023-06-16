using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern_Exercise
{
    public class TwitterClient
    {
        public List<Tweet> getRecentTweets(String accessToken)
        {
            Console.WriteLine("Getting recent tweets");

            return new List<Tweet>();
        }
    }
}
