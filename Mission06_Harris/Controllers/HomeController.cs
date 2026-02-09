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

}