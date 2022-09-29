using Microsoft.AspNetCore.Mvc;
using Net2Demo.Models;
using Net2Demo.Models.Process;

namespace Net2Demo.Controllers;
public class StringProcessController : Controller
{
    StringProcess strPro = new StringProcess();
    public IActionResult XuLyChuoi()
    {
        return View();
    }
    [HttpPost]
    public IActionResult XuLyChuoi(string strInput)
    {
        // ViewBag.ThongBao = strPro.RemoveRemainingWhiteSpace(strInput);
         ViewBag.ThongBao = strPro.LowerToUpper(strInput);
        // ViewBag.ThongBao = strPro.UpperToLower(strInput);
        // ViewBag.ThongBao = strPro.CapitalizeOneFirstCharacter(strInput);
        // ViewBag.ThongBao = strPro.CapitalizeFirstCharacter(strInput);
        // ViewBag.ThongBao = strPro.RemoveVietnameseAccents(strInput);
        return View();
    }
}

