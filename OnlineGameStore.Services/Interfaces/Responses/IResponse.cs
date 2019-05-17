namespace OnlineGameStore.Services.Interfaces.Responses
{
    public interface IResponse
    {
        string Message { get; set; }

        bool ErrorOccured { get; set; }

        string ErrorMessage { get; set; }
    }
}