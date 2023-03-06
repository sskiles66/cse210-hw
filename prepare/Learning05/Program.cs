using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("black", 5);

        //Console.WriteLine(sq.GetArea());

        //Console.WriteLine(sq.GetColor());
        

        Rectangle re = new Rectangle("yellow", 5, 10);

        //Console.WriteLine(re.GetArea());

        //Console.WriteLine(re.GetColor());


        Circle ci = new Circle("black", 12);

        //Console.WriteLine(ci.GetArea());

        //Console.WriteLine(ci.GetColor());

        List<Shape> listShapes = new List<Shape>();

        listShapes.Add(sq);

        listShapes.Add(re);

        listShapes.Add(ci);

        foreach (Shape shape in listShapes){
            Console.WriteLine(shape.GetArea());

            Console.WriteLine(shape.GetColor());
        }
        
    }
}