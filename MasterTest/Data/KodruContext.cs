﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MasterTest.Models;

#nullable disable

namespace MasterTest.Data
{
    public partial class KodruContext : DbContext
    {
        public KodruContext()
        {
        }

        public KodruContext(DbContextOptions<KodruContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attachments> Attachments { get; set; }
        public virtual DbSet<Business> Business { get; set; }
        public virtual DbSet<ConvergeData> ConvergeData { get; set; }
        public virtual DbSet<Dfsauthorization> Dfsauthorization { get; set; }
        public virtual DbSet<Expenses> Expenses { get; set; }
        public virtual DbSet<MasterLink> MasterLink { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=payments.c6etzwi92wft.us-east-2.rds.amazonaws.com;Initial Catalog=Kodru;Persist Security Info=True;User ID=kishorekodru;Password=Wac4uSEc");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Attachments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileExtension)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Business>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.BusinessType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dbaname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DBAName");

                entity.Property(e => e.Fein).HasColumnName("FEIN");

                entity.Property(e => e.JoinedDate).HasColumnType("datetime");

                entity.Property(e => e.LeftDate).HasColumnType("datetime");

                entity.Property(e => e.LegalName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConvergeData>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AddressOnCard).HasMaxLength(500);

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ApprovalCode).HasMaxLength(200);

                entity.Property(e => e.BrandId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BrandID");

                entity.Property(e => e.Ccnumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CCNumber");

                entity.Property(e => e.Cctype)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CCType");

                entity.Property(e => e.ExpiryDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WhoIsPaying)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dfsauthorization>(entity =>
            {
                entity.ToTable("DFSAuthorization");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ID");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.Property(e => e.ApprovedFullRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ApprovedPartRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

                entity.Property(e => e.AuthorizationDate).HasColumnType("datetime");

                entity.Property(e => e.CaseNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CaseWorkerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChildName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClientId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClientID");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.ParentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentPortionFullRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ParentPortionPartRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            });

            modelBuilder.Entity<Expenses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.DateSaved).HasColumnType("datetime");

                entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            });

            modelBuilder.Entity<MasterLink>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DfsproviderNumber).HasColumnName("DFSProviderNumber");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}