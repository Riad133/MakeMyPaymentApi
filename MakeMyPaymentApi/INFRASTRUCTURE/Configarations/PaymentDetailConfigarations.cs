using MakeMyPaymentApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MakeMyPaymentApi.INFRASTRUCTURE.Configarations
{
    public class PaymentDetailConfigarations: IEntityTypeConfiguration<PaymentDetail>
    {
        public void Configure(EntityTypeBuilder<PaymentDetail> b)
        {
            b.HasKey(x => x.PaymentDetailId);
            b.Property(x => x.CardOwnerName).IsRequired();
            b.Property(x => x.CardNumber).IsRequired();
            b.Property(x => x.ExpirationDate).IsRequired();
            b.Property(x => x.SecurityCode).IsRequired();
            b.HasData(
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