using DataAcesssLibrary.Models;

namespace DataAcesssLibrary
{
    public interface ICarData
    {
        Task<List<CarModel>> GetCars();
        Task InsertCar(CarModel car);
    }
}