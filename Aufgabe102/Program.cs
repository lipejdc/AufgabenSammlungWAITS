using Aufgabe102;
using System;

namespace Aufgabe102;

public class Program
{
    static void Main(string[] args)
    {

        //Objekte

        //Aufgabe 7
        var point2d1 = new Punkt2D(60, 100);

        //Aufgabe 8
        Console.WriteLine($"{nameof(point2d1)}: {point2d1.X}, {point2d1.Y}");

        //Aufgabe 9
        var point3d1 = new Punkt3D(80, 90, 100);
        var point3d2 = new Punkt3D(new Punkt2D(55, 99), 77);

        //Aufgabe 10
        Console.WriteLine($"{nameof(point3d1)}: {point3d1.X}, {point3d1.Y}, {point3d1.Z}");
        Console.WriteLine($"{nameof(point3d2)}: {point3d2.X}, {point3d2.Y}, {point3d2.Z}");

        //Aufgabe 11
        var ball1 = new Ball(Farben.Red, point3d1);

        //Aufgabe 12
        ball1.AusgabeColorPosition();

        //Aufgabe 13
        ball1.AddVector(20, 110, 200);

        //Aufgabe 14
        ball1.AusgabeColorPosition();

        //Aufgabe 15
        ball1.AddVector(point3d2);

        //Aufgabe 16
        ball1.AusgabeColorPosition();

        //Aufgabe 17
        ball1.SetPosition(1000, 1000, 1000);

        //Aufgabe 18
        ball1.SetColor(Farben.Yellow);

        //Aufgabe 19
        ball1.AusgabeColorPosition();

        //Aufgabe 20
        ball1.AddVector(1, 1, 1);

        //Aufgabe 21
        ball1.AusgabeColorPosition();

        //Augabe 22
        ball1.SetPosition(1, 1, 1);

        //Aufgabe 23
        ball1.SetColor(Farben.Green);

        //Aufgabe 24
        ball1.AusgabeColorPosition();

        //Console.WriteLine($"{ball1.Farbe}");
        //Console.WriteLine($"{ball1.Position.X}");
        //Console.WriteLine($"{ball1.Position.Y}");
        //Console.WriteLine($"{ball1.Position.Z}");

        //-------------------------------------------------------



        //Console.ReadLine();


        // ###################################
        // ###################################
        // Nutzen des überladenen Constr. Point2D Object und Z-Wert
        //var zweiDVersuch = new Punkt2D(99, 22);
        //var point3D = new Punkt3D(zweiDVersuch, 77);
        //Console.WriteLine("-----------------------------------");
        //Console.WriteLine($"Constr. Überladung (+ToString) ({nameof(point3D)}): {point3D}");
        //Console.WriteLine($"Constr. Überladung (-ToString) ({nameof(point3D)}): {point3D.X}, {point3D.Y}, {point3D.Z}");
        //Punkt3D dreiD12 = new Punkt3D(80, 90, 100);
        //Console.WriteLine("-----------------------------------");




        // TEST - ADDVector
        //Punkt3D punkt3D = new(1,1,1);
        //Punkt3D punktAddition = new(2,2,2);
        //Ball ballAddition = new(Farben.Red, punkt3D);

        // Aufrufen der Methode an der Instanz (Objekt) der Klasse Ball (ohne static)
        //ballAddition.AddVector(punktAddition);

        // SetColor
        //ballAddition.SetColor(Farben.Green);

        //ballAddition.AusgabeColorPosition();

        // output
        //Console.WriteLine(dreiD1.ToString());
        //Console.WriteLine(zweiD.ToString());
    }
}
