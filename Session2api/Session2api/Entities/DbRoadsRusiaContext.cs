using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Session2api.Entities;

public partial class DbRoadsRusiaContext : DbContext
{
    public DbRoadsRusiaContext()
    {
    }

    public DbRoadsRusiaContext(DbContextOptions<DbRoadsRusiaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=dbRoadsRusia;TrustServerCertificate=true;Trusted_Connection=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasKey(e => e.IdDivision);

            entity.Property(e => e.IdDivision)
                .ValueGeneratedNever()
                .HasColumnName("idDivision");
            entity.Property(e => e.DivInfo)
                .HasMaxLength(50)
                .HasColumnName("divInfo");
            entity.Property(e => e.DivLead)
                .HasMaxLength(50)
                .HasColumnName("divLead");
            entity.Property(e => e.DivName)
                .HasMaxLength(50)
                .HasColumnName("divName");
            entity.Property(e => e.IdStaff).HasColumnName("idStaff");

            entity.HasOne(d => d.IdStaffNavigation).WithMany(p => p.Divisions)
                .HasForeignKey(d => d.IdStaff)
                .HasConstraintName("FK_Divisions_Staff");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.IdEvent);

            entity.Property(e => e.IdEvent)
                .ValueGeneratedNever()
                .HasColumnName("idEvent");
            entity.Property(e => e.EventDateTime)
                .HasColumnType("datetime")
                .HasColumnName("eventDateTime");
            entity.Property(e => e.EventInfo)
                .HasMaxLength(50)
                .HasColumnName("eventInfo");
            entity.Property(e => e.EventName)
                .HasMaxLength(50)
                .HasColumnName("eventName");
            entity.Property(e => e.EventSponsors)
                .HasMaxLength(50)
                .HasColumnName("eventSponsors");
            entity.Property(e => e.EventStatus)
                .HasMaxLength(50)
                .HasColumnName("eventStatus");
            entity.Property(e => e.EventType)
                .HasMaxLength(50)
                .HasColumnName("eventType");
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");
            entity.Property(e => e.MatAcceptDate).HasColumnName("matAcceptDate");
            entity.Property(e => e.MatAuthor)
                .HasMaxLength(50)
                .HasColumnName("matAuthor");
            entity.Property(e => e.MatChangeDate).HasColumnName("matChangeDate");
            entity.Property(e => e.MatName)
                .HasMaxLength(50)
                .HasColumnName("matName");
            entity.Property(e => e.MatScope)
                .HasMaxLength(50)
                .HasColumnName("matScope");
            entity.Property(e => e.MatStatus)
                .HasMaxLength(50)
                .HasColumnName("matStatus");
            entity.Property(e => e.MatType)
                .HasMaxLength(50)
                .HasColumnName("matType");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.IdStaff);

            entity.Property(e => e.IdStaff)
                .ValueGeneratedNever()
                .HasColumnName("idStaff");
            entity.Property(e => e.Assistant)
                .HasMaxLength(50)
                .HasColumnName("assistant");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Cabinet)
                .HasMaxLength(50)
                .HasColumnName("cabinet");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.FisrtName)
                .HasMaxLength(50)
                .HasColumnName("fisrtNAme");
            entity.Property(e => e.IdDivision).HasColumnName("idDivision");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("lastName");
            entity.Property(e => e.Leader)
                .HasMaxLength(50)
                .HasColumnName("leader");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("middleName");
            entity.Property(e => e.OtherInfo)
                .HasMaxLength(50)
                .HasColumnName("otherInfo");
            entity.Property(e => e.PersonalPhone)
                .HasMaxLength(50)
                .HasColumnName("personalPhone");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .HasColumnName("position");
            entity.Property(e => e.WorkPhone)
                .HasMaxLength(50)
                .HasColumnName("workPhone");

            entity.HasOne(d => d.IdDivisionNavigation).WithMany(p => p.Staff)
                .HasForeignKey(d => d.IdDivision)
                .HasConstraintName("FK_Staff_Divisions");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
