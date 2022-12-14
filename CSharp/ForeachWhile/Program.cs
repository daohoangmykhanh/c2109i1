using System.Text;
using System.Collections;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

string[] arrs = {"nguyên", "phú","hùng","hoàng", "thảo", "lợi", "trung" };
//foreach ( var i in arrs)
//{
//    Console.WriteLine($"{ i} co chieu dai {i.Length}");

//}

IEnumerator e = arrs.GetEnumerator();
while ( e.MoveNext())
{
    string s = (string)e.Current;
    Console.WriteLine($"{s} có chiều dài {s.Length}");
}
