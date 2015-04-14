using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseConnection.Exceptions;

namespace DatabaseConnection.Types
{
    public abstract class Mediafile
    {
        public String Title { get; protected set; }
        public String PathToFile { get; protected set; }

        protected Mediafile(string title, string pathToFile)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(pathToFile))
            {
                throw new InvalidDataException("Title or PathToFile is empty");
            }
            Title = title;
            PathToFile = pathToFile;
        }

        public abstract Control GetViewer();

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
