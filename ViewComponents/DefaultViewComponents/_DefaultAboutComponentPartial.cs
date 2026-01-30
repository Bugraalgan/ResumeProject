using Microsoft.AspNetCore.Mvc;
using ResumeProjectDemoNight.Context;
using ResumeProjectDemoNight.Entities;

namespace ResumeProjectDemoNight.ViewComponents.DefaultViewComponents
{
    public class _DefaultAboutComponentPartial :ViewComponent
    {
        private readonly ResumeContext _context;

        public _DefaultAboutComponentPartial(ResumeContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.ToList();
            ViewBag.ReferenceCount = _context.Testimonials.Count();
            ViewBag.CompletedProjectCount= _context.Portfolios.Count();
            ViewBag.ExperienceYear = DateTime.Now.Year - 2023;
            ViewBag.TechnologyCount = _context.Skills.Count();

            return View(values);
                     
        }
    }
}
