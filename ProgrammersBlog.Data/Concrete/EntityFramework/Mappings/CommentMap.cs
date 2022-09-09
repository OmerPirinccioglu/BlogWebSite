using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Text).IsRequired();
            builder.Property(c => c.Text).HasMaxLength(1000);
            builder.HasOne<Article>(c => c.Article).WithMany(a => a.Comments).HasForeignKey(c => c.ArticleId);
            builder.Property(c => c.CreatedByName).IsRequired();
            builder.Property(c => c.CreatedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).HasMaxLength(50);
            builder.Property(c => c.ModifiedByName).IsRequired();
            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.ModifiedDate).IsRequired();
            builder.Property(c => c.IsActive).IsRequired();
            builder.Property(c => c.IsDeleted).IsRequired();
            builder.Property(c => c.Note).HasMaxLength(500);
            builder.ToTable("Comments");

            //builder.HasData(
            //    new Comment
            //    {
            //        Id = 1,
            //        ArticleId = 1,
            //        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc a tincidunt ligula, ut venenatis urna. Praesent libero ex, iaculis a feugiat nec, tempus quis felis. Maecenas eget urna a mauris euismod tristique. Integer feugiat arcu non dolor interdum gravida. Proin sollicitudin velit ac urna dictum lacinia nec quis ex. Donec at efficitur ex, eget efficitur lorem. Nam et justo eget libero lobortis accumsan. Nunc et mi iaculis, aliquam metus sed, ullamcorper nibh. Integer volutpat malesuada molestie. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Vestibulum at consectetur purus, at placerat felis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "InitialCreate",
            //        ModifiedDate = DateTime.Now,
            //        Note = "C# Makale Yorumu",
            //    },
            //    new Comment
            //    {
            //        Id = 2,
            //        ArticleId = 2,
            //        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc a tincidunt ligula, ut venenatis urna. Praesent libero ex, iaculis a feugiat nec, tempus quis felis. Maecenas eget urna a mauris euismod tristique. Integer feugiat arcu non dolor interdum gravida. Proin sollicitudin velit ac urna dictum lacinia nec quis ex. Donec at efficitur ex, eget efficitur lorem. Nam et justo eget libero lobortis accumsan. Nunc et mi iaculis, aliquam metus sed, ullamcorper nibh. Integer volutpat malesuada molestie. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Vestibulum at consectetur purus, at placerat felis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "InitialCreate",
            //        ModifiedDate = DateTime.Now,
            //        Note = "C++ Makale Yorumu",
            //    },
            //    new Comment
            //    {
            //        Id = 3,
            //        ArticleId = 3,
            //        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc a tincidunt ligula, ut venenatis urna. Praesent libero ex, iaculis a feugiat nec, tempus quis felis. Maecenas eget urna a mauris euismod tristique. Integer feugiat arcu non dolor interdum gravida. Proin sollicitudin velit ac urna dictum lacinia nec quis ex. Donec at efficitur ex, eget efficitur lorem. Nam et justo eget libero lobortis accumsan. Nunc et mi iaculis, aliquam metus sed, ullamcorper nibh. Integer volutpat malesuada molestie. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Vestibulum at consectetur purus, at placerat felis. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
            //        IsActive = true,
            //        IsDeleted = false,
            //        CreatedByName = "InitialCreate",
            //        CreatedDate = DateTime.Now,
            //        ModifiedByName = "InitialCreate",
            //        ModifiedDate = DateTime.Now,
            //        Note = "JavaScript Makale Yorumu",
            //    }
            //    );
        }
    }
}
