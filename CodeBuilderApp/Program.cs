using CodeBuilderApp.Workspace.Factory;
using CodeBuilderApp.Workspace.Handler;
using System.Threading.Tasks;

namespace CodeBuilderApp
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var factory = new MSBuildWorkspaceFactory();
            var workspace = await factory.GetWorkspace(@"C:\Users\Antan87\source\repos\C#\Test\TestApp\TestApp.sln");
            var handler = new MSBuildWorkspaceHandler(workspace);
        }
    }
}