namespace OnlineGameStore.Services.Interfaces.Responses
{
    public interface IPagedResponse<TModel> : IListResponse<TModel>
    {
        int ItemsCount { get; set; }

        double PageCount { get; }
    }
}