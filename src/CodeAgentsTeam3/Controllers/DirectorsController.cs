using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using CodeAgentsTeam3.Models;
using System;

namespace CodeAgentsTeam3.Controllers
{
    public class DirectorsController : Controller
    {
        private ApplicationDbContext _context;

        public DirectorsController(ApplicationDbContext context)
        {
            _context = context;    
        }

      // Index Page - Sorted
        public IActionResult Index(string sortOrder)
        {
            ViewBag.LastNameSortParm = String.IsNullOrEmpty(sortOrder) ? "lastname" : "";
            ViewBag.FirstNameSortParm = String.IsNullOrEmpty(sortOrder) ? "firstname" : "";
            ViewBag.ExperienceSortParm = String.IsNullOrEmpty(sortOrder) ? "experience" : "";
            var directors = from s in _context.Director.ToList()
                         select s;
            switch (sortOrder)
            {
                case "firstname":
                    directors = directors.OrderByDescending(s => s.FirstName);
                    break;
                case "lastname":
                    directors = directors.OrderBy(s => s.LastName);
                    break;
                case "experience":
                    directors = directors.OrderBy(s => s.Experience);
                    break;
                default:
                    directors = directors.OrderBy(s => s.FirstName);
                    break;
            }
            return View(directors.ToList());
        }

        // GET: Directors/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Director director = _context.Director.Single(m => m.DirectorID == id);
            if (director == null)
            {
                return HttpNotFound();
            }

            return View(director);
        }

        // GET: Directors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Directors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Director director)
        {
            if (ModelState.IsValid)
            {
                _context.Director.Add(director);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(director);
        }

        // GET: Directors/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Director director = _context.Director.Single(m => m.DirectorID == id);
            if (director == null)
            {
                return HttpNotFound();
            }
            return View(director);
        }

        // POST: Directors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Director director)
        {
            if (ModelState.IsValid)
            {
                _context.Update(director);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(director);
        }

        // GET: Directors/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Director director = _context.Director.Single(m => m.DirectorID == id);
            if (director == null)
            {
                return HttpNotFound();
            }

            return View(director);
        }

        // POST: Directors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Director director = _context.Director.Single(m => m.DirectorID == id);
            _context.Director.Remove(director);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
