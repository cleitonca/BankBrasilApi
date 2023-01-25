using BankBrasilApi.Dtos;
using BankBrasilApi.models;

namespace BankBrasilApi.interfaces
{
    public interface IBrasilApi
    {

        Task<ResponseGenerico<List<BancoModel>>> BuscarTodosBancos();

        Task<ResponseGenerico<BancoModel>> BuscarBanco(string codigoBanco);

    }
}
