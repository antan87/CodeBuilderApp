using CodeBuilderApp.Document.Elements;
using System.Collections.Generic;

namespace CodeBuilderApp.Document.Interfaces
{
    public interface IClass
    {
        IEnumerable<IAttribute> Attributes { get; }
        string ModifierDeclaration { get; }
        string Name { get; }
        IEnumerable<PropertyElement> Properties { get; }
    }
}