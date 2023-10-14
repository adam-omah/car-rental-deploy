using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IClientData
    {
        Task<List<ClientModel>> GetClients();
        Task InsertClient(ClientModel client);
    }
}