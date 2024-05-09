using DomainModels;
using Microsoft.VisualBasic;



//Course
//- Camel Case => durationInMonth
//- Pascal Case => DurationInMonth


Course DotNetCourse = new Course
{
    CourseId = Guid.NewGuid(),
    CreatedDate = DateTime.Now,
    Description = "XYZ",
    DurationInMonths = 4,
    Fee = 5000M,
    IsFeatured = true,
    LaunchDate = DateTime.Now.AddDays(10),
    Title = "DotNET"
};
//DotNetCourse.CourseId = Guid.NewGuid(); 
//DotNetCourse.CreatedDate = DateTime.Now;
//DotNetCourse.LaunchDate = DateTime.Now.AddDays(10);
//DotNetCourse.Description = "XYZ";
//DotNetCourse.Fee = 50000M;
//DotNetCourse.DurationInMonths = 4;
//DotNetCourse.IsFeatured = true;
//DotNetCourse.Title = "DOTNET";





for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"---------------------displaying for {i + 1} time -------------------------- ");

	Console.WriteLine($@"Cours id :{DotNetCourse.CourseId} , Title: {DotNetCourse.Title} , Course Duration: {DotNetCourse.DurationInMonths} Months,
               Description : {DotNetCourse.Description} , Launch Date :{DotNetCourse.LaunchDate}");
}


bool isTerminate = true;

while (isTerminate == false)
{
    Console.WriteLine($@"Cours id :{DotNetCourse.CourseId} , Title: {DotNetCourse.Title} , Course Duration: {DotNetCourse.DurationInMonths} Months, 
                Description : {DotNetCourse.Description} , Launch Date :{DotNetCourse.LaunchDate}");


    Console.WriteLine("do you want to continue??? enter y/n");

    isTerminate = Console.ReadLine() == "n" ? true : false;

    var input = Console.ReadLine();

    if (input == "n")
    {
        Console.WriteLine("program is terminating");
        isTerminate = true;
    }
    else
    {
        Console.WriteLine("you dont want terminate , program running");
    }
}


do
{
    Console.WriteLine($@"Cours id :{DotNetCourse.CourseId} , Title: {DotNetCourse.Title} , Course Duration: {DotNetCourse.DurationInMonths} Months, 
               Description : {DotNetCourse.Description} , Launch Date :{DotNetCourse.LaunchDate}");
} while (!isTerminate);
