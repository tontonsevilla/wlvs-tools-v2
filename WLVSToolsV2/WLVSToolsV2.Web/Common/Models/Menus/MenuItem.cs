namespace WLVSToolsV2.Web.Common.Models.Menus
{
    public class MenuItem
    {
        public MenuItem(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string? Title { get; private set; }
        public string? Url { get; private set; }
    }
}
