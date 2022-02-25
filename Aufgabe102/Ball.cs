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
}
