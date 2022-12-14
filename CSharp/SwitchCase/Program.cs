Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding= Encoding.UTF8;

int number1 = Random.Shared.Next(0,9);
int number2 = Random.Shared.Next(0,9);
Console.WriteLine($"{nameof(number1)} = {number1}");
Console.WriteLine($"{nameof(number2)} = {number2}");
Console.WriteLine("Vui long nhap dau");
var phepToan = Console.ReadLine();
switch (phepToan)
{
    case "+":
        Console.WriteLine(number1+ number2);
        break;
    case "-":
        Console.WriteLine(number1- number2);
        break;
    case "*":
        Console.WriteLine(number1 * number2);
        break;
    case "/":
        Console.WriteLine(number1 / number2);
        break;
    default: 
        Console.WriteLine("hi, i cant");
        break;
}

Console.WriteLine(
    phepToan switch
    {
        "+" when number1 > 0 && number2 > 0 => number1 + number2,
        "-" when number1 >= number2 => number1 - number2,
        "*" => number1*number2,
        "/" when number2 != 0 => number1/number2,
        _ => "hi, i cant..."
    }
);
