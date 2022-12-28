using System.Collections;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
List<Student> List = new()
{
    new Student(){ RollNumber = 1, FullName = "Khắc Nguyên", Section = "Dãy số 1", HostelNumber = 1},
    new Student(){ RollNumber = 2, FullName = "Nguyên", Section = "Dãy số 1", HostelNumber = 1},
    new Student(){ RollNumber = 3, FullName = "Khắc", Section = "Dãy số 1", HostelNumber = 2},
    new Student(){ RollNumber = 4, FullName = "Khắc Tin", Section = "Dãy số 3", HostelNumber = 3},
    new Student(){ RollNumber = 5, FullName = "Vinh", Section = "Dãy số 3", HostelNumber = 3},
    new Student(){ RollNumber = 6, FullName = "Nguyên Hoa", Section = "Dãy số 2", HostelNumber = 4},
    new Student(){ RollNumber = 7, FullName = "Khắc Kim", Section = "Dãy số 2", HostelNumber = 4},
    new Student(){ RollNumber = 6, FullName = "Hoa", Section = "Dãy số 2", HostelNumber = 4},
    new Student(){ RollNumber = 7, FullName = "Kim", Section = "Dãy số 4", HostelNumber = 2},
    new Student(){ RollNumber = 6, FullName = "Thoa", Section = "Dãy số 1", HostelNumber = 3},
    new Student(){ RollNumber = 7, FullName = "Kim Hoa", Section = "Dãy số 1", HostelNumber = 3},
};
//Stopwatch  sw = new Stopwatch();
//sw.Restart();
//foreach(var stu in List)
//{
//    Console.WriteLine(stu);
//}
//Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
//sw.Restart();

////  Tất cả các dạng collection đều có mẫu để duyệt qua dữ liệu mà không dùng for hay foreach => ienumarator

//IEnumerator<Student> enu = List.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current);
//}

//Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
//sw.Restart();

//ling => language Intergrated query
//ling to sql
//ling to object
//ling to xml, json
//parallel linq => pling
// select from where group by having order
// from where group by having order => select

//ling to object có hai dạng 
// style 1: theo trường phái sql => query syntax, dễ học, dễ hiểu
// style 2: theo trường phái lamda => method syntax, khó học, khó hiểu

// liệt kê tất cả sinh viên với mã sinh viên lớn hơn 2 
foreach(var s in List)
{
    if(s.RollNumber > 2)
    {
        Console.WriteLine(s);
    }
}

//ling to object style1
var liststu = from stu in List where stu.RollNumber > 2 select stu;
Console.WriteLine(liststu.Count());
foreach (var st in liststu)
{
    Console.WriteLine(st);
}
//ling to object style2
var lists = List.Where(stu=>stu.RollNumber > 2);
foreach(var stu in lists)
{
    Console.WriteLine(stu);
}

// các phương thức sãn có trong list
List.ForEach(Console.WriteLine);
List.ForEach(stud => Console.WriteLine(stud));
List.ForEach(
    stu =>
        {
            if (stu.RollNumber > 2)
            {
                Console.WriteLine(stu);
            }
        });

// kết hợp lamda với phương thức có sẳn của list
List.Where(stu => stu.RollNumber > 2).ToList().ForEach(Console.WriteLine);

var r = from stu in List 
        where stu.RollNumber > 2 
        select new 
        { 
          StudentDetail = $"{stu.FullName} : {stu.RollNumber}", 
          StudentRoom =  $"{stu.Section} = {stu.HostelNumber}"
        };
r.ToList().ForEach(Console.WriteLine);

List.Select(stu => new
{
    StudentDetail = $"{stu.FullName} : {stu.RollNumber}",
    StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
}).ToList().ForEach(Console.WriteLine);

IEnumerator enu = List.GetEnumerator();
while (enu.MoveNext())
{

}

// lần đàu tiên thực thi trên server lưu lại bộ nhớ
// là vào bộ nhớ laoij bỏ chỉ lấy 2 dòng đầu tiên
IEnumerable<Student> i = from stu in List select stu;

// lần đầu tiên thực thi trên server lưu lại bộ nhớ
// sẽ chạy lên server lầu nữa 
IQueryable u = from stu in List.AsQueryable()
               select stu;

var obj1 = from stu in List
           orderby stu.Section descending, stu.HostelNumber ascending
           select stu;

var obj2 = List.OrderByDescending(stu => stu.Section).ThenBy(stu => stu.HostelNumber);