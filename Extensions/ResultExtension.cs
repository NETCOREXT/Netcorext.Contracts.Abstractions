namespace Netcorext.Contracts;

public static class ResultExtension
{
    public static bool IsSuccess(this Result result) => result == Result.Ok ||
                                                        result == Result.Success ||
                                                        result == Result.SuccessCreated ||
                                                        result == Result.Accepted ||
                                                        result == Result.SuccessNoContent ||
                                                        result == Result.SuccessPartialContent;
}
