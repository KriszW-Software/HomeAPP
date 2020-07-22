using HomeAPP.Services.SharedBases.Abstractions;
using HomeAPP.Services.SharedBases.Error;
using System;

namespace HomeAPP.Services.SharedBases.Abstractions.Response
{
    internal interface IResponseBase : IBase
    {
        bool Success { get; set; }

        APIError Errors { get; set; }
    }
}