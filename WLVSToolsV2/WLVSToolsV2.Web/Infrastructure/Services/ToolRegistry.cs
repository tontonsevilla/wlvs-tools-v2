using System.Text;

namespace WLVSToolsV2.Web.Infrastructure.Services
{
    public class ToolRegistry : IToolRegistry 
    { 
        public string Execute(string toolName, string args) 
        { 
            return toolName switch 
            { 
                "LIST_FILES" => ListFiles(args), 
                "READ_FILE" => ReadFile(args), 
                _ => $"Unknown tool: {toolName}" 
            }; 
        } 
        
        private string ListFiles(string path) 
        { 
            if (string.IsNullOrWhiteSpace(path)) 
                path = Directory.GetCurrentDirectory(); 
            
            if (!Directory.Exists(path)) 
                return $"Directory not found: {path}"; 
            
            var sb = new StringBuilder(); 
            sb.AppendLine($"Files in {path}:"); 
            
            foreach (var file in Directory.GetFiles(path)) 
                sb.AppendLine(Path.GetFileName(file)); 
            
            return sb.ToString(); 
        } 
        
        private string ReadFile(string path) 
        { 
            if (string.IsNullOrWhiteSpace(path)) 
                return "No file path provided."; 
            
            if (!File.Exists(path)) 
                return $"File not found: {path}"; 
            
            var content = File.ReadAllText(path); 
            
            if (content.Length > 2000) 
                content = content[..2000] + "\n...[truncated]"; 
            
            return $"Content of {path}:\n{content}"; 
        } 
    }
}
