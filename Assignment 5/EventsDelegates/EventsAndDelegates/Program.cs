using System;

namespace EventsAndDelegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var video = new Video(){ Title = "Video 1"};
            var videoEncoder = new VideoEncoder();
            
            videoEncoder.Encode(video); 
            
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("Mailservice: Sending an email...");
        }
    }
}