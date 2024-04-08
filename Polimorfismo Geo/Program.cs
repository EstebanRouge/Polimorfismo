using Polimorfismo_Geo;
using static Polimorfismo_Geo.RectangleFig;
using static Polimorfismo_Geo.TriangleFig;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el radio del círculo:");
        double radioCirculo = double.Parse(Console.ReadLine());
        FiguraGeometrica circulo = new Circulo(radioCirculo);
        Console.WriteLine("Área del círculo: " + circulo.CalcularArea());
        Console.WriteLine("Diámetro del círculo: " + circulo.CalcularDiametro());

        Console.WriteLine("Ingrese la base del rectángulo:");
        double baseRectangulo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del rectángulo:");
        double alturaRectangulo = double.Parse(Console.ReadLine());
        FiguraGeometrica rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
        Console.WriteLine("Área del rectángulo: " + rectangulo.CalcularArea());
        Console.WriteLine("Diámetro del rectángulo: " + rectangulo.CalcularDiametro());

        Console.WriteLine("Ingrese la base del triángulo:");
        double baseTriangulo = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura del triángulo:");
        double alturaTriangulo = double.Parse(Console.ReadLine());
        FiguraGeometrica triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
        Console.WriteLine("Área del triángulo: " + triangulo.CalcularArea());
        Console.WriteLine("Diámetro del triángulo: " + triangulo.CalcularDiametro());
    }
}