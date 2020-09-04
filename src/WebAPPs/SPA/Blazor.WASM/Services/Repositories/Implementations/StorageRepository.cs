using Blazor.Extensions.Storage.Interfaces;
using HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAPP.WebAPPs.SPA.Blazor.WASM.Services.Repositories.Implementations
{
    public class StorageRepository : IStorageRepository
    {
        private readonly ILocalStorage _localStorage;

        public StorageRepository(ILocalStorage localStorage)
        {
            _localStorage = localStorage;
        }

        public ValueTask Clear() => _localStorage.Clear();

        public ValueTask<TItem> GetItem<TItem>(string key) => _localStorage.GetItem<TItem>(key);

        public ValueTask<string> Key(int index) => _localStorage.Key(index);

        public ValueTask<int> Length() => _localStorage.Length();

        public ValueTask RemoveItem(string key) => _localStorage.RemoveItem(key);

        public ValueTask SetItem<TItem>(string key, TItem item) => _localStorage.SetItem(key, item);
    }
}
