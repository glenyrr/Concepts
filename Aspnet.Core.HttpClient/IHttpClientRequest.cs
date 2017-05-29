using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Aspnet.Core.RestClient
{
    public interface IHttpClientRequest : IDisposable
    {
        Task<IEnumerable<TEntity>> GetList<TEntity>(string uri) where TEntity : class;
        Task<TEntity> Get<TEntity>(string uri) where TEntity : class;
    }
}
