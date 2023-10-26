using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    internal class RentalData : IRentalData
    {

        private readonly ISqlDataAccess _db;

        public RentalData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<RentalModel>> GetRentals()
        {
            string sql = "select * from dbo.Rentals";

            return _db.LoadData<RentalModel, dynamic>(sql, new { });
        }

        public Task InsertRental(RentalModel rental)
        {
            string sql = @"insert into dbo.Cars (StartDate, EndDate, PickUpDate, ReturnDate, Status, CarRegistration, Client_ID)
                            values (@StartDate,@EndDate,@PickUpDate,@ReturnDate,@Status,@CarRegistration,@Client_ID);";

            return _db.SaveData(sql, rental);
        }
    }
}
