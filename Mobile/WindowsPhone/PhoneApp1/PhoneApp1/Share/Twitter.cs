using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TweetSharp;


namespace PhoneApp1
{
    class Twitter
    {

        public void Share()
        {
           /* var service = new TwitterService("SPNCQ955kagIEbniEwvxdIzBi", "986IC6TJV6YABlwSvrG5lpT3hhW0ucJPBuBk2B3afV4PFeogDF");
            service.AuthenticateWith("2888036165-IAmUevD8KvFbU5RQ3VdofoqAoDSVznc5wRwsdXU", "7ApKrr8yMODUIh9xigQx8wJGM15ipTz5Ci7lAUVeqMFMP");
            service.SendTweet("I'm totally tweeting!");
            service.SendTweet()*/
            TwitterClientInfo twitterClientInfo = new TwitterClientInfo();
            twitterClientInfo.ConsumerKey = "SPNCQ955kagIEbniEwvxdIzBi"; //Read ConsumerKey out of the app.config
            twitterClientInfo.ConsumerSecret = "986IC6TJV6YABlwSvrG5lpT3hhW0ucJPBuBk2B3afV4PFeogDF"; //Read the ConsumerSecret out the app.config

            TwitterService twitterService = new TwitterService(twitterClientInfo);

            twitterService.AuthenticateWith("2888036165-IAmUevD8KvFbU5RQ3VdofoqAoDSVznc5wRwsdXU", "7ApKrr8yMODUIh9xigQx8wJGM15ipTz5Ci7lAUVeqMFMP");
            /*
            string tweetMessage;
            tweetMessage = "test tweet";
            TwitterStatus twitterStatus = twitterService.SendTweet(new SendTweetOptions { Status = "Hello world" },);

            */
            private void MyMethod(IEnumerable<TwitterStatus> status, TwitterResponse response) 
            {
                
            }




            //Console.ReadKey();
            //TwitterStatus result = service.SendTweet(new SendTweetOptions
       //{
       // Status = "Hello, world!"
      // });
            //
        }
        
    }
}
