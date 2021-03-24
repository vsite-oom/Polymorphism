using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Polymorhism
{
    public class HtmlFormatter:IFormatter
    {
        public void WriteHeading(string text, int level)
        {
            writer.WriteLine($"<h{level}>{text}</h{level}>");
            writer.WriteLine();

        }

        public void WriteParagraph(string text)
        {
            writer.WriteLine($"<p>{text}</p>");
            writer.WriteLine();

        }

        public void WriteHyperlink(string caption, string link)
        {
            writer.WriteLine($"<a href=\"{link}\">{caption}</a>");
            writer.WriteLine();

        }


        public override string ToString()
        {
            return writer.ToString();
        }

        private TextWriter writer = new StringWriter();
    }
}
