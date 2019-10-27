using CodeBuilderApp.Document.Interfaces;
using System.Collections.Generic;

namespace CodeBuilderApp.Document.Elements
{
    public sealed class DocumentElement : IDocument
    {
        public DocumentElement(IEnumerable<IUsing> usings, INamespace @namespace, IEnumerable<IClass> classes)
        {
            this.Usings = usings;
            this.Namespace = @namespace;
            this.Classes = classes;
        }

        public DocumentElement(IEnumerable<IUsing> usings, INamespace @namespace, IClass @class)
        : this(usings, @namespace, new List<IClass> { @class })
        {
        }

        public IEnumerable<IClass> Classes { get; }
        public INamespace Namespace { get; }
        public IEnumerable<IUsing> Usings { get; }
    }
}