using Microsoft.AspNetCore.Mvc;
using ProjetoLead.CepConsult;
using Refit;

namespace ProjetoLead.Interfaces
{
    public interface ICepApi
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetResponseAsync(string cep);
    }
}
