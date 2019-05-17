using System.Collections.Generic;

namespace OnlineGameStore.Services.Interfaces.Responses
{
    public interface IListResponse<TModel> : IResponse
    {
        IEnumerable<TModel> Model { get; set; }
    }
}