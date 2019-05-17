using System;
using System.Collections.Generic;
using System.Text;
using OnlineGameStore.Services.Interfaces.Responses;
using OnlineGameStore.Services.Exceptions;

namespace OnlineGameStore.Services.Responses
{
    public static class ResponseExtensions
    {
        public static void SetError(this IResponse response, string actionName, Exception ex)
        {

            response.ErrorOccured = true;

            if (ex is OnlineGameStoreException cast)
            {
                response.ErrorMessage = ex.Message;
            }
            else  {
               response.ErrorMessage = "There was an internal error, please contact to technical support.";
            }
        }
    }
}
