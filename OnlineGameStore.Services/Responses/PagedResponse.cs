using OnlineGameStore.Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineGameStore.Services.Responses
{
    public class PagedResponse<TModel> : IPagedResponse<TModel>
    {
        public string Message { get; set; }

        public bool ErrorOccured { get; set; }

        public string ErrorMessage { get; set; }

        public IEnumerable<TModel> Model { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public int ItemsCount { get; set; }

        public double PageCount
            => ItemsCount < PageSize ? 1 : (int)(((double)ItemsCount / PageSize) + 1);
    }
}
