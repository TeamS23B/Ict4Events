using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
    class Post
    {
        public List<Post> Comments { get; private set; }
        public Mediafile Mediafile { get; private set; }
        public String Description { get; private set; }
        public int Likes { get; private set; }
        public int Flags { get; private set; }
        public DateTime PostedOn { get; private set; }
        public String Uploader { get; private set; }
        public Category Category { get; private set; }

        public Post(List<Post> comments, Mediafile mediafile, string description, int likes, int flags, DateTime postedOn, string uploader, Category category)
        {
            if(comments==null)Comments=new List<Post>();//if no comments create empty list(to avoid errors)
            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(uploader))
            {
                throw new InvalidDataException("Uploader or Descirption is empty");
            }
            if (likes <= 0 || flags <= 0)
            {
                throw new InvalidDataException("Likes or Flags is below zero");
            }
            if (category == null)
            {
                throw new InvalidDataException("category is null");
            }
            Comments = comments;
            Mediafile = mediafile;//nullable
            Description = description;
            Likes = likes;
            Flags = flags;
            PostedOn = postedOn;
            Uploader = uploader;
            Category = category;
        }

        public Post(List<Post> comments, string description, int likes, int flags, DateTime postedOn, string uploader, Category category):this(comments,null,description,likes,flags,postedOn,uploader,category)
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
