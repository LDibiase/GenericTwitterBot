using System;
using System.Collections.Generic;
using TweetSharp;

namespace GenericTwitterBot
{
    public class Program
    {
        private static string customer_key = "c7IFmzdrLZGLKNGBMhISlNx0V";
        private static string customer_key_secret = "7l9DlYayaNnQqtz6aG3lVNbN2v8aWOdEtiwIqNmbOTpp21RBqK";
        private static string access_token = "1014552154693095425-u6wdM1UNBn4sffknb6t7lklSF58PmF";
        private static string access_token_secret = "I4790PDx8aztuTqMGynRjx4godDROdey6HzV5DNkePWSs";

        private static TwitterService service = new TwitterService(customer_key, customer_key_secret, access_token, access_token_secret);

        private static List<string> accountList = new List<string>() { "@Talruin", "@takashi_irl", "@Nicor_93", "@fedegualdrini", "@LDibiase92" };

        static void Main(string[] args)
        {
            //picking account
            string account = string.Empty;

            Random rnd = new Random();
            int index = rnd.Next(accountList.Count);

            account = accountList[index];

            SendTweet("Aguante trashy " + account);
            //SendTweet("Aguante trashy");
        }

        private static void SendTweet(string status)
        {
            var sendTweetOptions = new SendTweetOptions { Status = status };
            service.SendTweet(sendTweetOptions);
        }
    }
}
