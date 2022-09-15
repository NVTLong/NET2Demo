using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Net2Demo.Models;

namespace Net2Demo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(float a, float b)
    {
        if(a == 0){
            if(b == 0 ){
                ViewBag.Result = ("Phương trình này có vố số nghiệm!!!");
            }else{
                ViewBag.Result =("Phương trình này vô nghiệm!!!");
            }
        }else{
            ViewBag.Result = ("Phương trình này có nghiệm x =" + (-b/a));
        }
        return View("Index");
    }

    [HttpGet]
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Privacy(float a, float b, float c)
    {
        if(a == 0){
            if( b == 0){
                if(c == 0){
                    ViewBag.Result = ("Phương trình này vô số nghiệm");
                }else{
                    ViewBag.Result = ("Phương trình này vô nghiệm");
                }
            }else{
                ViewBag.Result = ("Phương trình này có một nghiệm duy nhất là x =" + (-c/b));
            }
        }else{
            float delta = b * b - 4 * a * c;
            if(delta < 0){
                ViewBag.Result = ("Phương trình này vô nghiệm");
            }else if(delta == 0){
                ViewBag.Result = ("Phương trình này có nghiệm kép x1 = x2 =" + (-b / (2 * a)));
            }else{
                double x1 = (-b + Math.Sqrt(delta) / (2 * a));
                double x2 = (-b - Math.Sqrt(delta) / (2 * a));
                ViewBag.Result = ("Phương trình này có 2 nghiệm phân biệt x1 =" + x1 +"x2 =" + x2);
            }             
        } 
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
