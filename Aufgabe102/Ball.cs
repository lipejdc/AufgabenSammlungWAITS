﻿using System;

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

    public void AddVector(int x, int y, int z)
    {
        Position.X = Position.X + x;
        Position.Y = Position.Y + y;
        Position.Z = Position.Z + z;
    }

    public void AddVector(Punkt3D pointToAdd)
    {
        Position.X = Position.X + pointToAdd.X;
        Position.Y = Position.Y + pointToAdd.Y;
        Position.Z = Position.Z + pointToAdd.Z;
    }

    public void SetPosition(int x, int y, int z)
    {
        Position.X = x;
        Position.Y = y;
        Position.Z = z;
    }

    public void SetPosition(Punkt3D pointToSet)
    {
        Position.X = pointToSet.X;
        Position.Y = pointToSet.Y;
        Position.Z = pointToSet.Z;
    }

    public void SetColor(Farben colorToSet)
    {
        Farbe = colorToSet;
    }

    public static void AusgabeColorPosition(Ball ball)
    {
        Console.WriteLine($"Farbe: {ball.Farbe}, Position: {ball.Position.X}, {ball.Position.Y}, {ball.Position.Z}");
    }
}
