using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Visitors
{
    /// <summary>
    /// The visitor interface
    /// </summary>
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
