using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using CodeAgentsTeam3.Models;
using System;

namespace CodeAgentsTeam3.Controllers
{
    public class FindTalentsController : Controller
    {
        private ApplicationDbContext _context;

        public FindTalentsController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: FindTalents
        public IActionResult Index(string sortOrder, string searchString)
        {
            ViewBag.LastNameSortParm = String.IsNullOrEmpty(sortOrder) ? "lastname" : "";
            ViewBag.FirstNameSortParm = String.IsNullOrEmpty(sortOrder) ? "firstname" : "";
            ViewBag.ExperienceSortParm = String.IsNullOrEmpty(sortOrder) ? "experience" : "";
            ViewBag.RatingSortParm = String.IsNullOrEmpty(sortOrder) ? "rating" : "";
            var talentHunt = from s in _context.FindTalents.ToList()
                         select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                talentHunt = talentHunt.Where(s => s.LastName.Contains(searchString)
                                       || s.FirstName.Contains(searchString) || s.Profession.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "firstname":
                    talentHunt = talentHunt.OrderByDescending(s => s.FirstName);
                    break;
                case "lastname":
                    talentHunt = talentHunt.OrderBy(s => s.LastName);
                    break;
                case "experience":
                    talentHunt = talentHunt.OrderBy(s => s.Experience);
                    break;
                case "rating":
                    talentHunt = talentHunt.OrderBy(s => s.Rating);
                    break;
                default:
                    talentHunt = talentHunt.OrderBy(s => s.FirstName);
                    break;
            }
            return View(talentHunt.ToList());
        }

        // GET: FindTalents/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            FindTalent findTalent = _context.FindTalents.Single(m => m.FindTalentID == id);
            if (findTalent == null)
            {
                return HttpNotFound();
            }

            return View(findTalent);
        }

        // GET: FindTalents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FindTalents/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FindTalent findTalent)
        {
            if (ModelState.IsValid)
            {
                _context.FindTalents.Add(findTalent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(findTalent);
        }

        // GET: FindTalents/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            FindTalent findTalent = _context.FindTalents.Single(m => m.FindTalentID == id);
            if (findTalent == null)
            {
                return HttpNotFound();
            }
            return View(findTalent);
        }

        // POST: FindTalents/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FindTalent findTalent)
        {
            if (ModelState.IsValid)
            {
                _context.Update(findTalent);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(findTalent);
        }

        // GET: FindTalents/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            FindTalent findTalent = _context.FindTalents.Single(m => m.FindTalentID == id);
            if (findTalent == null)
            {
                return HttpNotFound();
            }

            return View(findTalent);
        }

        // POST: FindTalents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            FindTalent findTalent = _context.FindTalents.Single(m => m.FindTalentID == id);
            _context.FindTalents.Remove(findTalent);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
