using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace HomeAPP.Shared.Extensions.HttpMessageConverter.JSON
{
    public static class HttpResponseMessageExtensions
    {
        public static async Task<T> DeserializeJsonAsync<T>(this HttpResponseMessage message)
            where T : class
        {
            var text = await message.Content.ReadAsStringAsync();

            if (text == default)
            {
                return default;
            }

            return JsonConvert.DeserializeObject<T>(text);
        }
    }
}
