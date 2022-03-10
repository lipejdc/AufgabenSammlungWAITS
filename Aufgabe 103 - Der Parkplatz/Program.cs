using Aufgabe_103___Der_Parkplatz;
using Aufgabe_103___Der_Parkplatz.Classes;

class Program
{
    static void Main(string[] args)
    {
        Fahrzeug bike = new(Fahrzeugart.Fahrrad);
        Fahrzeug motorbike = new(Fahrzeugart.Motorrad);
        Fahrzeug car = new(Fahrzeugart.Auto);
        Fahrzeug truck = new(Fahrzeugart.LKW);


        Queue<Fahrzeug> alleFahrzeuge = new Queue<Fahrzeug>();

        alleFahrzeuge.Enqueue(bike);
        alleFahrzeuge.Enqueue(motorbike);
        alleFahrzeuge.Enqueue(car);
        alleFahrzeuge.Enqueue(truck);

        foreach (var fahrzeug in alleFahrzeuge)
        {
            Console.WriteLine(fahrzeug.ToString());
            Console.WriteLine("--------------------------------------------------------");
        }
    }
}