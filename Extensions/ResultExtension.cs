namespace Netcorext.Contracts;

public static class ResultExtension
{
    public static bool IsSuccess(this Result result) => result == Result.Ok ||
                                                        result == Result.Success ||
                                                        result == Result.SuccessCreated ||
                                                        result == Result.Accepted ||
                                                        result == Result.SuccessNoContent ||
                                                        result == Result.SuccessPartialContent;

    public static bool IsFailure(this Result result) => !result.IsSuccess();

    public static bool IsBadRequest(this Result result) => result == Result.InvalidInput ||
                                                           result == Result.BadRequest ||
                                                           result == Result.OutOfRangeInput;

    public static bool IsUnauthorized(this Result result) => result == Result.Unauthorized ||
                                                             result == Result.UnauthorizedAndCannotRefreshToken;

    public static bool IsForbidden(this Result result) => result == Result.Forbidden ||
                                                          result == Result.UsernameOrPasswordIncorrect ||
                                                          result == Result.AccountIsDisabled ||
                                                          result == Result.RequiredTwoFactorAuthentication ||
                                                          result == Result.TwoFactorAuthenticationFailed ||
                                                          result == Result.RequiredTwoFactorAuthenticationBinding ||
                                                          result == Result.RequiredChangePassword ||
                                                          result == Result.RequiredLogBackIn ||
                                                          result == Result.BlockedIp;

    public static bool IsNotFound(this Result result) => result == Result.NotFound ||
                                                         result == Result.DependencyNotFound;
}
