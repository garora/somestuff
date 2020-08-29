using DyamicMenusSample.Models;
using System.Collections.Generic;

namespace DyamicMenusSample.Services
{
    public interface IMenuService
    {
        List<DynMenu> BuildMenus();
    }
}
