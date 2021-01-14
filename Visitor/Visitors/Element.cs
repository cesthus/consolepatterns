namespace Visitor.Visitors
{
    /// <summary>
    /// The element class
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}