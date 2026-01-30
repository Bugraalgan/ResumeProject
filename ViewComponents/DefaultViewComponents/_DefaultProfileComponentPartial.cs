using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultProfileComponentPartial :ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultProfileComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Profiles.ToList();
            return View(values);
        }
    }
}
