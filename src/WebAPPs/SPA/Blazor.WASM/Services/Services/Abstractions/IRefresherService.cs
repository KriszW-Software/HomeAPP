using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Services.Abstractions
{
    public interface IRefresherService
    {
        event Action RefreshRequested;
        void CallRequestRefresh();
    }
}
