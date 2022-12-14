// format code ctrl + k + d
double a = 0.1;
double b = 0.2;
Console.WriteLine(a + b == 0.3 ? "true" : "false");

decimal c = 0.1M;
decimal d = 0.2M;
Console.WriteLine(c + d == 0.3M ? "true" : "false");

// ? : ternary operator
string? fullname = null;

// null
Nullable<int> i = null;
bool? check = null;

//int length = fullname is not null ? fullname.Length : 0;

// null-conditional operator ?
// tuong tu != , fullname ma khac null thi tra ve ve sau

int? length = fullname?.Length;

// null-coalescing operating ?? 
// tuong tu nhu dau ==, fullname bang null thi tra ve ve sau
int? chieudai = fullname?.Length ?? 0;