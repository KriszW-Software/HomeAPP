using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAPP.Services.SharedBases.Error
{
    public class APIErrorDataModel
    {
        public APIErrorDataModel() : this(default, default) { }

        public APIErrorDataModel(string msg) : this(default, msg) { }

        [JsonConstructor]
        public APIErrorDataModel(string fieldName, string errorMSG)
        {
            FieldName = fieldName;
            ErrorMSG = errorMSG;
        }

        public string FieldName { get; set; }

        public string ErrorMSG { get; set; }
    }
}
