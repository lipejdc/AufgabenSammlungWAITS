using Aufgabe_103___Der_Parkplatz;
using Aufgabe_103___Der_Parkplatz.Classes;

class Program
{
    static void Main(string[] args)
    {
        // 1. Fhzg. -- Fahrrad - Default Color == rot
        var fhzgFahrrad = new Fahrzeug(Fahrzeugart.Fahrrad);

        // 2. Fhzg. -- Motorrad - Default Color == blau
        var fhzgMotorrad = new Fahrzeug(Fahrzeugart.Motorrad);

        // 3. Fhzg. -- Auto - Default Color == gelb
        //var fhzgAuto = new Fahrzeug(Fahrzeugart.Auto);

        // 4. Fhzg. -- LKW - Default Color == weiß
        //var fhzLkw = new Fahrzeug(Fahrzeugart.LKW);

        //Queue<Fahrzeuge> alleFahrzeuge = new Queue<Fahrzeuge>();

    }
}