using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
    public class Category
    {
        public String Title { get; private set; }
        public Category Parent { get; private set; }
        public List<Post> Posts { get; private set; }

        public Category(string title, Category parent, List<Post> posts)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidDataException("title is null or empty");
            }
            Title = title;
            Parent = parent;
            Posts = posts;
        }

        public Category(string title, List<Post> posts) : this(title, null, posts)
        {
            
        }

        public override string ToString()
        {
            var postsString = string.Join(",", Posts.Select(post => post.ToString()));
            return String.Format("{{Title={0},Parrent={1},Posts=[{2}]}}", Title, Parent.Title, Posts);
        }
    }
}
