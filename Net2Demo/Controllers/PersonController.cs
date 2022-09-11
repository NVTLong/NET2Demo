using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Net2Demo.Models;

namespace Net2Demo.Controllers;
public class PersonController : Controller
{
    public IActionResult Index(){
        List<Person> psList = new List<Person>()
        {
            new Person {PersonID = 1, PersonName = "Nguyễn Văn A", PersonAge = 18},
            new Person {PersonID = 2, PersonName = "Nguyễn Văn B", PersonAge = 18},
            new Person {PersonID = 3, PersonName = "Nguyễn Văn C", PersonAge = 18},
            new Person {PersonID = 4, PersonName = "Nguyễn Văn D", PersonAge = 18},
            new Person {PersonID = 5, PersonName = "Nguyễn Văn E", PersonAge = 18},
            new Person {PersonID = 6, PersonName = "Nguyễn Văn F", PersonAge = 18}
        };
        ViewData["Persons"] = psList;
        return View();
    }
}