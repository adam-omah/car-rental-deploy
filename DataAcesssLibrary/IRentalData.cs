using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    internal interface IRentalData
    {
        Task<List<RentalModel>> GetRentals();
        Task InsertRental(RentalModel rental);
    }
}