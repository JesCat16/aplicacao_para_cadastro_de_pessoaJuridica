using ProjetoLead.Interfaces;
using ProjetoLead.CepConsult;
using Refit;

namespace ProjetoLead.CepConsult
{
    public class CepConsult
    {
        public static async Task<CepResponse> FindAddress(string cep)
        {
            try
            {
                var cepFinder = RestService.For<ICepApi>("https://viacep.com.br");
                return await cepFinder.GetResponseAsync(cep);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
