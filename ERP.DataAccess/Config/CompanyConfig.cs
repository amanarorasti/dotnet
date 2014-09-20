using ERP.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.DataAccess
{
    public class CompanyConfig : EntityTypeConfiguration<Company>
    {
        public CompanyConfig()
        {
            base.Property(c => c.Name).HasMaxLength(250);            
        }
    }
}
