using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using AVL.Domain.Entities;

namespace AVL.Domain.Concrete
{
    public class EFDbContext: DbContext
    {
      
        public DbSet<Institute> Institute { get; set; }
        public DbSet<BasicInfo> BasicInfo { get; set; }
        public DbSet<AccountType> AccountType { get; set; }
        public DbSet<AccountParent> AccountParent { get; set; }
        public DbSet<AccountHeads> AccountHeads { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<AccountGL> AccountGL { get; set; }
        public DbSet<Emails> Emails { get; set; }
        public DbSet<BusinessDay> BusinessDay { get; set; }
        public DbSet<Project> Project { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
