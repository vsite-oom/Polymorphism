using System;
using System.IO;

namespace Vsite.Oom.Polymorhism
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextWriter writer = new StreamWriter("MyStory.txt"))
            {
                Story story = new Story(new PlainTextFormatter());
                // following lines MUST NOT be changed!
                story.AddHeading("Story Title", 1);
                story.AddParagraphs(new string[]{ "This is the first paragraph.", "This is the second paragraph." });
                story.AddHeading("Section Title", 2);
                story.Hyperlink("This is a link", "www.amazon.com");
                story.AddParagraphs(new string[] { "This is the third paragraph." });

                writer.Write(story.ToString());

                Console.WriteLine(story.ToString());
            }

            using (TextWriter writer = new StreamWriter("MyWebPage.html"))
            {
                // TODO: When everything is done, following lines should be uncommented to generate a regular HTML page

                //Story story = new Story(new HtmlFormatter());
                //story.AddHeading("Story Title", 1);
                //story.AddParagraphs(new string[] { "This is the first paragraph.", "This is the second paragraph." });
                //story.AddHeading("Section Title", 2);
                //story.Hyperlink("This is a link", "www.amazon.com");
                //story.AddParagraphs(new string[] { "This is the third paragraph." });

                //writer.Write(story.ToString());
            }
        }
    }
}
