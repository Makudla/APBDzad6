using APBDzad6.DTOs.Request;
using APBDzad6.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBDzad6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrescriptionController(IPrescriptionService prescriptionService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddPrescription([FromBody] PrescriptionCreateDTO request)
        {
            try
            {
                await prescriptionService.AddPrescriptionAsync(request);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
