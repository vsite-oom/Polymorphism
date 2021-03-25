using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Polymorhism
{
    public class HtmlFormatter : IFormatter
    {
        public void WriteHeading(string text, int level)
        {
            switch (level)
            {
                case 1:
                    Writer.WriteLine($"<h1>{text}</h1>");
                    break;
                case 2:
                    Writer.WriteLine($"<h2>{text}</h2>");
                    break;
                case 3:
                    Writer.WriteLine($"<h3>{text}</h3>");
                    break;
                default:
                    break;
            }
        }

        public void WriteParagraph(string text)
        {
            Writer.WriteLine($"<p>{text}</p>");
        }

        public void WriteHyperlink(string caption, string link)
        {
            Writer.WriteLine($"<a href={link} [{caption}]</a>");
        }

        public override string ToString()
        {
            return Writer.ToString();
        }

        private TextWriter Writer = new StringWriter();
    }
}
