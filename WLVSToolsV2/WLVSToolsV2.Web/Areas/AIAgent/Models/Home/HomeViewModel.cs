using System.ComponentModel.DataAnnotations;
using WLVSToolsV2.Web.Common.Models.Menus;

namespace WLVSToolsV2.Web.Areas.AIAgent.Models.Home
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            MenuItems = new List<MenuItem>()
            {
                new MenuItem("Generate Personal Info", "~/AIAgent/Generate/PersonalInfo"),
                new MenuItem("Generate Personal Info and Register", "~/AIAgent/Generate/PersonalInfoAndRegister")
            };

            MenuItems = MenuItems.OrderBy(item => item.Title).ToList();
        }

        [UIHint("TilesMenu")]
        public IList<MenuItem>? MenuItems { get; private set; }
    }
}
