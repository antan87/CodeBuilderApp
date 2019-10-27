using System.Collections.Generic;

namespace CodeBuilderApp.Document.Interfaces
{
    public interface IProperty
    {
        public IEnumerable<AttributeElement> Attributes { get; }
        public bool GetAccessor { get; }
        public string ModifierDeclaration { get; }
        public string Name { get; }
        public bool SetAccessor { get; }
        public string Type { get; }
    }
}