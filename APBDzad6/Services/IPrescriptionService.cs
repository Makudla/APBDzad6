using APBDzad6.DTOs.Request;

namespace APBDzad6.Services
{
    public interface IPrescriptionService
    {
        public Task<int> AddPrescriptionAsync(PrescriptionCreateDTO request);
    }
}
