using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAPP.Services.SharedBases.Abstractions.Request
{
    interface IRequest<TModel> : IServiceBase<TModel>, IRequestBase

    {
    }
}
