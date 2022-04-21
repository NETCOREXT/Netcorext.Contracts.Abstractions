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

    public virtual Result Clone() => Clone(Code, Message);
    public virtual Result Clone(string? message) => Clone(Code, message);
    private static Result Clone(string? code, string? message)
    {
        return new Result
               {
                   Code = code,
                   Message = message
               };
    }

    public override string ToString()
    {
        return $"{Code}";
    }
}

public partial class Result<TContent> : Result
{
    public new virtual Result<TContent> Clone() => Clone(Code, Message, Content, Paging);
    public new virtual Result<TContent> Clone(string? message) => Clone(Code, message, Content, Paging);
    public virtual Result<TContent> Clone(string? message, TContent? content) => Clone(Code, message, content, Paging);
    public virtual Result<TContent> Clone(string? message, TContent? content, Paging? paging) => Clone(Code, message, content, paging);
    public virtual Result<TContent> Clone(TContent? content) => Clone(Code, Message, content, Paging);
    public virtual Result<TContent> Clone(TContent? content, Paging? paging) => Clone(Code, Message, content, paging);
    private static Result<TContent> Clone(string? code, string? message, TContent? content, Paging? paging)
    {
        return new Result<TContent>
               {
                   Code = code,
                   Message = message,
                   Content = content,
                   Paging = paging
               };
    }

    public TContent? Content { get; set; }
    public Paging? Paging { get; set; }
}