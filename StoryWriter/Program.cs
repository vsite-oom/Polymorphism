using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Polymorhism
{
    class Program
    {
        static void Main(string[] args)
        {
            StoryTeller st = new StoryTeller();
            st.AddTitle("Snow-White and the Seven Dwarfs");
            st.AddParagraph("It was the middle of winter, and the snow-flakes were falling like feathers from  the  sky...");
        }
    }
}
