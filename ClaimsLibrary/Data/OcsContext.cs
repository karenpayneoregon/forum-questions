﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ClaimsLibrary.Models;

#nullable disable

namespace ClaimsLibrary.Data
{
    public partial class OcsContext : DbContext
    {
        public OcsContext()
        {
        }

        public OcsContext(DbContextOptions<OcsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllDoneCode> AllDoneCodes { get; set; }
        public virtual DbSet<IccTran> IccTrans { get; set; }
        public virtual DbSet<OcsMessage> OcsMessages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=OCS;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new IccTranConfiguration());
            modelBuilder.ApplyConfiguration(new OcsMessageConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}