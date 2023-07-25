using System.Net;

namespace Cmd.Common
{
    public class Result<T>
    {
        public Result(bool isSuccess, T? data, HttpStatusCode statusCode, params string[] error)
        {
            IsSuccess = isSuccess;
            Data = data;
            Error = error;
            StatusCode = statusCode;
        }

        public Result(bool isSuccess, HttpStatusCode statusCode, params string[] error)
        {
            IsSuccess = isSuccess;
            Error = error;
            StatusCode = statusCode;
        }

        public Result(bool isSuccess, T? data, HttpStatusCode statusCode)
        {
            IsSuccess = isSuccess;
            Data = data;
            StatusCode = statusCode;
        }

        public Result(bool isSuccess, HttpStatusCode statusCode)
        {
            IsSuccess = isSuccess;
            StatusCode = statusCode;
        }

        public Result(bool isSuccess, params string[] error)
        {
            IsSuccess = isSuccess;
            Error = error;
        }

        public Result()
        {
        }

        public string[] Error { get; set; }

        public T? Data { get; set; }

        public bool IsSuccess { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }

    public class Result : Result<object>
    {
        public Result()
        {
        }

        public Result(bool isSuccess, HttpStatusCode statusCode) : base(isSuccess, statusCode)
        {
        }

        public Result(bool isSuccess, params string[] error) : base(isSuccess, error)
        {
        }

        public Result(bool isSuccess, HttpStatusCode statusCode, params string[] error) : base(isSuccess, statusCode, error)
        {
        }

        public Result(bool isSuccess, object? data, HttpStatusCode statusCode) : base(isSuccess, data, statusCode)
        {
        }

        public Result(bool isSuccess, object? data, HttpStatusCode statusCode, params string[] error) : base(isSuccess, data, statusCode, error)
        {
        }
    }
}