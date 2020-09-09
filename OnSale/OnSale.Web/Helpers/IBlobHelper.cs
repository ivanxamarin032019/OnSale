using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace OnSale.Web.Helpers
{
    //esta clase esta Sobrecargarda con 3 métodos
    public interface IBlobHelper
    {
        // La usamos desde la interface de usuario
        Task<Guid> UploadBlobAsync(IFormFile file, string containerName);

        // La usamos cuando usamos el API
        Task<Guid> UploadBlobAsync(byte[] file, string containerName);
        
        //Esta la usa el SeedDb
        Task<Guid> UploadBlobAsync(string image, string containerName);
    }
}
