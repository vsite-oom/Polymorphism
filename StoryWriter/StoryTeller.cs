using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Polymorhism
{
    class StoryTeller
    {
        public void AddTitle(string title, bool IsHTML = false)
        {
            if (IsHTML)
            {
                Console.WriteLine($"<h1>{title}</h1>");
            }
            else
            {
                Console.WriteLine(title);
                Console.WriteLine(new string('=', title.Length));
            }
        }

        public void AddParagraph(string text, bool IsHTML = false)
        {
            if (IsHTML)
            {
                Console.WriteLine($"<p>{text}</p>");
            }
            else
            {
                Console.WriteLine(text);
                Console.WriteLine();
            }
        }
    }
}
