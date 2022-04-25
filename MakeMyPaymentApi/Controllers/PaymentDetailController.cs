using System.Collections.Generic;
using System.Threading.Tasks;
using MakeMyPaymentApi.INFRASTRUCTURE;
using MakeMyPaymentApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MakeMyPaymentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly PaymentDetailContext _context;

        public PaymentDetailController(PaymentDetailContext context)
        {
            _context = context;
        }
        // GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDetail>>> GetPaymentDetails()
        {
            return  await _context.PaymentDetails.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentDetail>> GetPaymentDetail(int id)
        {
            var data= await _context.PaymentDetails.FirstOrDefaultAsync(x => x.PaymentDetailId == id);
            if (data == null)
            {
                return NotFound();
            }

            return data;
        }

        [HttpPost]
        public async Task<ActionResult<PaymentDetail>> PostPaymentDetail([FromBody]PaymentDetail paymentDetail)
        {
             _context.PaymentDetails.Add(paymentDetail);
             await _context.SaveChangesAsync();
             return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaymentDetail(int id,[FromBody] PaymentDetail paymentDetail)
        {
            var data = await _context.PaymentDetails.FirstOrDefaultAsync(x => x.PaymentDetailId == id);
            if (data == null)
            {
                  return NotFound();
            }

            _context.PaymentDetails.Update(paymentDetail);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PaymentDetail>> DeletePaymentDetail(int id)
        {
            var data = await _context.PaymentDetails.FirstOrDefaultAsync(x => x.PaymentDetailId == id);
            if (data == null)
            {
                return NotFound();
            }

            _context.PaymentDetails.Remove(data);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}