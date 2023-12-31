﻿using DataAccessLibrary.Models;
using DataAccessLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class ClientData : IClientData
    {
        private readonly ISqlDataAccess _db;

        public ClientData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ClientModel>> GetClients()
        {
            string sql = "select * from dbo.Clients";

            return _db.LoadData<ClientModel, dynamic>(sql, new { });
        }

        public Task InsertClient(ClientModel client)
        {
            string sql = @"insert into dbo.Clients (Name, Phone, Email, Password, LicenceType,Company)
                            values (@Name,@Phone,@Email,@Password,@LicenceType,@Company);";

            return _db.SaveData(sql, client);
        }
        public async Task<bool> CheckCredentials(string email, string password)
        {
            string sql = "SELECT COUNT(*) FROM dbo.Clients WHERE Email = @Email AND Password = @Password";

            var parameters = new { Email = email, Password = password };

            var matchingClients = await _db.LoadData<ClientModel, dynamic>(sql, parameters);

            return matchingClients.Count > 0;
        }
    }

}
