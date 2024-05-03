// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// string length
Console.WriteLine("Enter String ");
string str = Console.ReadLine();
int strlg = str.Length;
Console.WriteLine("length is :" + strlg);


//Concatenation
Console.WriteLine("First String");
string c = Console.ReadLine();
Console.WriteLine("Second String");
string d = Console.ReadLine();
Console.WriteLine(c + d);


//interpolation
Console.WriteLine(string.Concat(c, d));
string f = $"{c} {d}";
Console.WriteLine(f);
Console.WriteLine(c[0]);//Access String
Console.WriteLine(c.IndexOf("e"));//indexof
Console.WriteLine(f.LastIndexOf("g")); //last index of string
Console.WriteLine(string.Compare(c, d)); //string compare
Console.WriteLine(string.Equals(c, d));//string Equal
Console.WriteLine(f.Replace(c, d));//string Replace
Console.WriteLine(f.Contains("shahzad")); //string contains
Console.WriteLine("enter text");
string e = Console.ReadLine();
Console.WriteLine(e.ToUpper());//To Upper
Console.WriteLine(e.ToLower());// To Lower

