namespace Netcorext.Contracts;

public partial class Result
{
    public string? Code { get; set; }
    public string? Message { get; set; }

    public static implicit operator string?(Result r)
    {
        return r.Code;
    }

    public static implicit operator Result(string code)
    {
        return new Result { Code = code };
    }

    public override string ToString()
    {
        return $"{Code}";
    }
}

public partial class Result<TContent> : Result
{
    public TContent? Content { get; set; }
    public Paging? Paging { get; set; }
}