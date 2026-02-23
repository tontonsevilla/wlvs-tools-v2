using WLVSToolsV2.Web.Common.Models.Menus;

namespace WLVSToolsV2.Web.Models.Home
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem("AI Assistant", "~/AIAssistant"),
                new MenuItem("AI Agent", "~/AIAgent")
            };

            MenuItems = MenuItems.OrderBy(item => item.Title).ToList();
        }

        public IList<MenuItem>? MenuItems { get; private set; }
    }
}
