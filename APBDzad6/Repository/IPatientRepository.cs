using APBDzad6.Models;

namespace APBDzad6.Repository
{
    public interface IPatientRepository
    {
        public Task<Patient> GetPatientAsync(int id);
        public Task<int> AddPatientAsync(Patient patient);
    }
}
