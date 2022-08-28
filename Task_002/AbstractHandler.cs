using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_002
{
    internal abstract class AbstractHandler
    {
        internal abstract void Open();

        internal abstract void Create();

        internal abstract void Change();

        internal abstract void Save();

        internal string DocType { get; }

        internal AbstractHandler(string docType)
        { 
            DocType = docType;
        }
    }
}
