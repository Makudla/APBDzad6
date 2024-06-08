using APBDzad6.Models;

namespace APBDzad6.Repository
{
    public interface IDoctorRepository
    {
        public Task<Doctor> GetDoctorAsync(int id);
    }
}
