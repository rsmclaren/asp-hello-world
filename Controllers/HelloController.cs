using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers;

public class HelloController : Controller
{

    public IActionResult Index()
    {
        // first visit to app
        Hello hello = new Hello();

        Console.WriteLine("in Index Action method!");

        return View(hello);
    }

}

