using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace PHS.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Declaration> Declarations { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Pacient> Pacients { get; set; }
        public DbSet<Preparation> Preparations { get; set; }
        public DbSet<TurnDoctor> TurnDoctors { get; set; }
        public DbSet<TurnPacient> TurnPacients { get; set; }
        public DbSet<UsePreparation> UsePreparations { get; set; }

    }
}