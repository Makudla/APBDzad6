using APBDzad6.Models;

namespace APBDzad6.Repository
{
    public interface IMedicamentRepository
    {
        public Task<Medicament> GetMedicamentAsync(int id);
    }
}
