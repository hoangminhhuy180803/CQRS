using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database.EntityTypeConfiguration
{
    public class BookEntityTypeConfiguration : IEntityTypeConfiguration<Books>
    {
        public void Configure(EntityTypeBuilder<Books> builder)
        {
            builder.ToTable("Books"); // Đặt tên bảng
            builder.HasKey(b => b.Id); // Đặt khóa chính
            builder.Property(b => b.Name).IsRequired(); // Cấu hình thuộc tính Title là bắt buộc
            builder.Property(b => b.Authors).HasMaxLength(100); // Cấu hình độ dài tối đa cho thuộc tính Author
            builder.Property(b => b.Quantity).IsRequired(); // Cấu hình thuộc tính Quantity là bắt buộc
            builder.Property(b => b.Quantity).HasDefaultValue(0); // Cấu hình giá trị mặc định cho Quantity là 0
            builder.Property(b => b.Quantity).HasColumnType("int"); // Cấu hình kiểu dữ liệu cho Quantity là int

        }
    }
}
