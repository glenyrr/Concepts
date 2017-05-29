using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace Aspnet.Core.RestClient
{
    public class HttpClientRequest : IHttpClientRequest
    {
        public void Dispose()
        {
            
        }

        public async Task<IEnumerable<TEntity>> GetList<TEntity>(string uri) where TEntity : class
        {
            List<TEntity> result = null;
            var client = new System.Net.Http.HttpClient
            {
                BaseAddress = new Uri(uri)
            };

            client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/json"));

            var settings = new DataContractJsonSerializerSettings
            {
                DateTimeFormat = new System.Runtime.Serialization.DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            };

            var response = await client.GetAsync("");
            var stream = await response.Content.ReadAsStreamAsync();
            var serializer = new DataContractJsonSerializer(typeof(List<TEntity>), settings);
            result = (List<TEntity>)serializer.ReadObject(stream);
            return result;
        }

        public async Task<TEntity> Get<TEntity>(string uri) where TEntity : class
        {
            TEntity result;
            var client = new System.Net.Http.HttpClient
            {
                BaseAddress = new Uri(uri)
            };

            client.DefaultRequestHeaders.Accept.Add(
                 new MediaTypeWithQualityHeaderValue("application/json"));

            var settings = new DataContractJsonSerializerSettings
            {
                DateTimeFormat = new System.Runtime.Serialization.DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
            };

            var response = await client.GetAsync("");
            var stream = await response.Content.ReadAsStreamAsync();
            var serializer = new DataContractJsonSerializer(typeof(TEntity), settings);
            result = (TEntity)serializer.ReadObject(stream);
            return result;
        }
    }
}
