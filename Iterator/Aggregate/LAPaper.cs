using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
    /// <summary>
    /// Concrete aggregate
    /// </summary>
    public class LAPaper : INewsPaper
    {
        private string[] _reporters;
        public LAPaper()
        {
            _reporters = new[]
            {
                "Jerry Glover - LA",
                "Isa Lime - LA",
                "Danny Adams"
            };
        }

        public IIterator CreateIterator()
        {
            return new LAPaperIterator(_reporters);
        }
    }
}
