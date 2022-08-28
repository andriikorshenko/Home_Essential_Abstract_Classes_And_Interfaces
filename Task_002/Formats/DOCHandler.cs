using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal class DOCHandler : AbstractHandler
    {
        internal override void Open()
            => Console.WriteLine($"Файл с расширением {DocType} был создан!");

        internal override void Create()
            => Console.WriteLine($"Файл с расширением {DocType} был создан!");

        internal override void Change()
            => Console.WriteLine($"Файл с расширением {DocType} был изменен!");

        internal override void Save()
            => Console.WriteLine($"Файл с расширением {DocType} был сохранен!");

        internal DOCHandler(string docType)
            : base(docType) { }
    }
}
