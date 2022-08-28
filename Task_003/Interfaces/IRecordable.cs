using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_011
{
    internal interface IRecordable
    {
        internal void Record();

        internal void Pause();

        internal void Stop();
    }
}
