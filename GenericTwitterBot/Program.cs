using System;
using System.Collections.Generic;
using TweetSharp;

namespace GenericTwitterBot
{
    public class Program
    {
        private static string customer_key = "VpYs3vdxVQxPKNzcemr45o7BU";
        private static string customer_key_secret = "GgvHC3tS6yDcExU2K9OuDncSqj7dR6aOwIF2ySYCG5lr4AnhqU";
        private static string access_token = "2999012704-NAHGsmX8rcxSA048EHzGuZNgHEiMYto3kuCJ04L";
        private static string access_token_secret = "cqiIpQkjnYTrIth79F2S84kqSc4cLWscRE3kXlBRlx4O1";

        private static TwitterService service = new TwitterService(customer_key, customer_key_secret, access_token, access_token_secret);

        private static List<string> accountList = new List<string>() { "@Talruin", "@takashi_irl", "@Nicor_93", "@fedegualdrini", "@LDibiase92" };

        static void Main(string[] args)
        {
            //picking account
            string account = string.Empty;

            Random rnd = new Random();
            int index = rnd.Next(accountList.Count);

            account = accountList[index];

            //SendTweet("Aguante trashy " + account);
            SendTweet("Aguante trashy");
        }

        private static void SendTweet(string status)
        {
            var sendTweetOptions = new SendTweetOptions { Status = status };
            service.SendTweet(sendTweetOptions);
        }
    }
}
