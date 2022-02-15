using Model.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Model.Fluent
{
    public class UserPolicyConfig : IEntityTypeConfiguration<UserPolicy>
    {
        public void Configure(EntityTypeBuilder<UserPolicy> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Id);

            builder.HasOne(x=>x.User)
                .WithMany(x=>x.UserPolicies)
                .HasForeignKey(x => x.UserId);
        }
    }

}
