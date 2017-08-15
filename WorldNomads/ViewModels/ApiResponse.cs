namespace WorldNomads.ViewModels
{
    public class ApiResponse<T>
    {
        public ApiResponse(T data)
        {
            Data = data;
            IsSuccess = true;
        }

        public ApiResponse(string errorMessage)
        {
            IsSuccess = false;
            ErrorErrorMessage = errorMessage;
        }
        public T Data { get; set; }

        public bool IsSuccess { get; set; }

        public string ErrorErrorMessage { get; set; }

    }
}