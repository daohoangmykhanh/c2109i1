using RefOut;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

int a = 10;
int b = 5;

UseRefOut.ChangeNumber(ref a, ref b);
Console.WriteLine($"Program number: {nameof(a)} = {a}, {nameof(b)} = {b}");
