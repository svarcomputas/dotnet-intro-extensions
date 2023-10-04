using System.Runtime.Intrinsics.X86;

namespace felles;

public static class Oppgavebeskrivelse
{
    private static List<string> oppgavebeskrivelser = new List<string>{
@"Oppgave 1a: Hent ut første person med navn Mikke
Riktig svar:  Mikke er 52 år og har 500000 i årlig inntekt
Ditt svar:    {0}",
@"Oppgave 1b: Hent ut navnene på alle personer 
Riktig svar:  Inga, Kåre Johnny, Bert, Donald, Mikke, Minni, Astrix, Oblix, Pedro, Astrid
Ditt svar:    {0}",
@"Oppgave 1c: Hent ut gjennomsnitsinntekten til alle over 50 år
Riktig svar:  711600
Ditt svar:    {0}",
@"Oppgave 1d: Hent ut personen med høyest inntekt
Riktig svar:  Oblix er 70 år og har 1500000 i årlig inntekt
Ditt svar:    {0}",
@"Oppgave 1e: Hent ut gjennomsnittsalderen til alle med en 'A' eller 'a' i navnet
Riktig svar:  47.5
Ditt svar:    {0}",
@"Oppgave 2a: Implementer funksjonen HentAntallKontoOverføringerForEnPerson som en extension metode, slik at vi kan bruke den som under
Riktig svar:  8
Ditt svar:    {0}",
@"Oppgave 2b: Implementer TotaltSumInnPåAlleKontoerSisteXDager i betalingsExtensions
Riktig svar:  7803
Ditt svar:    {0}",
@"Oppgave 2c: Implementer funksjonen TilOppsummeringForSisteXDager i betalingsExtensions
Riktig svar:  Betlaingsoppsummering for de siste 14 dagene:
Totalt inn på kontoer:               7803
Totalt ut fra kontoer:               398000
Totalt overfort mellom egne kontoer: 47844.223
Ditt svar:    {0}"
    };

    public static void PrintOppgaveSvar(string oppgaveId, object svar)
    { 
        switch (oppgaveId)
        {
            case "1a": Console.WriteLine(string.Format(oppgavebeskrivelser[0], svar)+"\n");
                break;
            case "1b":
                Console.WriteLine(string.Format(oppgavebeskrivelser[1], svar)+"\n");
                break;
            case "1c":
                Console.WriteLine(string.Format(oppgavebeskrivelser[2], svar)+"\n");
                break;
            case "1d":
                Console.WriteLine(string.Format(oppgavebeskrivelser[3], svar)+"\n");
                break;
            case "1e":
                Console.WriteLine(string.Format(oppgavebeskrivelser[4], svar)+"\n");
                break;
            case "2a":
                Console.WriteLine(string.Format(oppgavebeskrivelser[5], svar)+"\n");
                break;
            case "2b":
                Console.WriteLine(string.Format(oppgavebeskrivelser[6], svar)+"\n");
                break;
            case "2c":
                Console.WriteLine(string.Format(oppgavebeskrivelser[7], svar)+"\n");
                break;
            default: Console.WriteLine("Ikke implementert");
                break;
        } 
    }
}