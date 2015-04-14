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

        public Category(string title, Category parent)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidDataException("title is null or empty");
            }
            Title = title;
            Parent = parent;
        }

        public Category(string title) : this(title, null)
        {
            
        }

        public override string ToString()
        {
            return String.Format("{{Title={0},Parrent={1}}}", Title, Parent.Title);
        }
    }
}
