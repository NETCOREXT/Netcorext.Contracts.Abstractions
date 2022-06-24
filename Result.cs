using FluentValidation.Results;

namespace Netcorext.Contracts;

public partial class Result
{
    public string? Code { get; set; }
    public string? Message { get; set; }

    public IEnumerable<ValidationFailure>? Errors { get; set; }
    public static implicit operator string?(Result r) => r.Code;
    public static implicit operator Result(string code) => new() { Code = code };
    public static bool operator ==(Result? r1, Result? r2) => r1?.Code == r2?.Code;
    public static bool operator !=(Result? r1, Result? r2) => r1?.Code != r2?.Code;
    public virtual Result Clone() => Clone(Code, Message);
    public virtual Result Clone(string? message) => Clone(Code, message);
    private static Result Clone(string? code, string? message) => new() { Code = code, Message = message };
    public override string ToString() => $"{Code}";

    public override bool Equals(object obj)
    {
        var r = obj as Result;

        return Code == r?.Code;
    }

    protected bool Equals(Result? other) => Code == other?.Code;

    public override int GetHashCode()
    {
        unchecked
        {
            return (Code != null ? Code.GetHashCode() : 0) * 397;
        }
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