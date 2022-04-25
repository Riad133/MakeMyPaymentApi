using MakeMyPaymentApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MakeMyPaymentApi.INFRASTRUCTURE
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentDetail>().HasData(
                new PaymentDetail
                {
                    CardOwnerName ="ABC",
                    CardNumber ="235544555",
                    ExpirationDate ="12/30",
                    SecurityCode ="123"
                },
                new PaymentDetail
                {
                    CardOwnerName ="DEF",
                    CardNumber ="123635555",
                    ExpirationDate ="12/30",
                    SecurityCode ="123"
                }
            );
            
        }
    }
}