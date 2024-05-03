// See https://aka.ms/new-console-template for more information

//To Lower & Upper Case 
string upper = "This is Upper & Lower Case String";
Console.WriteLine(upper.ToUpper());
Console.WriteLine(upper.ToLower());

//Insert
string insrt = "This is insert method";
string inst = insrt.Insert(0, "Hello! ");
Console.WriteLine(inst);

// String length
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

//Interpolation
//Console.WriteLine(string.Concat(c, d));
string a = "This is", b = "Hellow";
string inter = $"First is : {a} and second is : {b}";
Console.WriteLine(inter);

//Access String
Console.WriteLine(inter[0]);
//indexof
Console.WriteLine(c.IndexOf("e"));
//last index of string
Console.WriteLine(inter.LastIndexOf("g"));
//string compare
Console.WriteLine(string.Compare(a, b));
//string Equal
Console.WriteLine(string.Equals(a, b));
//string Replace
Console.WriteLine(inter.Replace(a, "Why is This"));
//string contains
Console.WriteLine(inter.Contains("dotNet --version")); 
Console.WriteLine("Enter text");
string e = Console.ReadLine();