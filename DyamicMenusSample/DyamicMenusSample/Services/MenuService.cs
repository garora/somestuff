using DyamicMenusSample.Models;
using System.Collections.Generic;

namespace DyamicMenusSample.Services
{
    /// <summary>
    /// This is a sample class
    /// for demo purposes only
    /// you should follow approach to interact with db
    /// for dynamic navigation menus
    /// </summary>
    public class MenuService : IMenuService
    {
        public List<DynMenu> BuildMenus()
        {
            var menus = new List<DynMenu>
            {
                new DynMenu
                {
                    Id = 1,
                Name = "Home",
                ActionName = "Index",
                ControllerName = "Home"
                },
                new DynMenu
                {
                    Id = 2,
                Name = "Privacy",
                ActionName = "Privacy",
                ControllerName = "Home"
                },
                new DynMenu
                {
                    Id = 3,
                Name = "About",
                ActionName = "About",
                ControllerName = "Home"
                }

            };
            return menus;
        }
    }
}
