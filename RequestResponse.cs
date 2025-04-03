namespace RequestResponseAPI
{
    public class RequestResponse<T>
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; } = string.Empty;
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;

        public T? Result { get; set; }

        public RequestResponse(bool isSuccessful, string message, bool isError, string errorMessage, T? result = default)
        {
            IsSuccessful = isSuccessful;
            Message = message;
            IsError = isError;
            ErrorMessage = errorMessage;
            Result = result;
        }

        public static RequestResponse<T> CreateSuccessful(T result)
        {
            return new RequestResponse<T>(true, string.Empty, false, string.Empty, result);
        }

        public static RequestResponse<T> CreateSuccessful(T result, string message)
        {
            return new RequestResponse<T>(true, message, false, string.Empty, result);
        }

        public static RequestResponse<T> CreateUnSuccessful(string message)
        {
            return new RequestResponse<T>(false, message, false, string.Empty);
        }

        public static RequestResponse<T> CreateError(string errorMessage)
        {
            return new RequestResponse<T>(false, string.Empty, true, errorMessage);
        }

    }
}

