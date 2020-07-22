using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAPP.Services.SharedBases.Error
{
    public class APIError
    {
        public APIError() : this(default(IEnumerable<APIErrorDataModel>)) { }

        public APIError(string msg) : this(new List<APIErrorDataModel>() { new APIErrorDataModel(msg) }) { }

        public APIError(string fieldName, string msg) : this(new List<APIErrorDataModel>() { new APIErrorDataModel(fieldName, msg) }) { }

        [JsonConstructor]
        public APIError(IEnumerable<APIErrorDataModel> errors)
        {
            Errors = errors;
        }

        public IEnumerable<APIErrorDataModel> Errors { get; set; }
    }
}
