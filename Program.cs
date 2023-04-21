// See https://aka.ms/new-console-template for more information

using System ;

namespace ShapeClass
{
    public  class Circle{
       private  double Radius { get; set; }
       public  string Color { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public Circle(double radius, string color, double width, double length)
        {
            this.Radius = radius;
            this.Color = color;
            this.Width = width;
            this.Length = length;
        }
        public virtual string Tostring() {
            return $"Circle with radius {Radius}, color {Color}, width {Width}, and length {Length}";


        }
        public double TinhDienTichCircle ()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
public class Cylinder : Circle
    {
       public double height { get; set; }
       

        public Cylinder(double radius, string color, double width, double length, double height) : base(radius, color, width, length)
        {
            this.height = height;
        }

      

        public double cylindricalvolume()
        {

            return TinhDienTichCircle() * height;
        }

        public override string Tostring()
        {
            return $"Cylinder with radius {Width / 2}, height {height}, and color {Color}";

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thong tin Circle: ");
            Console.Write("Radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.Write("Color: ");
          

            string color = Console.ReadLine();
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Circle circle = new Circle(radius, color, width, length);
            Console.WriteLine(circle.ToString());
            Console.WriteLine($"Dien tich of the circle: {circle.TinhDienTichCircle()}");
            Console.Write("========================================================= ");
            Console.WriteLine("Nhap thong tin Cylinder: ");
            Console.WriteLine("Height : ");
          
            double height = double.Parse(Console.ReadLine());
            Cylinder cylinder = new Cylinder( radius,  color,  width,  length,  height);
            Console.WriteLine($"Dien tich of the Cyliner: {cylinder.cylindricalvolume()}");
            
        }
    }
}

        
    

