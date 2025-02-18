// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;

var square = new Square(10);

try
{


    square.SetArea(2);


    Console.WriteLine("The area of square is " + square.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}




var circle = new Circle(12);

ShapeColourHelper.AddColour(circle);

try
{


    circle.SetArea(2);


    Console.WriteLine("The area of circle is " + circle.GetArea());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}






ShapeColourHelper.AddColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.ChangeColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.MakeRandomColour(square);

Console.WriteLine(square.Colour);


Console.ReadLine();




