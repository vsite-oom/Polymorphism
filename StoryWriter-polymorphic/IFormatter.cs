using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Polymorhism
{
    public interface IFormatter
    {
        void WriteHeading(string text, int level);
        void WriteParagraph(string text);
        void WriteHyperlink(string caption, string link);
    }
}
