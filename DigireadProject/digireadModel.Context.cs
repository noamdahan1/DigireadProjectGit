﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigireadProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class libraryProject_digireadEntities : DbContext
    {
        public libraryProject_digireadEntities()
            : base("name=libraryProject_digireadEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<PasswordResetTokens> PasswordResetTokens { get; set; }
        public virtual DbSet<Purchases> Purchases { get; set; }
        public virtual DbSet<Rentals> Rentals { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<WaitList> WaitList { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public virtual DbSet<Books> Books { get; set; }
    }
}
