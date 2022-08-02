using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Inheritance._3
{
    internal class VideoPost :Post
    {

        protected bool isPlaying = true;
        protected int currDuration = 0;

        Timer timer;


        public string VideoURL { get; set; }
        public  int VideoLength { get; set; }

        public static int lng;

        public VideoPost(string title, string sendByUsername, bool isPublic, string VideoURL, int VideoLength) {

            this.ID = GetNextID();
            this.Title = title;
            this.sendByUsername = sendByUsername;
            this.isPublic= isPublic;
            
            // Uniqe variable
            this.VideoURL = VideoURL;
            this.VideoLength = VideoLength;

            lng = VideoLength * 100;

           

            Console.WriteLine("If you pressed p video is started and you press s video is stopped. If you press c and you write " +
                "any number you go this second.");

        }

        public void Play() {

            if (isPlaying) {

                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0 ,1000);
                isPlaying = false;
            }


        }

        public void TimerCallback(Object o) {

            if (currDuration < lng)
            {

                currDuration++;
                Console.WriteLine("Video at {0}", currDuration);
                GC.Collect();

            }
            else {
                

                Stop();
            }
        }

        public void Stop() {

            if (!isPlaying)
            {

                Console.WriteLine("Video at stopped {0}", currDuration);

                currDuration = 0;

                timer.Dispose();
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} - by {4}", this.ID, this.Title, VideoURL, VideoLength, this.sendByUsername);
        }

       


     


    }
}
