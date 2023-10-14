using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CarData : ICarData
    {
        private readonly ISqlDataAccess _db;

        public CarData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<CarModel>> GetCars()
        {
            string sql = "select * from dbo.Cars";

            return _db.LoadData<CarModel, dynamic>(sql, new { });
        }

        public Task InsertCar(CarModel car)
        {
            string sql = @"insert into dbo.Cars (Registration, FuelType, CostPerDay)
                            values (@Registration, @FuelType, @CostPerDay);";

            return _db.SaveData(sql, car);
        }
    }
}
