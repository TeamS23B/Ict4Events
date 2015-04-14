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
            Comments = comments;
            Mediafile = mediafile;//nullable
            Description = description;
            Likes = likes;
            Flags = flags;
            PostedOn = postedOn;
            Uploader = uploader;
            Category = category;
            this.Id = id;
            }

        public Post(string title, List<Post> comments, string description, int likes, int flags, DateTime postedOn, string uploader, Category category, int id):this(title,comments,null,description,likes,flags,postedOn,uploader,category,id)
        {
            
        }

        public override string ToString()
        {
            PropertyDescriptorCollection coll = TypeDescriptor.GetProperties(this);
            StringBuilder builder = new StringBuilder();
            builder.Append("{");
            foreach (PropertyDescriptor pd in coll)
            {
                builder.Append(string.Format("{0}={1},", pd.Name, pd.GetValue(this).ToString()));
            }
            builder.Append("}");
            return builder.ToString();
        }
    }
}
