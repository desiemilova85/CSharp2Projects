using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CalculatesTriangleSurface
{
    /*Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

    private static void SurfaceBySideHeight()
    {
        Console.WriteLine("Calculates triangle surface by given 1 side and height");
        Console.WriteLine("Enter side:");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height:");
        double height = double.Parse(Console.ReadLine());
        double surface=side * height / 2;
        Console.WriteLine("Triangle Surface is = {0}",surface );
    }
 
    private static void SurfaceByThreeSides()
    {
        Console.WriteLine("Calculates triangle surface by given 3 sides");
        Console.WriteLine("Enter side A:");
        double one = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B:");
        double two = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side C:");
        double three = double.Parse(Console.ReadLine());
        double halfSurface = (one + two + three) / 2;
        double surface=Math.Sqrt(halfSurface*(halfSurface-one)*(halfSurface-two)*(halfSurface-three));
        Console.WriteLine("Triangle Surface is = {0}", surface);
    }
 
    private static void SurfaceByTwoSidesAngle()
    {
        Console.WriteLine("Calculates triangle surface by given 2 sides and angle");
        Console.WriteLine("Enter side A:");
        double one = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B:");
        double two = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter angle:");
        double angle = double.Parse(Console.ReadLine());
        double surface= one * two * Math.Sin(Math.PI*angle/180) / 2;
        Console.WriteLine("Triangle Surface is = {0}",surface);
    }
    static void Main()
    {
        Console.WriteLine("Please enter number from 1 to 3 so that correct method of triangle surface to be generated:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: SurfaceBySideHeight();
                break;
            case 2: SurfaceByThreeSides();
                break;
            case 3: SurfaceByTwoSidesAngle();
                break;
            default: Console.WriteLine("Invalid Number entered. Please enter choices from 1 to 3!");
                break;
        }
    }
}
