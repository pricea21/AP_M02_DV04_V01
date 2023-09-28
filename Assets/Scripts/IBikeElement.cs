using static Unity.VisualScripting.Antlr3.Runtime.Tree.TreeWizard;

namespace Pattern.Visitor
{
    public interface IBikeElement
    {
        void Accept(IVisitor visitor);
    }
}
