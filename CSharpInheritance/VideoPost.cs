using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inherits from Post

namespace CSharpInheritance
{
    internal class VideoPost : Post
    {
        private int timeLeft;
        private Timer timer;

        //member properties
        protected string VideoURL { get; set; }
        protected int Length { get; set; }

        //constructor
        public VideoPost() { }

        //constructor with parameters
        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
        {
            //The following properties and the GetNextID method are inherited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            //Property VideoURL is a member of VideoPost, but not of Post
            this.VideoURL = videoURL;
            this.Length = length;

            //set timeLeft to length of the video
            this.timeLeft = length;
        }

        //Details of the video post
        public override string ToString()
        {
            return $"{this.ID} - {this.Title} - {this.VideoURL} - {this.Length} seconds long by {this.SendByUsername}";
        }

        //Method to play the video post
        public void Play()
        {
            timer = new Timer(TimerCallback, null, 0, 1000);
        }

        private void TimerCallback(Object o)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                Console.WriteLine($"Video has {timeLeft} seconds left");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            timer.Dispose();
            Console.WriteLine($"Video stopped with {timeLeft} seconds remaining");
        }

    }
}
