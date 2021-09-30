using System.Collections.Generic;

namespace Generics1
{
    public class Page
    {
        public Header PageHeader { get; set; }
        public Margin PageMargin { get; set; }
        public Footer PageFooter { get; set; }
        public List<Paragraph> PageParagraphs { get; set; }
    }
}
