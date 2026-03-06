using LINQ.Day3.Models;
using LINQ.Day3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LINQ.Day3.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        void IEntityTypeConfiguration<Book>.Configure(EntityTypeBuilder<Book> builder)
        {
            // Title → Required, Max Length 150
            builder.Property(b => b.Title)
                   .IsRequired()
                   .HasMaxLength(150);

            // Price → Column Type decimal(8,2)
            builder.Property(b => b.Price)
                   .HasColumnType("decimal(8,2)");

            // PublishedDate → Explicitly Optional
            builder.Property(b => b.PublishedDate)
                   .IsRequired(false);
        }
    }
}
