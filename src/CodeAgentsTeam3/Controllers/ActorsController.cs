using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using CodeAgentsTeam3.Models;
using System;

namespace CodeAgentsTeam3.Controllers
{
    public class ActorsController : Controller
    {
        private ApplicationDbContext _context;

        public ActorsController(ApplicationDbContext context)
        {
            _context = context;
        }

        //// GET: Actors
        //public IActionResult Index()
        //{
        //    return View(_context.Actor.ToList());
        //}


        //// GET: Actors Sorted
        public IActionResult Index(string sortOrder)
        {
            ViewBag.LastNameSortParm = String.IsNullOrEmpty(sortOrder) ? "lastname" : "";
            ViewBag.FirstNameSortParm = String.IsNullOrEmpty(sortOrder) ? "firstname" : "";
            ViewBag.ExperienceSortParm = String.IsNullOrEmpty(sortOrder) ? "experience" : "";
            ViewBag.RatingSortParm = String.IsNullOrEmpty(sortOrder) ? "rating" : "";
            var actors = from s in _context.Actor.ToList()
                         select s;
            switch (sortOrder)
            {
                case "firstname":
                    actors = actors.OrderByDescending(s => s.FirstName);
                    break;
                case "lastname":
                    actors = actors.OrderBy(s => s.LastName);
                    break;
                case "experience":
                    actors = actors.OrderBy(s => s.YearsOfExperience);
                    break;
                case "rating":
                    actors = actors.OrderBy(s => s.Rating);
                    break;
                default:
                    actors = actors.OrderBy(s => s.FirstName);
                    break;
            }
            return View(actors.ToList());
        }

        // GET: Actors/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Actor actor = _context.Actor.Single(m => m.ActorID == id);
            if (actor == null)
            {
                return HttpNotFound();
            }

            return View(actor);
        }

        // GET: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Actor actor)
        {
            if (ModelState.IsValid)
            {
                _context.Actor.Add(actor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actor);
        }

        // GET: Actors/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Actor actor = _context.Actor.Single(m => m.ActorID == id);
            if (actor == null)
            {
                return HttpNotFound();
            }
            return View(actor);
        }

        // POST: Actors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Actor actor)
        {
            if (ModelState.IsValid)
            {
                _context.Update(actor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actor);
        }

        // GET: Actors/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Actor actor = _context.Actor.Single(m => m.ActorID == id);
            if (actor == null)
            {
                return HttpNotFound();
            }

            return View(actor);
        }

        // POST: Actors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Actor actor = _context.Actor.Single(m => m.ActorID == id);
            _context.Actor.Remove(actor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
