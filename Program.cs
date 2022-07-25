// See https://aka.ms/new-console-template for more information
using System.Numerics;




var coords = new List<Complex>() { };

var c = 2;
var range = Enumerable.Range(0, 100);
var previousZval = 0;


foreach(var num in range)
{
    var z = Math.Sqrt(num) + c;
    if(previousZval > 0)
        coords.Add(z);
    Console.WriteLine(z);



}

Console.ReadKey();