using HomeAPP.Services.SharedBases.Abstractions.Request;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAPP.Services.SharedBases.Requests
{
    public class APIRequest<TModel> : APIRequestBase, IRequest<TModel>

    {
        public APIRequest() { }

        public APIRequest(TModel model) : base()
        {
            Model = model;
        }

        [JsonConstructor]
        public APIRequest(DateTime creationDate, Guid iD, TModel model) : base(creationDate, iD)
        {
            Model = model;
        }

        public TModel Model { get; set; }
    }
}
