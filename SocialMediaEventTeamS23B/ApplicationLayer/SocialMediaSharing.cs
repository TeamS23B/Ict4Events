using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DatabaseConnection;
using DatabaseConnection.Types;

namespace ApplicationLayer
{
    public class SocialMediaSharing
    {
        public string Username { get; set; }
        private DataBaseConnection dbConnection;

        /// <summary>
        /// Creates a new instance of Social Media Sharing
        /// </summary>
        /// <param name="dbConnection">A db connection to work against</param>
        /// <param name="username">The currently loged in user</param>
        public SocialMediaSharing(DataBaseConnection dbConnection, string username)
        {
            this.Username = username;
            this.dbConnection = dbConnection;
        }

        /// <summary>
        /// Gets a list of posts
        /// </summary>
        /// <returns>All the posts in the top layer</returns>
        public List<Post> GetPosts()
        {
            return dbConnection.GetPostsOf(0);
        }

        /// <summary>
        /// Post a message to the database
        /// </summary>
        /// <param name="post">The message to post</param>
        public void PostMessage(Post post)
        {
            if (post.Mediafile==null)
            {
                dbConnection.AddPost(post.Uploader, 1, post.Title, post.Description, -1, post.PostedOn);
            }
            else
            {
                dbConnection.AddMediaPost(post.Uploader, 1, post.Title, post.Description, -1, post.PostedOn,post.Mediafile.PathToFile);
            }
            
        }

     
    }
}
