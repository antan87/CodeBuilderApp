using System.Collections.Generic;

namespace CodeBuilderApp.Document.Interfaces
{
    public interface IDocument
    {
        public IEnumerable<IUsing> Usings { get; }
        public INamespace Namespace { get; }
        public IEnumerable<IClass> Classes { get; }
    }
}