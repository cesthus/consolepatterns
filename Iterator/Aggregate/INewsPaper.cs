using Iterator.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Aggregate
{
    public interface INewsPaper
    {
        IIterator CreateIterator();
    }
}
