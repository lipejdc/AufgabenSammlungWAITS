namespace Aufgabe_103___Der_Parkplatz.Classes;

public class Fahrzeug : IFahrzeugOhneMotor, IFahrzeugMitMotor, IFahrzeugZusatz
{
    //public Fahrzeug(Fahrzeugart typ, Colors farbe)
    public Fahrzeug(Fahrzeugart typ)
    {
        Typ = typ;
        SetDefaultVehicelValues();
    }

    //Eigenschaften FahrzeugOhneMotor
    public Fahrzeugart Typ { get; set; }
    public Colors Farbe { get; set; }
    public int Länge { get; set; }
    public int Breite { get; set; }

    //Eigenschaften FahrzeugMitMotor
    public int Hubraum { get; set; }
    public int Leistung { get; set; }
    public int Drehmoment { get; set; }
    public double Beschleunigung0_100 { get; set; }
    public int Höchstgeschwindigkeit { get; set; }

    //Eigenschaften FahrzeugZusatz
    public int Zuladung { get; set; }

    public void SetDefaultVehicelValues()
    {
        // FAHRRAD
        if (Typ == Fahrzeugart.Fahrrad)
        {
            this.Farbe = new Colors("red");
            this.Länge = RandomValue(1, 3);
            this.Breite = RandomValue(1, 1); 
        }
        // MOTORRAD
        else if (Typ == Fahrzeugart.Motorrad)
        {
            this.Farbe = new Colors("blau");
        }
        // AUTO
        else if (Typ == Fahrzeugart.Auto)
        {
            this.Farbe = new Colors("gelb");
            
        }
        // LKW
        else
        {
            this.Farbe = new Colors("weiß");
            
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="min"></param>
    /// <param name="max"></param>
    /// <returns></returns>
    public static int RandomValue(int min, int max)
    {
        var rnd = new Random();
        return rnd.Next(min, max);
    }
}
