public class Person
{
    public string Id { get; set; }
    public int Alder { get; set; }
    public string Navn { get; set; }
    public int ÅrligInntekt { get; set; }

    public override string ToString()
    {
        return $"{Navn} er {Alder} år og har {ÅrligInntekt} i årlig inntekt";
    }
}