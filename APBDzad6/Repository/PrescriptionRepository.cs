using Microsoft.EntityFrameworkCore;
using APBDzad6.Model;
using APBDzad6.Models;

namespace APBDzad6.Repository
{
    public class PrescriptionRepository(Context context) : IPrescriptionRepository
    {
        public async Task<int> AddPrescriptionAsync(Prescription prescription)
        {
            await context.Prescriptions.AddAsync(prescription);
            await context.SaveChangesAsync();
            return prescription.IdPrescription;
        }

        public async Task<IEnumerable<Prescription>> GetPrescriptionsByPatientsIdAsync(int patientId)
        {
            return await context.Prescriptions.Where(p => p.IdPatient == patientId)
                .Include(p => p.PrescriptionMedicaments)
                .ThenInclude(pm => pm.IdMedicamentNav)
                .ToListAsync();
        }
    }
}
