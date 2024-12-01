using ForKids.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForKids.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TbProgramController : Controller
    {
        private readonly BabyCareContext _content;
        public TbProgramController(BabyCareContext content)
        {
            _content = content;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddNewProgram ang) 
        {
            var item = new TbProgram 
            {
                Programsname = ang.Programsname,
                AgeGroup = ang.AgeGroup,
                Descriptions = ang.Descriptions,
                Duration = ang.Duration,
                Prince = ang.Prince,
            };
            await _content.AddAsync(item);
            await _content.SaveChangesAsync();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var item = await _content.TbPrograms.ToListAsync();
            return View(item);
        }
    }
}
