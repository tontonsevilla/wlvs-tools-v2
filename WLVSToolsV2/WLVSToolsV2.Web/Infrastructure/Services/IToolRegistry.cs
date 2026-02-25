namespace WLVSToolsV2.Web.Infrastructure.Services
{
    public interface IToolRegistry
    {
        string Execute(string toolName, string args);
    }
}
