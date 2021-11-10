using System;

namespace AbstractClass
{
    public abstract class Shape
    {
        public string Color{get;set;}
        public int Thickness{get;set;}
        public abstract void Draw();
    }
    public class Line:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draws Line");
        }
    }
    public class Rectangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draws Rectangle");
        }
    }
    class Program
    {
        static void Main()
        {
            Shape shape1=new Line{Color="red",Thickness=1};
            Shape shape2=new Rectangle {Color="red",Thickness=2};
            shape1.Draw();
            shape2.Draw();
            Console.WriteLine(shape1);
        }
    }
}
