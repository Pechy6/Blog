using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspBlog.Models;

namespace AspBlog.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Skills()
    {
        return View();   
    }

    public IActionResult References()
    {
        return View();  
    }
}