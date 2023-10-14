using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface ICarData
    {
        Task<List<CarModel>> GetCars();
        Task InsertCar(CarModel car);
    }
}