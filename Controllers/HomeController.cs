using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Survey_with_Validations.Models;
//controller calls the model

namespace Survey_with_Validations.Controllers;
// Have Namespace match folder name to not confuse with class name

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public static List<Survey> SurveyList = new();
    //

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("survey/create")]
    public IActionResult CreateSurvey(Survey s)
    {
    if (ModelState.IsValid)
    {
        Console.WriteLine($"{s.Name}-{s.Location}-{s.Language}-{s.Comment}");
        return RedirectToAction("ResultView", s);
    }
    return View("Index");
    }

    [HttpGet("results")]
    public ViewResult ResultView(Survey s)
    {
        return View(s);
    }

    [HttpGet("privacy")]
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
