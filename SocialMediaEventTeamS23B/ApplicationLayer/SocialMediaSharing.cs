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

        public SocialMediaSharing(DataBaseConnection dbConnection, string username)
        {
            this.Username = username;
            this.dbConnection = dbConnection;
        }

        // Prompts a windows explorer window to select a file. When OK is clicked, return the full path of the selected file.
        public string SelectFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult dr = ofd.ShowDialog();
            string fileLocation = "Unknown";
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                fileLocation = Path.GetFullPath(ofd.FileName);
            }
            return fileLocation;
        }

        public List<Post> GetPosts()
        {
            return dbConnection.GetPostsOf(0);
        }

     
    }
}
