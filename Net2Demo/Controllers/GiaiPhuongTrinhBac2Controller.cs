using Microsoft.AspNetCore.Mvc;
using Net2Demo.Models;

namespace Net2Demo.Controllers;
public class GiaiPhuongTrinhBac2Controller : Controller
{   
    GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();
    public IActionResult GiaiPhuongTrinhBac2(){
        return View();
    }
    [HttpPost]
    public IActionResult GiaiPhuongTrinhBac2(string hesoA, string hesoB, string hesoC){
        string KetQua = gpt.GiaiPTBac2(hesoA,hesoB, hesoC);
        ViewBag.ThongBaoKetQua = KetQua;
        return View();
    }
}