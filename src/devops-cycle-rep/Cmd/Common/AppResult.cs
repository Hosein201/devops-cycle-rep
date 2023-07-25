using System.Net;

namespace Cmd.Common
{
    public class AppResult
    {
        /// <summary>
        /// ok
        /// </summary>
        /// <returns></returns>
        public static Result Ok()
        {
            return new Result(true, HttpStatusCode.OK);
        }

        /// <summary>
        /// set data when every thing is ok
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Result Ok(object data)
        {
            return new Result(true, data, HttpStatusCode.OK);
        }

        /// <summary>
        /// set data when  isSuccess = true and error when is isSuccess = false
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="data"></param>
        /// <param name="httpStatus"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static Result OkIf(bool isSuccess, object data, HttpStatusCode httpStatus, params string[] error)
        {
            return isSuccess ? Ok(data) : Fail(httpStatus, error);
        }

        /// <summary>
        /// set data when  isSuccess = true and error when is isSuccess = false
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="data"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static Result OkIf(bool isSuccess, object data, params string[] error)
        {
            return isSuccess ? Ok(data) : Fail(HttpStatusCode.BadRequest, error);
        }

        /// <summary>
        /// set error when  isSuccess = false 
        /// </summary>
        /// <param name="isSuccess"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static Result OkIf(bool isSuccess, params string[] error)
        {
            return isSuccess ? Ok() : Fail(HttpStatusCode.BadRequest, error);
        }

        /// <summary>
        /// set error
        /// </summary>
        /// <param name="httpStatus"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public static Result Fail(HttpStatusCode httpStatus, params string[] error)
        {
            return new Result(false, httpStatus, error);
        }

        /// <summary>
        /// set error
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static Result Fail(params string[] error)
        {
            return new Result(false, HttpStatusCode.BadRequest, error);
        }
    }
}