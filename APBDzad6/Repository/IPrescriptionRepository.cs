using APBDzad6.Model;

namespace APBDzad6.Repository
{
    public interface IPrescriptionRepository
    {
        public Task<int> AddPrescriptionAsync(Prescription prescription);
        public Task<IEnumerable<Prescription>> GetPrescriptionsByPatientsIdAsync(int patientId);
    }
}
