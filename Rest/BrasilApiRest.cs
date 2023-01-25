using BankBrasilApi.Dtos;
using BankBrasilApi.interfaces;
using BankBrasilApi.models;
using System.Text.Json;

namespace BankBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, "https://brasilapi.com.br/api/banks/v1");

            var response = new ResponseGenerico<List<BancoModel>>();

            using (var httpClient = new HttpClient())
            {
                var responseBrasilApi = await httpClient.SendAsync(request);

                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();

                var objResponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {

                }
            }

            return response;
        }

        public async Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");

            var response = new ResponseGenerico<BancoModel>();

            using (var httpClient = new HttpClient())
            {
                var responseBrasilApi = await httpClient.SendAsync(request);

                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();

                var objResponse = JsonSerializer.Deserialize<BancoModel>(contentResp);

                if (responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {

                }
            }

            return response;
        }

       
    }
}
