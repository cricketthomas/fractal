// See https://aka.ms/new-console-template for more information
using System.Numerics;


var size = 80 * 25;
var z = new Complex(0, 0);

/// linear line thing
//double line = 0;
//for (int y = 0; y < 25; y++)
//{
//    for (int x = 0; x < 80; x++)
//    {
//        if (x == Math.Round(line))
//        {
//            Console.Write("/");
//        }
//        else
//        {
//            Console.Write("x");
//        }
//        line += .04;
//    }

//    line += .0125;
//    Console.WriteLine();
//}

///80x20cube
//for (int y = 0; y < 25; y++)
//{
//    for (int x = 0; x < 80; x++)
//    {
//        Console.Write("x");
//    }
//    Console.WriteLine();
//}



void draw(Complex c)
{
    for (int i = 0; i < 80; i++)
    {
        z = z * z + c;

        if (z.Magnitude < .001)
        {
            Console.Write("X");
            return;
        }
    }
    Console.Write(" ");
}





for (int y = 0; y < 25; y++)
{
    draw(y);

    Console.WriteLine();
}