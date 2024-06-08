using APBDzad6.DTOs.Response;
namespace APBDzad6.Services
{
    public interface IPatientService
    {
        public Task<PatientQueryDTO> GetPatientAsync(int id);
    }
}
