﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestGit.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBUserEntities : DbContext
    {
        public DBUserEntities()
            : base("name=DBUserEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminAccount> AdminAccounts { get; set; }
        public virtual DbSet<Airplane> Airplanes { get; set; }
        public virtual DbSet<AirplaneClass> AirplaneClasses { get; set; }
        public virtual DbSet<AirplaneInfo> AirplaneInfoes { get; set; }
        public virtual DbSet<AirplaneType> AirplaneTypes { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<FlightSchedule> FlightSchedules { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
    }
}
