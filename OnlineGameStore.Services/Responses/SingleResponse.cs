using OnlineGameStore.Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineGameStore.Services.Responses
{ 
    public class SingleResponse<TModel> : ISingleResponse<TModel> where TModel : new()
    {
        public SingleResponse()
        {
            Model = new TModel();
        }

        public string Message { get; set; }

        public bool ErrorOccured { get; set; }

        public string ErrorMessage { get; set; }

        public TModel Model { get; set; }
    }
}
