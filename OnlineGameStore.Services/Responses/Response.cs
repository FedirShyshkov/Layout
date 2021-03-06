﻿using OnlineGameStore.Services.Interfaces.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineGameStore.Services.Responses
{
    public class Response : IResponse
    {
        public string Message { get; set; }
        public bool ErrorOccured { get; set; }
        public string ErrorMessage { get; set; }      
    }
}
