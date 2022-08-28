using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_005
{
    internal class Document : DocumentStructure
    {
        private string title, body, footer;
        internal override string Title
        {
            get
            {
                if (title != null)
                    return title;
                else
                    return "Заголовок отсутствует!";
            }
            set => title = value;
        }
        internal override string Body
        {
            get
            {
                if (body != null)
                    return body;
                else
                    return "Тело документа отсутствует!";
            }
            set => body = value;
        }
        internal override string Footer
        {
            get
            {
                if (footer != null)
                    return footer;
                else
                    return "Подпись отсутствует!";
            }
            set => footer = value;
        }

        internal void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Title);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Body);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Footer);
            Console.ResetColor();
        }
    }
}
