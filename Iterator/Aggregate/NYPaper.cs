using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    public class NYPaper : INewsPaper
    {
        private List<string> _reporters;
        public NYPaper()
        {
            _reporters = new List<string>
            {
                "Susan Lee - NY",
                "Smith Doe - NY",
                "Sky Taylor - NY"
            };
        }

        public IIterator CreateIterator()
        {
            return new NYPaperIterator(_reporters);
        }
    }
}
