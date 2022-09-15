namespace Net2Demo.Models;
public class GiaiPhuongTrinhBac2
{
    public string GiaiPTBac2(string hesoA, string hesoB, string hesoC)
    {
        double a, b, c, x, x1, x2;
        string ThongBaoKetQua;
        a = Convert.ToDouble(hesoA);
        b = Convert.ToDouble(hesoB); 
        c = Convert.ToDouble(hesoC);     
        if(a == 0)
        {
            if(b == 0)
            {
                if(c == 0)
                {
                    ThongBaoKetQua = "Phương trình này có vô số nghiệm";
                }
                else
                {
                    ThongBaoKetQua = "Phương trình này vô nghiệm";
                }
            }
            else
            {
                x = -c / b;
                ThongBaoKetQua = "Phương trình này có nghiệm x = " + x; 
            }
        }
        else 
        {
            double delta = b * b - 4 * a * c;
            if(delta < 0)
            {
                ThongBaoKetQua = "Phương trình này vô nghiệm";
            }
            else if(delta == 0)
            {   
                x = -b/2/a;
                ThongBaoKetQua = "Phương trình này có nghiệm kép x1 = x2 = " + x;
            }
            else
            {
                x1 = Math.Round((-b - Math.Sqrt(delta)) / 2 / a, 2);
                x2 = Math.Round((-b + Math.Sqrt(delta)) / 2 / a, 2);
                ThongBaoKetQua = "Phương trình này có 2 nghiệm phân biệt x1 = " + x1 +" x2 = " + x2;
            }
        }
        return ThongBaoKetQua;
    }
}