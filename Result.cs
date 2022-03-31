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

    public virtual Result Clone()
    {
        return new Result
               {
                   Code = Code,
                   Message = Message
               };
    }

    public override string ToString()
    {
        return $"{Code}";
    }
}

public partial class Result<TContent> : Result
{
    public new virtual Result<TContent> Clone()
    {
        return new Result<TContent>
               {
                   Code = Code,
                   Message = Message,
                   Content = Content,
                   Paging = Paging
               };
    }
    public virtual Result<TContent> Clone(TContent? content, Paging? paging = null)
    {
        return new Result<TContent>
               {
                   Code = Code,
                   Message = Message,
                   Content = content,
                   Paging = paging
               };
    }

    public TContent? Content { get; set; }
    public Paging? Paging { get; set; }
}