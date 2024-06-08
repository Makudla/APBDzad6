using APBDzad6.Models;

namespace APBDzad6.Repository
{
    public class DoctorRepository(Context context) : IDoctorRepository
    {
        public async Task<Doctor> GetDoctorAsync(int id)
        {
            return (await context.Doctors.FindAsync(id))!;
        }
    }
}