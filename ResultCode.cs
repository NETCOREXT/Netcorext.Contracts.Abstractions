namespace Netcorext.Contracts.Abstractions;

public static class ResultCode
{
    public struct ResultBase
    {
        public string Code;
        public string Message;

        public static implicit operator string(ResultBase r)
        {
            return r.Code;
        }

        public static implicit operator ResultBase(string code)
        {
            return new ResultBase { Code = code };
        }

        public override string ToString()
        {
            return $"{Code}";
        }
    }

    public static readonly ResultBase Success = new() { Code = "200000", Message = "Success / Ok" };

    public static readonly ResultBase SuccessCreated = new() { Code = "201000", Message = "Success Created" };

    public static readonly ResultBase Accepted = new() { Code = "202000", Message = "The request has been accepted for processing, but the processing has not been completed." };

    public static readonly ResultBase SuccessNoContent = new() { Code = "204000", Message = "Success No Content" };

    public static readonly ResultBase SuccessPartialContent = new() { Code = "206000", Message = "The server has successfully processed some GET requests." };

    public static readonly ResultBase InvalidInput = new() { Code = "400000", Message = "Bad Request (400) - One of the request inputs is not valid." };

    public static readonly ResultBase OutOfRangeInput = new() { Code = "400001", Message = "Bad Request (400) - One of the request inputs is out of range." };

    public static readonly ResultBase Unauthorized = new() { Code = "401000", Message = "Unauthorized (401)" };

    public static readonly ResultBase PaymentRequired = new() { Code = "402000", Message = "Payment Required (402)" };

    public static readonly ResultBase Forbidden = new() { Code = "403000", Message = "Forbidden." };

    public static readonly ResultBase UsernameOrPasswordIncorrect = new() { Code = "403001", Message = "Username or Password is incorrect." };

    public static readonly ResultBase AccountIsDisabled = new() { Code = "403002", Message = "The specified account is disabled." };

    public static readonly ResultBase RequiredTwoFactorAuthentication = new() { Code = "403003", Message = "Two-factor authentication is required." };

    public static readonly ResultBase TwoFactorAuthenticationFailed = new() { Code = "403004", Message = "Two-factor authentication failed." };

    public static readonly ResultBase RequiredTwoFactorAuthenticationBinding = new() { Code = "403005", Message = "Two-factor authentication binding is required" };

    public static readonly ResultBase ChangePasswordRequired = new() { Code = "403006", Message = "Required to change your password" };

    public static readonly ResultBase NotFound = new() { Code = "404000", Message = "The specified resource does not exist." };

    public static readonly ResultBase DependencyNotFound = new() { Code = "404001", Message = "The specified resource dependency does not exist." };

    public static readonly ResultBase NotAcceptable = new() { Code = "406000", Message = "This resource can not acceptable to operated." };

    public static readonly ResultBase RequestTimeout = new() { Code = "408000", Message = "This request takes too long to process." };

    public static readonly ResultBase Conflict = new() { Code = "409000", Message = "Conflict (409) - The specified resource already exists." };

    public static readonly ResultBase PayloadTooLarge = new() { Code = "413000", Message = "Request body too large." };

    public static readonly ResultBase InternalServerError = new() { Code = "500000", Message = "Internal Server Error" };
}