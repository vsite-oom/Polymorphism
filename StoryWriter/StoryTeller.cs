using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Polymorhism
{
    class StoryTeller
    {
        public void AddTitle(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine(new string('=', title.Length));
        }

        public void AddParagraph(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine();
        }
    }
}
