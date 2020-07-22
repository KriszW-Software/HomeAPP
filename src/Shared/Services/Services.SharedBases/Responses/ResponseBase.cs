using HomeAPP.Services.SharedBases.Abstractions.Response;
using HomeAPP.Services.SharedBases.Error;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeAPP.Services.SharedBases.Responses
{
    public class APIResponseBase : IResponseBase
    {
        public APIResponseBase() : this(true, default, Guid.NewGuid()) { }
        public APIResponseBase(APIError errors) : this(false, errors, Guid.NewGuid()) { }
        public APIResponseBase(APIError errors, bool success = false) : this(success, errors, Guid.NewGuid()) { }

        [JsonConstructor]
        public APIResponseBase(bool success, APIError errors, Guid iD)
        {
            Success = success;
            ID = iD;
            Errors = errors;
        }

        public bool Success { get; set; }
        public APIError Errors { get; set; }
        public Guid ID { get; set; }
    }
}
