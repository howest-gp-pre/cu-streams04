namespace Pre.Streams.Cursus04.Core;

public class PostalCode
{
    public string Zip { get; set; }
    public string City { get; set; }
    public double Lng { get; set; }
    public double Lat { get; set; }

    public override string ToString()
    {
        return $"{Zip} {City} ({Lat}:{Lng})";
    }
}