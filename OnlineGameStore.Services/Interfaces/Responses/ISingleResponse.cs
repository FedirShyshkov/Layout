namespace OnlineGameStore.Services.Interfaces.Responses
{
    public interface ISingleResponse<TModel> : IResponse
    {
        TModel Model { get; set; }
    }
}