using HomeAPP.Services.SharedBases.Abstractions;

namespace HomeAPP.Services.SharedBases.Abstractions.Response
{
    internal interface IResponse<TModel> : IServiceBase<TModel>, IResponseBase

    {
    }
}