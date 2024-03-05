using System.Security.Claims;

namespace Netcorext.Contracts;

public interface IContextState
{
    string? RequestId { get; set; }
    ClaimsPrincipal? User { get; set; }
    IDictionary<object, object?> Items { get; set; }
}
