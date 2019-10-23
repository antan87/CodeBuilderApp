using CodeBuilderApp.Workspace.Interface;
using Microsoft.CodeAnalysis.MSBuild;

namespace CodeBuilderApp.Workspace.Handler
{
    public sealed class MSBuildWorkspaceHandler : IWorkspaceHandler<MSBuildWorkspace>
    {
        public MSBuildWorkspaceHandler(MSBuildWorkspace workspace)
        {
            this.Workspace = workspace;
        }

        public MSBuildWorkspace Workspace { get; }
    }
}