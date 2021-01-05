using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Iterator
{
    public interface IIterator
    {
        void First(); //Sets current element to the first element
        string Next(); //Advances current to next element
        bool IsDone(); //Check if end of collection
        string CurrentItem(); //Returns the current element

    }
}
