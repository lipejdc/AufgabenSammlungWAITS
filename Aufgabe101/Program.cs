namespace Aufgabe101;
using System.Collections;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> autoKennzeichen = new List<string>();

        autoKennzeichen.Add("K-UI 873");        
        autoKennzeichen.Add("HB-QW 8");
        autoKennzeichen.Add("M-DE 191");
        autoKennzeichen.Add("K-LO 91");
        autoKennzeichen.Add("K-IH 143");
        autoKennzeichen.Add("K-SM 98");
        autoKennzeichen.Add("K-BT 1722");
        autoKennzeichen.Add("HH-JI 823");
        autoKennzeichen.Add("GL-OO 23");
        autoKennzeichen.Add("K-UU 762");

        Dictionary<string, string> stellPlätze = new();

        stellPlätze.Add("A1", "K-SM 98");
        stellPlätze.Add("A2", "HH-JI 823");
        stellPlätze.Add("A3", "GL-OO 23");
        stellPlätze.Add("A4", "M-DE 101");
        stellPlätze.Add("A5", "K-UI 873");
        stellPlätze.Add("B1", "K-BT 1722");
        stellPlätze.Add("B2", "HB-QW 8");
        stellPlätze.Add("B3", "K-LO 91");
        stellPlätze.Add("B4", "K-IH 143");
        stellPlätze.Add("B5", "K-UU 762");

        // Hilfsarray um die Reihenfolge abzubilden.
        string[] helpArray = { "A5", "A4", "B1", "B5", "A3", "A2", "B4", "B3", "A1", "B2" };

        Parkhaus.ParkHausMagic(stellPlätze, helpArray);
    }
}




























//------- 1. Fahrzeug fährt an die Schranke -------
//Stellplatz: A1, Status: BESETZT(Fhzg: K-UI 873)
//Stellplatz: A2, Status: BESETZT(Fhzg: HB-QW 8)
//Stellplatz: A3, Status: BESETZT(Fhzg: M-DE 101)
//Stellplatz: A4, Status: BESETZT(Fhzg: K-LO 91)
//Stellplatz: A5, Status: FREI
//Stellplatz: B1, Status: BESETZT(Fhzg: K-SM 98)
//Stellplatz: B2, Status: BESETZT(Fhzg: K-BT 1722)
//Stellplatz: B3, Status: BESETZT(Fhzg: HH-JI 823)
//Stellplatz: B4, Status: BESETZT(Fhzg: GL-OO 23)
//Stellplatz: B5, Status: BESETZT(Fhzg: K-UU 762)
//------- 2. Fahrzeug fährt an die Schranke -------
//Stellplatz: A1, Status: BESETZT(Fhzg: K-UI 873)
//Stellplatz: A2, Status: BESETZT(Fhzg: HB-QW 8)
//Stellplatz: A3, Status: BESETZT(Fhzg: M-DE 101)
//Stellplatz: A4, Status: FREI
//Stellplatz: A5, Status: FREI
//Stellplatz: B1, Status: BESETZT(Fhzg: K-SM 98)
//Stellplatz: B2, Status: BESETZT(Fhzg: K-BT 1722)
//Stellplatz: B3, Status: BESETZT(Fhzg: HH-JI 823)
//Stellplatz: B4, Status: BESETZT(Fhzg: GL-OO 23)
//Stellplatz: B5, Status: BESETZT(Fhzg: K-UU 762)
//------- 3. Fahrzeug fährt an die Schranke -------
//Stellplatz: A1, Status: BESETZT(Fhzg: K-UI 873)
//Stellplatz: A2, Status: BESETZT(Fhzg: HB-QW 8)
//Stellplatz: A3, Status: BESETZT(Fhzg: M-DE 101)
//Stellplatz: A4, Status: FREI
//Stellplatz: A5, Status: FREI
//Stellplatz: B1, Status: FREI
//Stellplatz: B2, Status: BESETZT(Fhzg: K-BT 1722)
//Stellplatz: B3, Status: BESETZT(Fhzg: HH-JI 823)
//Stellplatz: B4, Status: BESETZT(Fhzg: GL-OO 23)
//Stellplatz: B5, Status: BESETZT(Fhzg: K-UU 762)
//------- 4. Fahrzeug fährt an die Schranke -------
//Stellplatz: A1, Status: BESETZT(Fhzg: K-UI 873)
//Stellplatz: A2, Status: BESETZT(Fhzg: HB-QW 8)
//Stellplatz: A3, Status: BESETZT(Fhzg: M-DE 101)
//Stellplatz: A4, Status: FREI
//Stellplatz: A5, Status: FREI
//Stellplatz: B1, Status: FREI
//Stellplatz: B2, Status: BESETZT(Fhzg: K-BT 1722)
//Stellplatz: B3, Status: BESETZT(Fhzg: HH-JI 823)
//Stellplatz: B4, Status: BESETZT(Fhzg: GL-OO 23)
//Stellplatz: B5, Status: FREI
//------- 5. Fahrzeug fährt an die Schranke -------
