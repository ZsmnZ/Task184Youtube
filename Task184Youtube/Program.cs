using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task184Youtube
{       
 public class Program
    {
        public static void Main(string[] args)
        {
            var sender = new Sender();
            var receiver = new Receiver();
            var commandOne = new CommandOne(receiver);

            sender.SetCommand(commandOne);

            string videoUrl = "https://youtu.be/3W2bja5Xk_Y";

            sender.RunDownload(videoUrl);
            sender.Description(videoUrl);
         
            Console.ReadKey();
        }
    }
}

