using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project01
{
    class GenericEx<T>
    {
        public void Swap(ref T sourc, ref T target)
        {
            T temp = target;
            sourc = target;
            target = temp;
        }

        public void Copy<U>(ref U sourc, ref U target)
        {
            target = sourc;
        }
    }
}
