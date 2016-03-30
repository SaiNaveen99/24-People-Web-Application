using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using CodeAgentsTeam3.Models;

namespace CodeAgentsTeam3.Controllers
{
    public class ProfilesController : Controller
    {
        private ApplicationDbContext _context;

        public ProfilesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Profiles
        public IActionResult Index()
        {
            return View(_context.profiles.ToList());
        }

        // GET: Profiles/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Profile profile = _context.profiles.Single(m => m.ProfileID == id);
            if (profile == null)
            {
                return HttpNotFound();
            }

            return View(profile);
        }

        // GET: Profiles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Profiles/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Profile profile)
        {
            if (ModelState.IsValid)
            {
                _context.profiles.Add(profile);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profile);
        }

        // GET: Profiles/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Profile profile = _context.profiles.Single(m => m.ProfileID == id);
            if (profile == null)
            {
                return HttpNotFound();
            }
            return View(profile);
        }

        // POST: Profiles/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Profile profile)
        {
            if (ModelState.IsValid)
            {
                _context.Update(profile);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(profile);
        }

        // GET: Profiles/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Profile profile = _context.profiles.Single(m => m.ProfileID == id);
            if (profile == null)
            {
                return HttpNotFound();
            }

            return View(profile);
        }

        // POST: Profiles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Profile profile = _context.profiles.Single(m => m.ProfileID == id);
            _context.profiles.Remove(profile);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
