using APBDzad6.Models;

namespace APBDzad6.Repository
{
    public class MedicamentRepository(Context context) : IMedicamentRepository
    {
        public async Task<Medicament> GetMedicamentAsync(int id)
        {
            return (await context.Medicaments.FindAsync(id))!;
        }
    }
}
