using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MetierSharedMemory.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class AppSharedMemoryContext: DbContext
    {
        public AppSharedMemoryContext() : base("AppSharedMemory") { }

        public DbSet<Personne> personne {  get; set; }

        public DbSet<Memoire> memoire { get; set; }

        public DbSet<Encadreur> encadreur { get; set; }

    }
}