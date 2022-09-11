using Microsoft.AspNetCore.Mvc;
using Net2Demo.Models;

namespace Net2Demo.Controllers;

public class EmployeeController : Controller 
{
    public IActionResult Index(Employee std){
       string message = std.EmployeeID + "-";
       message += std.EmployeeName + "-";
       message += std.EmployeePosition;
       ViewBag.ThongTin = message;
        return View();
    }

}
