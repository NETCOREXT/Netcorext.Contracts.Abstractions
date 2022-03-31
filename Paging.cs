namespace Netcorext.Contracts;

public class Paging
{
    public int Offset { get; set; }
    public int Limit { get; set; }
    public int? Count { get; set; }
}