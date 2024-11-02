using CustomerEvidenceApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CustomerEvidenceApp.Data.Configurations
{
    public class CustomerConfiguration: IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("customers");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();

            builder.Property(c => c.FullName)
                .HasColumnName("full_name")
                .IsRequired();

            builder.Property(c => c.Birthday)
                .HasColumnName("date_of_birth")
                .IsRequired();

            builder.Property(c => c.IQ)
                .HasColumnName("iq");

            builder.Property(c => c.Gender)
                .HasColumnName("gender")
                .IsRequired();

            builder.Property(c => c.GdprAgreement)
                .HasColumnName("gdpr_agreement")
                .IsRequired();
        }
    }
}
