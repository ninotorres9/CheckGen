using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckGen
{
    public class Item
    {
        private string type;
        private string content;
        private bool isPassed;
        private string comment;
        public Item(string type, string content, bool isPassed, string comment)
        {
            this.Type = type;
            this.Content = content;
            this.IsPassed = isPassed;
            this.Comment = comment;
        }

        public string Content { get => content; set => content = value; }

        public string toString()
        {
            return String.Format("| {0} | {1} | {2} |",
                Type, Content, Comment);
        }

        public bool IsPassed { get => isPassed; set => isPassed = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Type { get => type; set => type = value; }

    }
}
