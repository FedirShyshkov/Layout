using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineGameStore.Services.Exceptions
{
    public class OnlineGameStoreException:Exception
    {
        public OnlineGameStoreException()
            :base()
        {

        }
        public OnlineGameStoreException(string message)
            : base(message)
        {

        }
    }
}
