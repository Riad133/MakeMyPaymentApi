using MakeMyPaymentApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MakeMyPaymentApi.INFRASTRUCTURE
{
    public class PaymentDetailContext: DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options):base(options)
        { }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}