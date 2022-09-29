using System.Globalization;

namespace Net2Demo.Models.Process;
public class StringProcess
{
    private static readonly string[] VietnameseSigns = new string[]
    {
      "aAeEoOuUiIdDyY",
      "áàạảãâấầậẩẫăắằặẳẵ",
      "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
      "éèẹẻẽêếềệểễ",
      "ÉÈẸẺẼÊẾỀỆỂỄ",
      "óòọỏõôốồộổỗơớờợởỡ",
      "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
      "úùụủũưứừựửữ",
      "ÚÙỤỦŨƯỨỪỰỬỮ",
      "íìịỉĩ",
      "ÍÌỊỈĨ",
      "đ",
      "Đ",
      "ýỳỵỷỹ",
      "ÝỲỴỶỸ"
    };
    public string RemoveRemainingWhiteSpace(string strInput)
    {
        
        string strResult= " ";
        //Xóa bỏ khoảng trắng đầu, cuối của chuỗi
        strInput = strInput.Trim();
        // Xóa bỏ khoảng trắng còn thừa trong chuỗi
        while(strInput.IndexOf("   ")>0)
            {
                strInput = strInput.Replace("  ", " ");
            }
            strResult = strInput;
            return strResult;
    }
    public string LowerToUpper(string strInput)
    {
        string strResult = "";
        strResult = strInput.ToUpper();
        return strResult;
    }

    public string UpperToLower(string strInput)
    {
        string strResult = "";
        strResult = strInput.ToLower();
        return strResult;
    }

    public string CapitalizeOneFirstCharacter(string strInput)
    {
        string strResult = "";
        strResult = strInput.Substring(0, 1).ToUpper() + strInput.Substring(1);
        return strResult;
    }

    public string CapitalizeFirstCharacter(string strInput)
    {
        string strResult = "";
        strResult = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(strInput);
        return strResult;
    }

    public string RemoveVietnameseAccents(string strInput)
    {
        string strResult = "";
        for (int i = 1; i < VietnameseSigns.Length; i++)
            {
            for (int j = 0; j < VietnameseSigns[i].Length; j++)
            strInput = strInput.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
        strResult = strInput;
        return strResult;
    }
}