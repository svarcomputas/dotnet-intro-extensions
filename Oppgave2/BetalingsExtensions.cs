using felles;

namespace oppgave2;

public static class BetalingExtensions
{
    // TODO: denne funksjonen skal bli en extension metode
    public static int HentAntallKontoOverføringerForEnPerson(List<Betaling> betalinger, string personId)
    {
        return betalinger.Where(betaling => betaling.PersonId == personId).Count();
    }

    // TODO: Funksjonen skal hente ut alle betlainger gjort de siste X dager og summere de på BetalingsType.InnPåKontoer
    public static double TotaltSumInnPåAlleKontoerSisteXDager(this List<Betaling> betalinger, int dager)
    {
        return 0; // ?????
    }

    // TODO: Funksjonen skal returnere en betalingsoppsumerings for de siste X dager
    public static BetalingsOppsummering TilOppsummeringForSisteXDager(this List<Betaling> betalinger, int dager)
    {
        return new BetalingsOppsummering()
        {
            // ?????????
        };
    }
}
