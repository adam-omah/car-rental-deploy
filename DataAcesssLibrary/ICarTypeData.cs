using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface ICarTypeData
    {
        Task<List<CarTypeModel>> GetCarTypes();
        Task InsertCarType(CarTypeModel carType);
    }
}