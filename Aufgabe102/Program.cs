using Aufgabe102;

namespace Aufgabe102;

public class Program
{
    static void Main(string[] args)
    {

        //Objekte
        var point2d1 = new Punkt2D(60, 100);
        Console.WriteLine($"{nameof(point2d1)}: {point2d1.X}, {point2d1.Y}");
        var point2d2 = new Punkt2D(55, 99);

        var point3d1 = new Punkt3D(80, 90, 100);
        var point3d2 = new Punkt3D(point2d2, 77);
        Console.WriteLine($"{nameof(point3d1)}: {point3d1.X}, {point3d1.Y}, {point3d1.Z}");
        Console.WriteLine($"{nameof(point3d2)}: {point3d2.X}, {point3d2.Y}, {point3d2.Z}");

        var ball1 = new Ball(Farben.Red, point3d1);
        Console.WriteLine($"{nameof(ball1)}: ");



        // ###################################
        // ###################################
        // Nutzen des überladenen Constr. Point2D Object und Z-Wert
        var zweiDVersuch = new Punkt2D(99, 22);
        var point3D = new Punkt3D(zweiDVersuch, 77);
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Constr. Überladung (+ToString) ({nameof(point3D)}): {point3D}");
        Console.WriteLine($"Constr. Überladung (-ToString) ({nameof(point3D)}): {point3D.X}, {point3D.Y}, {point3D.Z}");
        var dreiD12 = new Punkt3D(80, 90, 100);
        Console.WriteLine("-----------------------------------");


        // output
        //Console.WriteLine(dreiD1.ToString());
        //Console.WriteLine(zweiD.ToString());
    }
}
