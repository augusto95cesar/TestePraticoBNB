using CaixaPrevidenciaBNB.Models.Entity;
using System.Data.Entity;

namespace CaixaPrevidenciaBNB.Models.Repository
{
    public class BNEContext : DbContext
    {
        public BNEContext() : base("name=bnbContext") { }

        public DbSet<Empregado> Clientes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove();
            modelBuilder.Properties().Where(p => p.Name == "Id").Configure(p => p.IsKey());
        } 
    }
}