using ApoliceSegfy.Api.Data.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApoliceSegfy.Api.Data.Configuration
{
    public class PolicyConfiguration : IEntityTypeConfiguration<Policy>
    {
        public void Configure(EntityTypeBuilder<Policy> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();
            builder.Property(x => x.Document)
                .HasColumnType("varchar(14)")
                .HasMaxLength(14);
            builder.Property(x => x.Board)
                .HasColumnType("varchar(8)")
                .HasMaxLength(8);
        }
    }
}