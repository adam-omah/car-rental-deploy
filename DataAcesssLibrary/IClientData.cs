﻿using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IClientData
    {
        Task<List<ClientModel>> GetClients();
        Task InsertClient(ClientModel client);
        Task<bool> CheckCredentials(string username, string password);
    }
}