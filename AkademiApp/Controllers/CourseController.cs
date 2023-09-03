using AkademiApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AkademiApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }

        public IActionResult Apply()//Ekranı gösterme işlemi...
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//Modeli ekleme yapıp sonra bu işlemin gerçekleşmesini görmek amaclı home sayfasına gönderme işlemi yaptım...
        public IActionResult Apply([FromForm] Candidate model)
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("", "There is already an applications for you.");
            }
            if (ModelState.IsValid)
            {
                Repository.Add(model);
                return View("Feedback", model);
            }
            return View();

        }
    }
}

