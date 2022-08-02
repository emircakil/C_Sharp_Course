using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance._3
{
    internal class ImagePost : Post
    {
        public string myLink { get; set; }

        public ImagePost(string Title, string sendByUsername, bool isPublic, string myLink) { 
        
            this.ID = GetNextID();
            this.Title = Title;
            this.sendByUsername = sendByUsername;
            this.isPublic = isPublic;

            this.myLink = myLink;

        }

    }
}
