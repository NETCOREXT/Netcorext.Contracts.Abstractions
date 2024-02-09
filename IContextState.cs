using System.Security.Claims;

namespace Netcorext.Contracts;

public interface IContextState
{
    ClaimsPrincipal? User { get; set; }
    IDictionary<object, object?>? Items { get; set; }
}
