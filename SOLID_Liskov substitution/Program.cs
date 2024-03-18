namespace App
{
    class Program
    {
        static int Area(Rectangle rec) => rec.Width * rec.Hight;
        static void Main()
        {
            Rectangle re = new Rectangle(3, 4);
            Rectangle square = new Square();
            square.Width = 5;

            Console.WriteLine($"The Area of the Rectangle = {Area(re)}");
            Console.WriteLine($"The Area of the square = {Area(square)}");
        }
    }

    // Look to Rectangle.cs file for the right way 

    // it's the wrong way of using inheritance because square won't act as a rectangle in right way 
    //class Rectangle
    //{
    //    public int Width {get; set;}
    //    public int Hight {get; set;}
    //    public Rectangle()
    //    {

    //    }
    //    public Rectangle(int width,int hight)
    //    {
    //        Width = width;
    //        Hight = hight;
    //    }
    //}

    //class Square : Rectangle
    //{
    //    public new int Width { set { base.Width = value; base.Hight = value; } }
    //    public new int Hight { set { base.Width = value; base.Hight = value; } }
    //}


}