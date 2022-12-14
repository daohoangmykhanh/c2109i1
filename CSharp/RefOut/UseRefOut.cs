using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut;
internal class UseRefOut
{
    public void ShowInfo() => Console.WriteLine(" Thông tin về class này");
    public static void ChangeNumber (ref int a,ref int b)
    {
        int tam = a;
        a = b;
        b = tam;
        Console.WriteLine($"Change number: {nameof(a)} = {a}, {nameof(b)} = {b}");
    }
}
