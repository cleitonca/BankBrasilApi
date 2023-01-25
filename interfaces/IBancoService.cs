using BankBrasilApi.Dtos;

namespace BankBrasilApi.interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenerico<List<BancoResponse>>> BuscarTodos();

        Task<ResponseGenerico<BancoResponse>> BuscarBanco(string codigoBanco);


    }
}
