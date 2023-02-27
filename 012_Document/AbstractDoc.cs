using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Document
{
    internal abstract class AbstractDoc
    {
        string budyContent;
        string footerContent;
        string titleContent;

        public string BudyContent
        {
            private get
            {
                if (budyContent != null)
                    return budyContent;
                else
                    return "Тіло документу відсутнє.";
            }
            set
            {
                budyContent = value;
            }
        }
        public string FooterContent
        {
            private get
            {
                if (footerContent != null)
                    return footerContent;
                else
                    return "Нижній колонтитул відсутній.";
            }
            set
            {
                footerContent = value;
            }
        }
        public string TitleContent
        {
            private get
            {
                if (titleContent != null)
                    return titleContent;
                else
                    return "Заголовок відсутній.";
            }
            set
            {
                titleContent = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(budyContent);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(footerContent);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(titleContent);
            Console.ResetColor();
        }
    }
}
