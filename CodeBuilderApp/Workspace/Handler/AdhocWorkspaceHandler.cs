using CodeBuilderApp.Workspace.Interface;
using Microsoft.CodeAnalysis;

namespace CodeBuilderApp.Workspace.Handler
{
    public sealed class AdhocWorkspaceHandler : IWorkspaceHandler<AdhocWorkspace>
    {
        public AdhocWorkspaceHandler(AdhocWorkspace workspace)
        {
            this.Workspace = workspace;
        }

        public AdhocWorkspace Workspace { get; }
    }
}