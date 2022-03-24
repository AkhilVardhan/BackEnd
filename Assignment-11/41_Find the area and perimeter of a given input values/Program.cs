/*41) WAP to find the Area, permiter for the below shapes
    input : TypeOfShape ( you should accept either C or R or S)
             Length/Radius , width
    Note: if user chooses then system should take input for  width 
    Output : The Area for the Circle is : 
	     The Perimeter for Circle is :
             The Area for the rectangle is :
             The Perimeter for the Rectangle is :
	     The Area for the the Square is :
             The Perimeter for the Square is :
*/
using System;

namespace _41_Find_the_area_and_perimeter_of_a_given_input_values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Enter Radius: ");
            double Radious = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * Radious * Radious;
            double r, per_cir;
            double PI = 3.14;
            Console.WriteLine("Enter the radius of the circle : ");
            r = Convert.ToDouble(Console.ReadLine());
            per_cir = 2 * PI * r;
            Console.WriteLine("Area of circle: " + Area);
            Console.WriteLine("Perimeter of Circle : {0}", per_cir);
            Console.ReadLine();
            int l, w, area, perimeter;
            Console.Write("Length : ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Width : ");
            w = Convert.ToInt32(Console.ReadLine());
            area = l * w;
            perimeter = 2 * (l + w);
            Console.WriteLine("Area of Rectangle : " + area);
            Console.WriteLine("Perimeter of Rectangle : " + perimeter);
            Console.ReadKey();
            decimal side;
            Console.WriteLine("Enter the Length of Side: ");
            side = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Enter the value of side : ");
            //perimeter = (int)Convert.ToDecimal(Console.ReadLine());
            area = (int)(side * side);
            perimeter = (int)(4 * side);
            Console.WriteLine("Area of Square: " + area);
            Console.Write("Perimeter of Square is : " + perimeter);
            Console.ReadLine();
        }
    }
}