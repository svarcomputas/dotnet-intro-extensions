using felles;

namespace oppgave1Løsning;

class Program
{
    static void Main(string[] args)
    {
        var personer = SettOppPersoner();
        // TODO: Hent ut første person med navn Mikke
        var person = personer.Where(person => person.Navn == "Mikke").First();
        Oppgavebeskrivelse.PrintOppgaveSvar("1a", person);

        // TODO: Hent ut navnene på alle personer 
        var personNavn = personer.Select(person => person.Navn);
        Oppgavebeskrivelse.PrintOppgaveSvar("1b", string.Join(", ", personNavn));

        // TODO: Hent ut gjennomsnitsinntekten til alle over 50 år
        var avgInntekt = personer.Where(person => person.Alder > 50).Average(person => person.ÅrligInntekt);
        Oppgavebeskrivelse.PrintOppgaveSvar("1c", avgInntekt);

        // TODO: Hent ut personen med høyest inntekt
        var personMedHøyestInntekt = personer.OrderByDescending(person => person.ÅrligInntekt).FirstOrDefault();
        Oppgavebeskrivelse.PrintOppgaveSvar("1d", personMedHøyestInntekt);

        // TODO: Hent ut gjennomsnittsalderen til alle med en 'A' eller 'a' i navnet
        var gjennomsnittsAlderTilDeMedAINavnet = personer.Where(person => person.Navn.ToLower().Contains("a")).Average(person => person.Alder);
        Oppgavebeskrivelse.PrintOppgaveSvar("1e", gjennomsnittsAlderTilDeMedAINavnet);
     
    }

    static List<Person> SettOppPersoner(){
        return new List<Person>()
        {
            new Person(){Alder = 22, Navn = "Inga", ÅrligInntekt = 300000},
            new Person(){Alder = 34, Navn = "Kåre Johnny", ÅrligInntekt = 360000},
            new Person(){Alder = 28, Navn = "Bert", ÅrligInntekt = 550000},
            new Person(){Alder = 65, Navn = "Donald", ÅrligInntekt = 398000},
            new Person(){Alder = 52, Navn = "Mikke", ÅrligInntekt = 500000},
            new Person(){Alder = 54, Navn = "Minni", ÅrligInntekt = 700000},
            new Person(){Alder = 49, Navn = "Astrix", ÅrligInntekt = 800000},
            new Person(){Alder = 70, Navn = "Oblix", ÅrligInntekt = 1500000},
            new Person(){Alder = 37, Navn = "Pedro", ÅrligInntekt = 280000},
            new Person(){Alder = 54, Navn = "Astrid", ÅrligInntekt = 460000},
        };
    }
}