using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAPP.Services.SharedBases.Abstractions.Request
{
    interface IRequestBase : IBase
    {
        DateTime? CreationDate { get; set; }
    }
}
