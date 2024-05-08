// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Variable in C#

// 1) Decleration 2) initialization 


//string myFriendName;

//myFriendName = "Mark";

//myFriendName = null;

//Console.WriteLine(myFriendName);


//Console.WriteLine("enter your friend name");

//string myFriendName = Console.ReadLine();


//Console.WriteLine("enter friend location");

//string country = Console.ReadLine(); 

//myFriendName = "Mark";


//String concatination 

//Console.WriteLine("My Frind name is " + myFriendName );
//Console.WriteLine("He is from USA");
//Console.WriteLine("He is software engineering"); 
//Console.WriteLine("He is 34 years old");



//String interpolation 
//Console.WriteLine( $@"My Frind name is {myFriendName}");
//Console.WriteLine($@"He is from {country}");
//Console.WriteLine("He is software engineering");
//Console.WriteLine("He is 34 years old");


//int MatriculationMarks;


Console.WriteLine($"min value of int is {int.MinValue} , max value of in is {int.MaxValue}");

int gpa = 2147483647;

int gpa2 = 2147483647;


var result = gpa.CompareTo( gpa2 );

Console.WriteLine(result);

double Longgpa = 2147483648;

Console.WriteLine($"min value of int is {double.MinValue} , max value of in is {double.MaxValue}");


decimal ProductPrice = 30.555555503333333M;


float ProductPrice2 = 40.55F;


//Small Money  => decimal 
//Big Int => double , long 

long ProductPrice3 = 232323;



//int StudentMatricuationMark = 0;

//Console.WriteLine("enter your matriculation marks");
//StudentMatricuationMark = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"Student Matriculation marks is {StudentMatricuationMark}");



int abc = 2147483647;
double xyz = abc;
xyz = 2147483648;

abc = (int)xyz;

Console.WriteLine(abc);


Guid personId = Guid.NewGuid(); // Unique identifire 

Console.WriteLine($"person id is {personId}");






