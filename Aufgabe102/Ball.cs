using System;

namespace Aufgabe102;

public class Ball
{
    //Eigenschaften

    public Farben Farbe { get; set; }

    public Punkt3D Position { get; set; }

    //Konstruktoren
    public Ball(Farben farbe, Punkt3D position)
    {
        Farbe = farbe;
        Position = position;
    }

    //Methoden

    //public int AddVector(int x, int y, int z)
    //{
    //    return 
    //}

    //public int AddVector(Punkt3D 3dpoint)
    //{
    //    return ballX + Punkt3D.X
    //}

    //public int SetPosition(int x, int y, int z)
    //{

    //}

    //public int SetPosition(Punkt3D 3dpoint)
    //{

    //}

    //public string SetColor(Farben farbe)
    //{

    //}

    public static void AusgabeColorPosition(Ball ball)
    {
        Console.WriteLine($"Farbe: {ball.Farbe}, Position: {ball.Position.X}, {ball.Position.Y}, {ball.Position.Z}");
    }
}
