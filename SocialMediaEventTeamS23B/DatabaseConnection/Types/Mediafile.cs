using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection.Types
{
    public abstract class Mediafile
    {
        public String Title { get; protected set; }
        public String PathToFile { get; protected set; }

        protected Mediafile(string title, string pathToFile)
        {
            Title = title;
            PathToFile = pathToFile;
        }

        public abstract Control GetViewer();

    }

    public class VideoFile : Mediafile
    {
        public VideoFile(string title, string pathToFile)
            : base(title, pathToFile)
        {

        }

        public override Control GetViewer()
        {
            //todo
            return null;
        }
    }

    public class PictureFile : Mediafile
    {
        public PictureFile(string title, string pathToFile)
            : base(title, pathToFile)
        {

        }

        public override Control GetViewer()
        {
            //todo
            return null;
        }
    }
}
