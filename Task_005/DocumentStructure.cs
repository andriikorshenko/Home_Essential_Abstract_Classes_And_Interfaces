using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_005
{
    internal abstract class DocumentStructure 
    {
        internal abstract string Title { get; set; }

        internal abstract string Body { get; set; }

        internal abstract string Footer { get; set; }
    }
}
