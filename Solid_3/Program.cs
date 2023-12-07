/*
 * В даному випадку порушено принцип підстановки Лісков.
 * Ми не очікуєм зміну поведінки прямокутника при її реалізації як квадрата.
 * Можна ігнорувати властивість Height для квадрата.
 */

using System;

class Rectangle
{
    public virtual int Width { get; set; }
    public int Height { get; set; }
    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

class Square : Rectangle
{
    public new int GetRectangleArea()
    {
        return Width * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Square();
        rect.Width = 5;
        rect.Height = 10;

        Square squa = new Square();
        squa.Width = 5;
        squa.Height = 10; //Ignored


        Console.WriteLine(rect.GetRectangleArea());
        Console.WriteLine(squa.GetRectangleArea());

        Console.ReadKey();
    }
}
