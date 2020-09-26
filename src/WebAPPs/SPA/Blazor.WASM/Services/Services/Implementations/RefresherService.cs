using HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Services.Implementations
{
    public class RefresherService : IRefresherService
    {
        public event Action RefreshRequested;

        public void CallRequestRefresh()
        {
            if (RefreshRequested != default) RefreshRequested.Invoke();
            else throw new NullReferenceException($"The event handler of {nameof(RefreshRequested)} event is null");
        }
    }
}
