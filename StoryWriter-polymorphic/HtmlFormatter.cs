using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.UI;

namespace Vsite.Oom.Polymorhism
{
    public class HtmlFormatter : IFormatter
    {
        
        public void WriteHeading(string text, int level)
        {
            switch (level)
            {
                case 1:
                    writer.WriteLine($"<h1>{text}</h1>");
                    break;
                case 2:
                    writer.WriteLine($"<h2>{text}</h2>");
                    break;
            }
        }

        public void WriteParagraph(string text)
        {
            writer.WriteLine($"<p>{text}</p>");
        }

        public void WriteHyperlink(string caption, string link)
        {
            writer.WriteLine($"<a href=\"{link}\">{caption}</a>");
        }

        public override string ToString()
        {
            return writer.ToString();
        }

        private TextWriter writer = new StringWriter();
    }
}
