using HomeAPP.Services.SharedBases.Abstractions.Response;
using HomeAPP.Services.SharedBases.Error;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAPP.Services.SharedBases.Responses
{
    public class APIResponse<TModel> : APIResponseBase, IResponse<TModel>
    {
        public APIResponse() { }
        /// <summary>
        /// Success will be false, and the Model will be default
        /// </summary>
        /// <param name="errors"></param>
        public APIResponse(APIError errors) : this(false, errors, Guid.NewGuid(), default) { }

        public APIResponse(string msg) : this(false, new APIError(msg), Guid.NewGuid(), default) { }
        /// <summary>
        /// Success will be true, and errors will be empty
        /// </summary>
        public APIResponse(TModel model)
        {
            Model = model;
        }

        /// <summary>
        /// Success will be false
        /// </summary>
        public APIResponse(APIError errors, TModel model) : base(errors)
        {
            Model = model;
        }

        public APIResponse(APIError errors, TModel model, bool success = false) : base(errors, success)
        {
            Model = model;
        }


        [JsonConstructor]
        public APIResponse(bool success, APIError errors, Guid iD, TModel model) : base(success, errors, iD)
        {
            Model = model;
        }

        public TModel Model { get; set; }
    }
}
