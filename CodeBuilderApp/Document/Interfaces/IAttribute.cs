using System.Collections.Generic;

namespace CodeBuilderApp.Document.Interfaces
{
    public interface IAttribute
    {
        IEnumerable<string> Arguments { get; }
        string Name { get; }
    }
}