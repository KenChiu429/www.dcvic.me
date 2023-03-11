using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ContaminationOfRecyclable.Models
{
    public partial class Contamination_Models : DbContext
    {
        public Contamination_Models()
            : base("name=Contamination_Models")
        {
        }

        public virtual DbSet<Contamination> Contaminations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contamination>()
                .Property(e => e.period)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
