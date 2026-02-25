namespace WLVSToolsV2.Web.Infrastructure.Services
{
    public class PromptLoader
    {
        private readonly IWebHostEnvironment _env;

        public PromptLoader(IWebHostEnvironment env)
        {
            _env = env;
        }

        public string LoadPrompt(string name, string folderPath)
        {
            var basePath = Path.Combine(_env.WebRootPath, "prompts");

            // 1. Check Development first
            if (_env.IsDevelopment())
            {
                var devFile = Path.Combine(basePath, folderPath, $"{name}.Development.md");
                if (File.Exists(devFile))
                    return File.ReadAllText(devFile);
            }

            // 2. Check environment-specific file (Staging, Production, etc.)
            var envFile = Path.Combine(basePath, folderPath, $"{name}.{_env.EnvironmentName}.md");
            if (File.Exists(envFile))
                return File.ReadAllText(envFile);

            // 3. Fallback to default
            var defaultFile = Path.Combine(basePath, folderPath, $"{name}.md");
            return File.ReadAllText(defaultFile);
        }
    }

}
