using FluentValidation.Results;

namespace Netcorext.Contracts;

public partial class Result
{
    public string Code { get; set; } = null!;
    public string? Message { get; set; }
    public object? State { get; set; }
    public IEnumerable<ValidationFailure>? Errors { get; set; }
    public static implicit operator string(Result r) => r.Code;
    public static implicit operator Result(string code) => new() { Code = code };
    public static bool operator ==(Result? r1, Result? r2) => r1?.Code == r2?.Code;
    public static bool operator !=(Result? r1, Result? r2) => r1?.Code != r2?.Code;

    public virtual Result Clone() => Clone(Code, Message, Errors);
    public virtual Result Clone(string? message) => Clone(Code, message, Errors);
    public virtual Result Clone(string? message, IEnumerable<ValidationFailure>? errors) => Clone(Code, message, Errors = errors);
    public virtual Result Clone(IEnumerable<ValidationFailure>? errors) => Clone(Code, Message, errors);
    private static Result Clone(string code, string? message, IEnumerable<ValidationFailure>? errors) => new() { Code = code, Message = message, Errors = errors };
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
            return (!string.IsNullOrWhiteSpace(Code) ? Code.GetHashCode() : 0) * 397;
        }
    }
}

public partial class Result<TContent> : Result
{
    public new virtual Result<TContent> Clone() => Clone(Code, Message, Errors, Content, Paging);
    public new virtual Result<TContent> Clone(string? message) => Clone(Code, message, Errors, Content, Paging);
    public new virtual Result<TContent> Clone(string? message, IEnumerable<ValidationFailure>? errors) => Clone(Code, message, errors, Content, Paging);
    public virtual Result<TContent> Clone(string? message, TContent? content) => Clone(Code, message, Errors, content, Paging);
    public virtual Result<TContent> Clone(string? message, IEnumerable<ValidationFailure>? errors, TContent? content) => Clone(Code, message, errors, content, Paging);
    public virtual Result<TContent> Clone(string? message, TContent? content, Paging? paging) => Clone(Code, message, Errors, content, paging);
    public virtual Result<TContent> Clone(string? message, IEnumerable<ValidationFailure>? errors, TContent? content, Paging? paging) => Clone(Code, message, errors, content, paging);
    public virtual Result<TContent> Clone(TContent? content) => Clone(Code, Message, Errors, content, Paging);
    public virtual Result<TContent> Clone(IEnumerable<ValidationFailure>? errors, TContent? content) => Clone(Code, Message, errors, content, Paging);
    public virtual Result<TContent> Clone(TContent? content, Paging? paging) => Clone(Code, Message, Errors, content, paging);
    public virtual Result<TContent> Clone(IEnumerable<ValidationFailure>? errors, TContent? content, Paging? paging) => Clone(Code, Message, errors, content, paging);

    private static Result<TContent> Clone(string code, string? message, IEnumerable<ValidationFailure>? errors, TContent? content, Paging? paging)
    {
        return new Result<TContent>
               {
                   Code = code,
                   Message = message,
                   Errors = errors,
                   Content = content,
                   Paging = paging
               };
    }

    public TContent? Content { get; set; }
    public Paging? Paging { get; set; }
}
