using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseConnection.Exeptions;

namespace DatabaseConnection.Types
{
    class Category
    {
        public String Title { get; private set; }
        public Category Parrent { get; private set; }
        public List<Post> Posts { get; private set; }

        public Category(string title, Category parrent, List<Post> posts)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidDataException("title is null or empty");
            }
            Title = title;
            Parrent = parrent;
            Posts = posts;
        }

        public Category(string title, List<Post> posts) : this(title, null, posts)
        {
            
        }

        public override string ToString()
        {
            var postsString = string.Join(",", Posts.Select(post => post.ToString()));
            return String.Format("{{Title={0},Parrent={1},Posts=[{2}]}}", Title, Parrent.Title, Posts);
        }
    }
}
