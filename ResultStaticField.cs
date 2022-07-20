namespace Netcorext.Contracts;

public partial class Result
{
    #region Static Fields

    public static readonly Result Success = new() { Code = "200000", Message = "Success / Ok" };

    public static readonly Result SuccessCreated = new() { Code = "201000", Message = "Success Created" };

    public static readonly Result Accepted = new() { Code = "202000", Message = "The request has been accepted for processing, but the processing has not been completed." };

    public static readonly Result SuccessNoContent = new() { Code = "204000", Message = "Success No Content" };

    public static readonly Result SuccessPartialContent = new() { Code = "206000", Message = "The server has successfully processed some GET requests." };

    public static readonly Result InvalidInput = new() { Code = "400000", Message = "Bad Request - One of the request inputs is not valid." };

    public static readonly Result OutOfRangeInput = new() { Code = "400001", Message = "Bad Request - One of the request inputs is out of range." };

    public static readonly Result Unauthorized = new() { Code = "401000", Message = "Unauthorized" };

    public static readonly Result PaymentRequired = new() { Code = "402000", Message = "Payment Required" };

    public static readonly Result InsufficientBalance = new() { Code = "402001", Message = "Account does not have a sufficient balance available." };

    public static readonly Result Forbidden = new() { Code = "403000", Message = "Forbidden." };

    public static readonly Result UsernameOrPasswordIncorrect = new() { Code = "403001", Message = "Username or Password is incorrect." };

    public static readonly Result AccountIsDisabled = new() { Code = "403002", Message = "The specified account is disabled." };

    public static readonly Result RequiredTwoFactorAuthentication = new() { Code = "403003", Message = "Two-factor authentication is required." };

    public static readonly Result TwoFactorAuthenticationFailed = new() { Code = "403004", Message = "Two-factor authentication failed." };

    public static readonly Result RequiredTwoFactorAuthenticationBinding = new() { Code = "403005", Message = "Two-factor authentication binding is required" };

    public static readonly Result ChangePasswordRequired = new() { Code = "403006", Message = "Required to change your password" };

    public static readonly Result NotFound = new() { Code = "404000", Message = "The specified resource does not exist." };

    public static readonly Result DependencyNotFound = new() { Code = "404001", Message = "The specified resource dependency does not exist." };

    public static readonly Result NotAcceptable = new() { Code = "406000", Message = "This resource can not acceptable to operated." };

    public static readonly Result RequestTimeout = new() { Code = "408000", Message = "This request takes too long to process." };

    public static readonly Result Conflict = new() { Code = "409000", Message = "Conflict - The specified resource already exists." };

    public static readonly Result PayloadTooLarge = new() { Code = "413000", Message = "Request body too large." };

    public static readonly Result Locked = new() { Code = "423000", Message = "The resource that is being accessed is locked." };

    public static readonly Result InternalServerError = new() { Code = "500000", Message = "Internal Server Error" };

    #endregion
}

public partial class Result<TContent>
{
    #region Static Fields

    public new static readonly Result<TContent> Success = new() { Code = "200000", Message = "Success / Ok" };

    public new static readonly Result<TContent> SuccessCreated = new() { Code = "201000", Message = "Success Created" };

    public new static readonly Result<TContent> Accepted = new() { Code = "202000", Message = "The request has been accepted for processing, but the processing has not been completed." };

    public new static readonly Result<TContent> SuccessNoContent = new() { Code = "204000", Message = "Success No Content" };

    public new static readonly Result<TContent> SuccessPartialContent = new() { Code = "206000", Message = "The server has successfully processed some GET requests." };

    public new static readonly Result<TContent> InvalidInput = new() { Code = "400000", Message = "Bad Request (400) - One of the request inputs is not valid." };

    public new static readonly Result<TContent> OutOfRangeInput = new() { Code = "400001", Message = "Bad Request (400) - One of the request inputs is out of range." };

    public new static readonly Result<TContent> Unauthorized = new() { Code = "401000", Message = "Unauthorized (401)" };

    public new static readonly Result<TContent> PaymentRequired = new() { Code = "402000", Message = "Payment Required (402)" };
    
    public new static readonly Result<TContent> InsufficientBalance = new() { Code = "402001", Message = "Account does not have a sufficient balance available." };

    public new static readonly Result<TContent> Forbidden = new() { Code = "403000", Message = "Forbidden." };

    public new static readonly Result<TContent> UsernameOrPasswordIncorrect = new() { Code = "403001", Message = "Username or Password is incorrect." };

    public new static readonly Result<TContent> AccountIsDisabled = new() { Code = "403002", Message = "The specified account is disabled." };

    public new static readonly Result<TContent> RequiredTwoFactorAuthentication = new() { Code = "403003", Message = "Two-factor authentication is required." };

    public new static readonly Result<TContent> TwoFactorAuthenticationFailed = new() { Code = "403004", Message = "Two-factor authentication failed." };

    public new static readonly Result<TContent> RequiredTwoFactorAuthenticationBinding = new() { Code = "403005", Message = "Two-factor authentication binding is required" };

    public new static readonly Result<TContent> ChangePasswordRequired = new() { Code = "403006", Message = "Required to change your password" };

    public new static readonly Result<TContent> NotFound = new() { Code = "404000", Message = "The specified resource does not exist." };

    public new static readonly Result<TContent> DependencyNotFound = new() { Code = "404001", Message = "The specified resource dependency does not exist." };

    public new static readonly Result<TContent> NotAcceptable = new() { Code = "406000", Message = "This resource can not acceptable to operated." };

    public new static readonly Result<TContent> RequestTimeout = new() { Code = "408000", Message = "This request takes too long to process." };

    public new static readonly Result<TContent> Conflict = new() { Code = "409000", Message = "Conflict (409) - The specified resource already exists." };

    public new static readonly Result<TContent> PayloadTooLarge = new() { Code = "413000", Message = "Request body too large." };

    public new static readonly Result<TContent> Locked = new() { Code = "423000", Message = "The resource that is being accessed is locked." };

    public new static readonly Result<TContent> InternalServerError = new() { Code = "500000", Message = "Internal Server Error" };

    #endregion
}