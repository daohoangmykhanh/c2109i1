using System.Text.RegularExpressions;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

string? str = null;
Console.WriteLine("Vui lòng nhập số:");
str = Console.ReadLine();
var formula = new Regex("^[0-9]+$");

if (formula.IsMatch(str)){
    int result = Convert.ToInt32(str);
}

if(int.TryParse(str, out int i))
{
    Console.WriteLine($"i là số: {i}");
}

// dùng try catch
// mệnh đề "guard clause"
Console.WriteLine("Vui lòng nhập sô lượng:");
string? amount = Console.ReadLine();
if (string.IsNullOrEmpty(amount))
{
    return;
}

//if(amount != null)
//{
//    // lam gi do
//}

try
{
    int total = int.Parse(amount);
    if (total <= 0) throw new Exception("phải lớn hơn 0");
    Console.WriteLine($"{nameof(total)} = {total}");
}
catch (Exception) when (amount.Contains("$"))
{
    Console.WriteLine("chuỗi không được có dấu $");
}
catch ( Exception e)
{
    Console.WriteLine($"{e.GetType()}, {e.Message}");
}