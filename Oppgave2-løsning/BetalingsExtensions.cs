using felles;

namespace oppgave2Løsning;

public static class BetalingExtensions
{
    public static int HentAntallKontoOverføringerForEnPerson(this List<Betaling> betalinger, string personId)
    {
        return betalinger.Where(betaling => betaling.PersonId == personId).Count();
    }

    public static double TotaltSumInnPåAlleKontoerSisteXDager(this List<Betaling> betalinger, int dager)
    {
        return betalinger.Where(betaling => betaling.Dato > DateTime.Now.AddDays(-dager)).SummerPåType(BetalingsType.InnPåKontoer);
    }

    public static BetalingsOppsummering TilOppsummeringForSisteXDager(this List<Betaling> betalinger, int dager)
    {
        var betalingerSistDager = betalinger.Where(betaling => betaling.Dato > DateTime.Now.AddDays(-dager)).ToList();
        return new BetalingsOppsummering()
        {
            SisteDager = dager,
            TotaltInnPåKontoer = betalingerSistDager.SummerPåType(BetalingsType.InnPåKontoer),
            TotaltUtFraKontoer = betalingerSistDager.SummerPåType(BetalingsType.UtFraKontoer),
            TotaltOverførtEgneKontoer = betalingerSistDager.SummerPåType(BetalingsType.OverføringEgneKontoer)
        };
    }

    public static double SummerPåType(this IEnumerable<Betaling> betalinger, BetalingsType type)
    {
        return betalinger
            .Where(betaling => betaling.BetalingsType == type)
            .Select(betaling => betaling.Beløp).Sum();
    }
}
