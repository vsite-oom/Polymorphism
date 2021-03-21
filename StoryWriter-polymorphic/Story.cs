namespace Vsite.Oom.Polymorhism
{
    public class Story
    {
        public Story(PlainTextFormatter formatter)
        {
            this.formatter = formatter;
        }

        // Implementation of these methods MUST NOT be changed!
        public void AddHeading(string text, int level)
        {
            formatter.WriteHeading(text, level);
        }

        public void AddParagraphs(string[] text)
        {
            foreach (string paragraph in text)
                formatter.WriteParagraph(paragraph);
        }

        public void Hyperlink(string caption, string link)
        {
            formatter.WriteHyperlink(caption, link);
        }

        public override string ToString()
        {
            return formatter.ToString();
        }

        private readonly PlainTextFormatter formatter;
    }
}
