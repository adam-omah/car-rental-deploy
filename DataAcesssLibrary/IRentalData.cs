using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IRentalData
    {
        public Task<List<RentalModel>> GetRentals();
        Task InsertRental(RentalModel rental);
    }
}