using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Harris.Models;

namespace Mission06_Harris.Controllers;

public class HomeController : Controller
{
    private EnterMovieContext _context;
    
    public HomeController(EnterMovieContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetToKnowJoel()
    {
        return View();
    }
    public IActionResult EnterMovie()
    {
        return View();
    }
    [HttpPost]
    public IActionResult EnterMovie(MovieForm response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();
        
        return View("Confirmation", response);
    }
    
    public IActionResult MovieList()
    {
        var movies = _context.Movies.ToList();
        return View(movies);
    }
    
    // GET: Edit
    [HttpGet]
    public IActionResult Edit(int id)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
        return View(movie);
    }

// POST: Edit
    [HttpPost]
    public IActionResult Edit(MovieForm updatedMovie)
    {
        _context.Movies.Update(updatedMovie);
        _context.SaveChanges();

        return RedirectToAction("MovieList");
    }
    
    // GET: Delete
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var movie = _context.Movies.FirstOrDefault(m => m.MovieId == id);
        return View(movie);
    }

// POST: Delete
    [HttpPost]
    public IActionResult Delete(MovieForm movie)
    {
        _context.Movies.Remove(movie);
        _context.SaveChanges();

        return RedirectToAction("MovieList");
    }

}