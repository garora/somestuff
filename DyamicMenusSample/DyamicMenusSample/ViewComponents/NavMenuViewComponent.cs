using DyamicMenusSample.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DyamicMenusSample.ViewComponents
{
    /// <summary>
    /// ViewComponent is under NavMenu folder
    /// </summary>
    public class NavMenuViewComponent : ViewComponent
    {
        private readonly IMenuService _menuService;
        public NavMenuViewComponent(IMenuService menuService) => _menuService = menuService;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await Task.Run(() => _menuService.BuildMenus());

            return View("index", items);
        }


    }
}
