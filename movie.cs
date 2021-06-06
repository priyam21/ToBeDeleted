using System;

namespace movie 
{
    class Program{

static void Main(string[] args)
{ 

          Console.WriteLine("Please enter the movie information"); 
          Console.WriteLine("For X movie name director_name:cast,cast");

          string info= Console.ReadLine(); 
          string[] arr= info.Split(":");

          string[] cast =arr[2].Split(",");

          Console.WriteLine($"Movie name is : {arr[0]}"); 
          Console.WriteLine($" director name Is {arr[1]}");

         foreach (var item in cast){

              Console.WriteLine($" cast name is: {item}");
         }

}
}
}