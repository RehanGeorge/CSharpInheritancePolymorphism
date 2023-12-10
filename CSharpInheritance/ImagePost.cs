using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Inherits from Post

namespace CSharpInheritance
{
    //ImagePost class inherits from Post class and adds a property (ImageURL) and two constructors
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return $"{this.ID} - {this.Title} with link {this.ImageURL} by {this.SendByUsername}";
        }
    }
}
