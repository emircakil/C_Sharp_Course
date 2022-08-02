using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._3
{
    class Post
    {
        private static int currentPostId = 0;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string sendByUsername { get; set; }
        protected bool isPublic { get; set; }

        public Post() {

            this.ID = 0;
            this.Title = "My new post";
            this.sendByUsername = "Emirhan Aydin Cakil";
            this.isPublic = true;
        }

        public Post(string title, string sendByUsername, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            this.sendByUsername = sendByUsername;
            this.isPublic = isPublic;
        }

        protected int GetNextID() {

            return ++currentPostId;
        }

        public void update(string title, bool isPublic) {

            this.Title = title;
            this.isPublic = isPublic;
        }



        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.sendByUsername );
        }

    }

    

}
