using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Polymorhism
{
    class StoryTeller
    {
        public void AddTitle(string title,bool isHtml=false)
        {
            if(isHtml)
            {
                Console.WriteLine($"<h1>{title}</h1>");
                return;
            }

            Console.WriteLine(title);
            Console.WriteLine(new string('=', title.Length));
        }

        public void AddParagraph(string text,bool isHtml=false)
        {
            if (isHtml)
            {
                Console.WriteLine($"<p>{text}</p>");
                return;
            }

            Console.WriteLine(text);
            Console.WriteLine();
        }
    }
}
