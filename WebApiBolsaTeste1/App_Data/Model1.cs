namespace WebApiBolsaTeste1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Conta> Contas { get; set; }
        public virtual DbSet<Monitoramento> Monitoramentos { get; set; }
        public virtual DbSet<Negociacao> Negociacaos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
