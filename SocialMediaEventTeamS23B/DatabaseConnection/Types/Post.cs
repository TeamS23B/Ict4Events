using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exceptions;

namespace DatabaseConnection.Types
{
    public class Post
    {
        public List<Post> Comments { get; set; }
        public Mediafile Mediafile { get; private set; }
        public String Description { get; private set; }
        public int Likes { get; private set; }
        public int Flags { get; private set; }
        public DateTime PostedOn { get; private set; }
        public String Uploader { get; private set; }
        public Category Category { get; private set; }
        public int Id { get; private set; }

        public String Title  { get; set; }
        public bool Visible { get; set; }

        public Post(string title, List<Post> comments, Mediafile mediafile, string description, int likes, int flags, DateTime postedOn, string uploader, Category category, int id)
        {
            if(comments==null)Comments=new List<Post>();//if no comments create empty list(to avoid errors)
            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(uploader) || string.IsNullOrEmpty(title))
            {
                throw new InvalidDataException("Title, Uploader or Descirption is empty");
            }
            if (likes < 0 || flags < 0)
            {
                throw new InvalidDataException("Likes or Flags is below zero");
            }
            //if (category == null)
            //{
            //    throw new InvalidDataException("category is null");
            //}
            if (id < 0)
            {
                throw new InvalidDataException("id < 0");
            }
            this.Comments = comments;
            this.Mediafile = mediafile;//nullable
            this.Description = description;
            this.Likes = likes;
            this.Flags = flags;
            this.PostedOn = postedOn;
            this.Uploader = uploader;
            this.Category = category;
            this.Id = id;
            this.Title = title;
            
        }

        public Post(string title, List<Post> comments, string description, int likes, int flags, DateTime postedOn, string uploader, Category category, int id):this(title,comments,null,description,likes,flags,postedOn,uploader,category,id)
        {
            
        }

        public override string ToString()
        {
            return "Title: " + Title + " | " + PostedOn;
        }
    }
}
