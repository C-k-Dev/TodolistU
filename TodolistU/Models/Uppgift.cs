//Basen för att skapa uppgifter i listan
namespace TodolistU.Models
{
    public class Uppgift
    {
        public int Id { get; set; }
        public string Titel { get; set; } // Kan ej vara null enligt varningen
        public string Beskrivning { get; set; }
        public bool ÄrKlar { get; set; }

        public Uppgift()
        {
            Titel = ""; // Tilldela ett standardvärde till Titel i konstruktorn
            Beskrivning = "";
            ÄrKlar = false;
            Id = 0;
        }
    }
}