using ApiNewsVBlazor.Models;

namespace ApiNewsVBlazor
{
    public interface INewsService
    {
        public Task<APIResponse> ObtenerNoticias(string categoria, string pais);
    }
}
