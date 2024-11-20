using OCP;

Shapes rect = new Rectangle{Height = 5, Width = 4};
System.Console.WriteLine($"The area of the rectangle is {rect.CalculateArea()}");

Shapes square = new Square{SideLength = 5};
System.Console.WriteLine($"The area of the square is {square.CalculateArea()}");
