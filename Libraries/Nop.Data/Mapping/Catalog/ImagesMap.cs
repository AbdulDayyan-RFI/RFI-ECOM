using Nop.Core.Domain.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Data.Mapping.Catalog
{
    public partial class ImagesMap : NopEntityTypeConfiguration<Images>
    {
        public ImagesMap()
        {
            this.ToTable("Images");
            this.HasKey(c => c.Id);
            this.Property(c => c.ProductId);
            this.Property(c => c.CategoryId);
            this.Property(c => c.ImageName);
            this.Property(c => c.IsActive);
            this.Property(c => c.CreatedDate);
        }
    }
}
