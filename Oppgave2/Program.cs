using System;
using felles;

namespace oppgave2;

class Program
{
    /*
     * En betaling har en enum type, et beløp , en dato og er knyttet til en person med personId
     * Alle endringer skal gjør i BetalingsExtensions klassen
     * Se gjerne på klassene Betaling og BetalingsOppsummering før du starter
     */
    static void Main(string[] args)
    {
        var personer = SettOppPersoner();
        var betalinger = SettOppBetalinger();
        // TODO: implementer funksjonen HentAntallKontoOverføringerForEnPerson som en extension metode, slik at vi kan bruke den som under
        var betalingerForPerson = betalinger.HentAntallKontoOverføringerForEnPerson("1");
        Oppgavebeskrivelse.PrintOppgaveSvar("2a", betalingerForPerson);

        // TODO: implementer TotaltSumInnPåAlleKontoerSisteXDager i betalingsExtensions
        var totalSumInnPåAlleKontorSiste14Dager = betalinger.TotaltSumInnPåAlleKontoerSisteXDager(14);
        Oppgavebeskrivelse.PrintOppgaveSvar("2b", totalSumInnPåAlleKontorSiste14Dager);

        // TODO: Implementer funksjonen TilOppsummeringForSisteXDager i betalingsExtensions
        var betalingsOppsummeringSiste14Dager = betalinger.TilOppsummeringForSisteXDager(14);
        Oppgavebeskrivelse.PrintOppgaveSvar("2c", betalingsOppsummeringSiste14Dager);
    }

    static List<Person> SettOppPersoner()
    {
        return new List<Person>()
        {
            new Person(){Id = "1", Navn = "Inga"},
            new Person(){Id = "2", Navn = "Kåre"},
        };
    }

    static List<Betaling> SettOppBetalinger()
    {
        return new List<Betaling>()
        {
            new Betaling(){PersonId = "1", BetalingsType = BetalingsType.UtFraKontoer, Beløp = 365430, Dato = DateTime.Now.AddDays(-12)},
            new Betaling(){PersonId = "1", BetalingsType = BetalingsType.InnPåKontoer, Beløp = 3120, Dato = DateTime.Now},
            new Betaling(){PersonId = "1", BetalingsType = BetalingsType.OverføringEgneKontoer, Beløp = 30.123, Dato = DateTime.Now},
            new Betaling(){PersonId = "1", BetalingsType = BetalingsType.InnPåKontoer, Beløp = 9430, Dato = DateTime.Now.AddDays(-15)},
            new Betaling(){PersonId = "1", BetalingsType = BetalingsType.UtFraKontoer, Beløp = 230, Dato = DateTime.Now.AddDays(-12)},
            new Betaling(){PersonId = "1", BetalingsType = BetalingsType.OverføringEgneKontoer, Beløp = 12330, Dato = DateTime.Now},
            new Betaling(){PersonId = "1", BetalingsType = BetalingsType.InnPåKontoer, Beløp = 12330, Dato = DateTime.Now.AddDays(-300)},
            new Betaling(){PersonId = "1", BetalingsType = BetalingsType.InnPåKontoer, Beløp = 30, Dato = DateTime.Now},
            new Betaling(){PersonId = "2", BetalingsType = BetalingsType.UtFraKontoer, Beløp = 33330, Dato = DateTime.Now.AddDays(-17)},
            new Betaling(){PersonId = "2", BetalingsType = BetalingsType.InnPåKontoer, Beløp = 870, Dato = DateTime.Now},
            new Betaling(){PersonId = "2", BetalingsType = BetalingsType.OverføringEgneKontoer, Beløp = 3550, Dato = DateTime.Now.AddDays(-3122)},
            new Betaling(){PersonId = "2", BetalingsType = BetalingsType.InnPåKontoer, Beløp = 30, Dato = DateTime.Now},
            new Betaling(){PersonId = "2", BetalingsType = BetalingsType.OverføringEgneKontoer, Beløp = 35450, Dato = DateTime.Now.AddDays(-2)},
            new Betaling(){PersonId = "2", BetalingsType = BetalingsType.UtFraKontoer, Beløp = 32340, Dato = DateTime.Now},
            new Betaling(){PersonId = "2", BetalingsType = BetalingsType.InnPåKontoer, Beløp = 3753, Dato = DateTime.Now.AddDays(-1)},
            new Betaling(){PersonId = "2", BetalingsType = BetalingsType.OverføringEgneKontoer, Beløp = 34.1, Dato = DateTime.Now},
            new Betaling(){PersonId = "2", BetalingsType = BetalingsType.UtFraKontoer, Beløp = 3230, Dato = DateTime.Now.AddDays(-14)}
        };
    }
}