using ForKids.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForKids.Areas.Admin.Controllers
{
    [Area ("Admin")]
    public class TbFaqController : Controller
    {
        private readonly BabyCareContext _context;
        public TbFaqController(BabyCareContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddNewFaq faq)
        {
            var item = new TbFAQ
            {
                Question = faq.Question,
                Answer = faq.Answer,
                Descriptions = faq.Descriptions,
            };
            await _context.AddAsync(item);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
