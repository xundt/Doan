using ForKids.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;
using System.Security.Permissions;

namespace Harmic.ViewComponents
    
{
    
    public class MenuTopViewComponent : ViewComponent
    {
        private readonly BabyCareContext _context;

        public MenuTopViewComponent(BabyCareContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbMenus.Where(m => (bool)m.IsActive).
                OrderBy(m => m.Position).ToList();
            return await Task.FromResult<IViewComponentResult>(View(items));
        }
    }
}