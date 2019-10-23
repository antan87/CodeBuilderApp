using System.Threading.Tasks;

namespace CodeBuilderApp.Workspace.Interface
{
    public interface IWorkspaceFactory<TWorkspace>
    where TWorkspace : Microsoft.CodeAnalysis.Workspace
    {
        Task<TWorkspace> GetWorkspace(string solutionPath);
    }
}