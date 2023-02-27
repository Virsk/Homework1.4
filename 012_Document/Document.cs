
using _012_Document;

namespace Classes
{
    class Document : AbstractDoc
    {
        public Document(string title, string body, string footer)
        {
            FooterContent = footer;
            BudyContent = body;
            TitleContent = title;
        }
    }
}
