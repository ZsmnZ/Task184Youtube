using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;


namespace Task184Youtube
{
    public class CommandOne : ICommand
    {
        Receiver receiver;
        YoutubeClient youtube = new YoutubeClient();

        public CommandOne(Receiver receiver)
        {
            this.receiver = receiver;
        }
        public async void RunDownload(string videoUrl)
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
            try
            {
                var video = youtube.Videos.GetAsync(videoUrl);
                var streamManifest = youtube.Videos.Streams.GetManifestAsync(video.Result.Id);
                var streamInfo = streamManifest.Result.GetMuxedStreams().GetWithHighestVideoQuality();

                await youtube.Videos.Streams.DownloadAsync(streamInfo, $"{video.Result.Title}.{streamInfo.Container}");
                Console.WriteLine("\nЗагрузка видео...");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public async void Description(string videoUrl)
        {
            var yuotubeVideo = await youtube.Videos.GetAsync(videoUrl);
            Console.WriteLine($"\n{yuotubeVideo.Description}");
        }
    }
}
