using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Linked to ImagePost and VideoPost

namespace CSharpInheritance
{
    internal class Post
    {
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        public string Title { get; set; }
        public string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        //default constructor. If a derived class does not invoke a base-
        //class constructor explicitly, the default constructor is called
        //implicitly
        public Post()
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Rehan George";
        }

        //Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.IsPublic = isPublic;
            this.SendByUsername = sendByUsername;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //Virtual method override of the ToString method that is inherited
        //from System.Object
        public override string ToString()
        {
            return String.Format($"{this.ID} - {this.Title} - by {this.SendByUsername}");
        }
    }
}
