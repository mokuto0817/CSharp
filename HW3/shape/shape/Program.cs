using System;

namespace shape
{
    class Program
    {
        static void Main(string[] args)
        {
//            bool judge;
//            //输入长方形的长和宽
//            Console.WriteLine("Enter the length of rectangle:");
//            float length = Convert.ToSingle(Console.ReadLine());
//            Console.WriteLine("Enter the width of rectangle:");
//            float width = Convert.ToSingle(Console.ReadLine());
//            //判断是否为正方形
//            if(length==width)
//            {
//                Console.WriteLine("It is a square!");
//                Square squ = new Square(length);
//                Console.WriteLine("The area of square is:{0}", squ.getArea());
//            }
//            else
//            {
//                Rectangle rec = new Rectangle(length, width);
//                judge = rec.judgeLegal();
//                if (judge) Console.WriteLine("The area of rectangle is:{0}", rec.getArea());
//            }
//            //输入三角形的边长
//            Console.WriteLine("Enter three side of a triangle:");
//            float a = Convert.ToSingle(Console.ReadLine());
//            float b = Convert.ToSingle(Console.ReadLine());
//            float c = Convert.ToSingle(Console.ReadLine());
//            Triangle tri = new Triangle(a,b,c);
//            judge = tri.judgeLegal();
//            if (judge) Console.WriteLine("The area of triangle is:{0}", tri.getArea());

            String[] type = { "rectangle", "square", "triangle" };  //表示可用的形状
            int[] parameterNumbers = { 2, 1, 3 };  //创建对应形状所需要的参数
            Baseshape shape;
            float sumArea = 0;
            for (int i = 0; i < 10; i++)
            {
                int randomType = new Random().Next(0, type.Length);
                float[] parameters = new float[parameterNumbers[randomType]];  //参数
                do
                {
                    for (int j = 0; j < parameters.Length; j++)
                    {
                        Random random = new Random(Guid.NewGuid().GetHashCode());
                        parameters[j] = random.Next() + random.Next(0, 100);
                    }
                    shape = ShapeFactory.Product(type[randomType], parameters);
                } while (shape == null);
                sumArea = sumArea + shape.getArea();
            }
            Console.WriteLine($"The total area is {sumArea}.");
        }
    }

    //基础形状
    abstract class Baseshape
    {
        protected bool shapeIsLegal;
        public abstract bool judgeLegal();
        protected float area { get; set; }
        public abstract float getArea();

        public abstract void createShape();
    }

    //长方形
    class Rectangle : Baseshape
    {
        public float length;
        public float width;
        //无参构造方法
        public Rectangle() { }
        //含长度和宽度的构造方法
        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        //创建一个长方形实例
        public override void createShape()
        {
            Rectangle rectangle = new Rectangle();
        }

        //计算长方形面积
        public override float getArea()
        {
            area = length * width;
            return area;
        }
        //判断是否为长方形
        public override bool judgeLegal()
        {
            if (length != 0 && width != 0)
            {
                shapeIsLegal = true;
                return shapeIsLegal;
            }
            else
            {
                shapeIsLegal = false;
                Console.WriteLine("The length and width can't be zero!"); 
                return shapeIsLegal;
            }
        }
    }

    //正方形：特殊的长方形
    class Square : Rectangle
    {
        public float side;
        //无参构造方法
        public Square() { }
        //含边长的构造方法
        public Square(float side)
        {
            this.side = side;
        }
        //创建一个正方形实例
        public override void createShape()
        {
            Square square = new Square();
        }

        //计算正方形面积
        public override float getArea()
        {
            area = side*side;
            return area;
        }
    }

    //三角形
    class Triangle : Baseshape
    {
        public float a;
        public float b;
        public float c;
        //无参构造函数
        public Triangle() { }
        //含三条边长的三角形构造器
        public Triangle(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        //创建一个三角形实例
        public override void createShape()
        {
            Triangle triangle = new Triangle();
        }

        //计算三角形的面积
        public override float getArea()
        {
            float s = (a + b + c) / 2;
            area = (float)Math.Sqrt(s*(s - a)*(s - b)*(s - c));
            return area;
        }
        //判断是否为三角形
        public override bool judgeLegal()
        {
            if(a+b>c&&a+c>b&&b+c>a)
            {
                shapeIsLegal = true;
                return shapeIsLegal;
            }
            else
            {
                shapeIsLegal = false;
                Console.WriteLine("It isn't a triangle!");
                return shapeIsLegal;
            }
        }
    }

    //形状工厂
    class ShapeFactory
    {
        public static Baseshape Product(String type, float[] values)
        {
            Baseshape shape = null;
            switch (type)
            {
                case "rectangle":
                    if (values.Length != 2)
                    {
                        Console.WriteLine("The parameter length is incorrect!");
                        break;
                    }
                    shape = new Rectangle(values[0], values[1]);
                    break;
                case "square":
                    if (values.Length != 1)
                    {
                        Console.WriteLine("The parameter length is incorrect!");
                        break;
                    }
                    shape = new Square(values[0]);
                    break;
                case "triangle":
                    if (values.Length != 3)
                    {
                        Console.WriteLine("The parameter length is incorrect!");
                        break;
                    }
                    float maxValue = Math.Max(Math.Max(values[0], values[1]), values[2]);
                    if (values[0] + values[1] + values[2] - maxValue < maxValue)
                    {
                        Console.WriteLine("The parameter is incorrect!");
                        break;
                    }
                    shape = new Triangle(values[0], values[1], values[2]);
                    break;
            }
            return shape;

        }



    }
}

