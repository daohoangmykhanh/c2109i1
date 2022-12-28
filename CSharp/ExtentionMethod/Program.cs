
using ExtentionMethod;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Vui lòng nhập 1 số:");

int i = int.TryParse(Console.ReadLine(), out var result)?result:0;

int abc = 100;
abc.IsGeaterThan(10);
