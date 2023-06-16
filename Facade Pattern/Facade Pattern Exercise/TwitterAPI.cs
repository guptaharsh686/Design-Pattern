using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern_Exercise
{
    public class TwitterAPI
    {
        private string appID;
        private string key;

        public TwitterAPI(string appID, string key)
        {
            this.appID = appID;
            this.key = key;
        }

        public List<Tweet> getRescentTweets()
        {
            var twitterClient = new TwitterClient();
            var tweets = twitterClient.getRecentTweets(getAccessToken());

            return tweets;
        }

        private String getAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.requestToken(appID, key);
            var accessToken = oauth.getAccessToken(requestToken);

            return accessToken;
        }
    }
}
